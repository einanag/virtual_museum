using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class Form7 : Form
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private List<CartItem> cartItems = new List<CartItem>();
        private CultureInfo euroCulture = new CultureInfo("el-GR");

        public Form7()
        {
            InitializeComponent();
            seatingMapControl1.SeatSelected += SeatingMapControl1_SeatSelected;
            seatingMapControl1.SeatUnselected += SeatingMapControl1_SeatUnselected;
            dataGridViewEvents.CellClick += DataGridViewEvents_CellClick;
            SetupDataGridViews();
            LoadMenu();
            LoadEvents_1();

            seatingMapControl1.Visible = false;
            seatingMapControl1.Enabled = false;
            dataGridViewMenu.Enabled = false;
            buttonAddToCart.Enabled = false;
            buttonRemoveFromCart.Enabled = false;

            System.Threading.Thread.CurrentThread.CurrentCulture = euroCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = euroCulture;

            LoadEvents(DateTime.Now);

            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
        }

        private void SetupDataGridViews()
        {
            dataGridViewMenu.Columns.Add("Item", "Προϊόν");
            dataGridViewMenu.Columns.Add("Price", "Τιμή");
            dataGridViewMenu.Columns[1].DefaultCellStyle.Format = "C2";
            dataGridViewMenu.Columns[1].DefaultCellStyle.FormatProvider = euroCulture;

            dataGridViewCart.Columns.Add("Item", "Προϊόν");
            dataGridViewCart.Columns.Add("Price", "Τιμή");
            dataGridViewCart.Columns[1].DefaultCellStyle.Format = "C2";
            dataGridViewCart.Columns[1].DefaultCellStyle.FormatProvider = euroCulture;

            dataGridViewEvents.Columns.Add("EventId", "Όνομα Εκδήλωσης");
            dataGridViewEvents.Columns.Add("Date", "Ημερομηνία");
            dataGridViewEvents.Columns[1].DefaultCellStyle.Format = "C2";
            dataGridViewEvents.Columns[1].DefaultCellStyle.FormatProvider = euroCulture;

            dataGridViewMenu.BackgroundColor = Color.White;
            dataGridViewMenu.GridColor = Color.LightGray;
            dataGridViewMenu.DefaultCellStyle.BackColor = Color.LightYellow;
            dataGridViewMenu.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMenu.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridViewMenu.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewCart.BackgroundColor = Color.White;
            dataGridViewCart.GridColor = Color.LightGray;
            dataGridViewCart.DefaultCellStyle.BackColor = Color.LightYellow;
            dataGridViewCart.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewCart.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridViewCart.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewEvents.BackgroundColor = Color.White;
            dataGridViewEvents.GridColor = Color.LightGray;
            dataGridViewEvents.DefaultCellStyle.BackColor = Color.LightYellow;
            dataGridViewEvents.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEvents.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridViewEvents.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadMenu()
        {
            menuItems.Clear();
            dataGridViewMenu.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=museum.db;Version=3;"))
            {
                connection.Open();
                string query = "SELECT Item, Price FROM Cafeteria";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["Item"].ToString();
                            decimal itemPrice = Convert.ToDecimal(reader["Price"]);
                            menuItems.Add(new MenuItem(itemName, itemPrice));
                            dataGridViewMenu.Rows.Add(itemName, itemPrice.ToString("C2", euroCulture));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void LoadEvents_1()
        {
            dataGridViewEvents.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=museum.db;Version=3;"))
            {
                connection.Open();
                string query = "SELECT EventID, FromDate, Description FROM Events";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int eventId = Convert.ToInt32(reader["EventID"]);
                            DateTime fromDate = Convert.ToDateTime(reader["FromDate"]);
                            string description = reader["Description"].ToString();
                            dataGridViewEvents.Rows.Add(description, fromDate.ToString("dd/MM/yyyy"));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void LoadEvents(DateTime selectedDate)
        {
            listBoxEvents.Items.Clear();
            bool eventsFound = false;

            string connectionString = "Data Source=museum.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT FromDate, Description 
                                 FROM Events 
                                 WHERE DATE(FromDate) = DATE(@SelectedDate)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eventsFound = true;

                            var eventItem = new EventItem
                            {
                                FromDate = DateTime.Parse(reader["FromDate"].ToString()),
                                Description = reader["Description"].ToString()
                            };

                            listBoxEvents.Items.Add($"{eventItem.FromDate.ToShortDateString()} - {eventItem.Description}");
                        }
                    }
                }
            }

            if (!eventsFound)
            {
                listBoxEvents.Items.Add("No events found on this day");
                seatingMapControl1.Visible = false;
                label2.Visible = true;
                dataGridViewEvents.Visible = true;
            }
        }

        private void datePickerEvent_ValueChanged(object sender, EventArgs e)
        {
            LoadEvents(datePickerEvent.Value.Date);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem != null)
            {
                string selectedItemText = listBoxEvents.SelectedItem.ToString();
                string eventDescription = selectedItemText.Split(new[] { '-' }, 2).Last().Trim();

                EventItem selectedEvent = GetEventByDescription(eventDescription);

                if (selectedEvent != null)
                {
                    if (selectedItemText == "No events found on this day")
                    {
                        label2.Visible = true;
                        dataGridViewEvents.Visible = true;
                        seatingMapControl1.Visible = false;
                        seatingMapControl1.Enabled = false;
                        dataGridViewMenu.Enabled = false;
                        buttonAddToCart.Enabled = false;
                        buttonRemoveFromCart.Enabled = false;
                    }
                    else
                    {
                        label2.Visible = false;
                        dataGridViewEvents.Visible = false;
                        seatingMapControl1.Visible = true;
                        seatingMapControl1.Enabled = true;
                        dataGridViewMenu.Enabled = true;
                        buttonAddToCart.Enabled = true;
                        buttonRemoveFromCart.Enabled = true;
                    }
                }
            }
            else
            {
                seatingMapControl1.Visible = false;
                seatingMapControl1.Enabled = false;
                dataGridViewMenu.Enabled = false;
                buttonAddToCart.Enabled = false;
                buttonRemoveFromCart.Enabled = false;
            }
        }

        private EventItem GetEventByDescription(string description)
        {
            foreach (var eventItem in listBoxEvents.Items.OfType<string>())
            {
                if (eventItem.Contains(description))
                {
                    return new EventItem
                    {
                        Description = description,
                    };
                }
            }
            return null;
        }

        private void DataGridViewEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBoxEvents.Items.Clear();
            if (e.RowIndex >= 0)
            {
                string eventDescription = dataGridViewEvents.Rows[e.RowIndex].Cells["EventId"].Value.ToString();
                string eventDate = dataGridViewEvents.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                string eventDetails = $"{eventDate} - {eventDescription}";

                if (!listBoxEvents.Items.Contains(eventDetails))
                {
                    listBoxEvents.Items.Add(eventDetails);
                    datePickerEvent.Value = Convert.ToDateTime(eventDate);
                }

                listBoxEvents_SelectedIndexChanged(null, null);
            }
        }

        private void SeatingMapControl1_SeatSelected(object sender, SeatSelectedEventArgs e)
        {
            listBox1.Items.Add($"{e.SeatId} - {e.SelectedZone.Name} - {e.SelectedZone.Price.ToString("C2", euroCulture)}");
            UpdateTotal();
        }

        private void SeatingMapControl1_SeatUnselected(object sender, SeatSelectedEventArgs e)
        {
            listBox1.Items.Remove($"{e.SeatId} - {e.SelectedZone.Name} - {e.SelectedZone.Price.ToString("C2", euroCulture)}");
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal seatTotal = seatingMapControl1.GetTotalPrice();
            decimal cartTotal = cartItems.Sum(item => item.Price);
            decimal total = seatTotal + cartTotal;
            labelTotal.Text = $"Συνολική τιμή: {total.ToString("C2", euroCulture)}";
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                string itemName = selectedRow.Cells["Item"].Value.ToString();
                decimal itemPrice = decimal.Parse(selectedRow.Cells["Price"].Value.ToString(), NumberStyles.Currency, euroCulture);

                CartItem newItem = new CartItem(itemName, itemPrice);
                cartItems.Add(newItem);
                dataGridViewCart.Rows.Add(itemName, itemPrice.ToString("C2", euroCulture));
                UpdateTotal();
                MessageBox.Show($"{itemName} has been added to your cart.");
            }
            else
            {
                MessageBox.Show("Please select an item from the menu.");
            }
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCart.SelectedRows[0];
                string itemName = selectedRow.Cells[0].Value.ToString();

                dataGridViewCart.Rows.Remove(selectedRow);
                cartItems.RemoveAll(item => item.Name == itemName);
                UpdateTotal();
                MessageBox.Show($"{itemName} has been removed from your cart.");
            }
            else
            {
                MessageBox.Show("Please select an item from the cart to remove.");
            }
        }

        private bool IsValidCreditCardNumber(string cardNumber)
        {
            return !string.IsNullOrWhiteSpace(cardNumber) && cardNumber.All(char.IsDigit) && cardNumber.Length >= 13 && cardNumber.Length <= 19;
        }

        private void FinalizeBooking()
        {

            if (listBoxEvents.SelectedItem != null)
            {
                string selectedEventDescription = listBoxEvents.SelectedItem.ToString();
                var booking = new Booking
                {
                    EventName = selectedEventDescription,
                    BookingDate = DateTime.Now
                };

                // calculate total amount
                decimal totalAmount = seatingMapControl1.GetTotalPrice() + cartItems.Sum(item => item.Price);
                string comments = textBoxComments.Text;
                string seats = string.Join(", ", listBox1.Items.Cast<string>());

                // save booking to db
                var db = MuseumDatabase.Instance;
                db.AddBooking(booking, totalAmount, comments, seats);


                listBox1.Items.Clear();
                cartItems.Clear();
                dataGridViewCart.Rows.Clear();
                textBoxComments.Clear();
                textBoxCreditCard.Clear();
                UpdateTotal();


                listBoxEvents.ClearSelected();


                seatingMapControl1.ClearSelectedSeats();


                dataGridViewMenu.ClearSelection();

                MessageBox.Show("Η κράτηση ολοκληρώθηκε με επιτυχία!", "Επιτυχής Κράτηση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Visible = true;
                dataGridViewEvents.Visible = true;
                labelTotal.Text = $"Συνολική τιμή: ";

            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα γεγονός πριν ολοκληρώσετε την κράτηση.", "Δεν επιλέχθηκε γεγονός", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadEvents(DateTime.Now);
            LoadMenu();
            UpdateTotal();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if (IsValidCreditCardNumber(textBoxCreditCard.Text))
            {
                if (listBoxEvents.SelectedItem != null)
                {
                    string selectedEventDescription = listBoxEvents.SelectedItem.ToString();
                    decimal totalPrice = seatingMapControl1.GetTotalPrice() + cartItems.Sum(item => item.Price);
                    string message = $"Επιλέξατε: {selectedEventDescription}\n\n";
                    message += $"Συνολικό ποσό: {totalPrice.ToString("C2", euroCulture)}\n\nΕπιλεγμένες θέσεις:\n";
                    foreach (var item in listBox1.Items)
                    {
                        message += item.ToString() + "\n";
                    }
                    message += "\nΠροϊόντα καφετέριας:\n";
                    foreach (var item in cartItems)
                    {
                        message += $"{item.Name} - {item.Price.ToString("C2", euroCulture)}\n";
                    }
                    if (!string.IsNullOrWhiteSpace(textBoxComments.Text))
                    {
                        message += $"\nΠαρατηρήσεις:\n{textBoxComments.Text}\n";
                    }
                    message += "\nΕίστε σίγουροι ότι θέλετε να ολοκληρώσετε την κράτηση;";

                    DialogResult result = MessageBox.Show(message, "Επιβεβαίωση Κράτησης", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinalizeBooking();
                    }
                }
                else
                {
                    MessageBox.Show("Παρακαλώ επιλέξτε ένα γεγονός πριν προχωρήσετε με την πληρωμή σας.", "Δεν επιλέχθηκε γεγονός", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Παρακαλώ εισάγετε έναν έγκυρο αριθμό πιστωτικής κάρτας.", "Μη έγκυρη κάρτα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
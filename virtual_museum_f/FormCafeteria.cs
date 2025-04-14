using System;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormCafeteria : Form
    {
        private CultureInfo euroCulture = new CultureInfo("el-GR");

        public FormCafeteria()
        {
            InitializeComponent();
            SetupDataGridViews();
            LoadMenu();
        }

        private void SetupDataGridViews()
        {
            //DataGridView for the menu
            dataGridViewMenu.Columns.Add("Item", "Προϊόν");
            dataGridViewMenu.Columns.Add("Price", "Τιμή");
            dataGridViewMenu.Columns[1].DefaultCellStyle.Format = "C2";
            dataGridViewMenu.Columns[1].DefaultCellStyle.FormatProvider = euroCulture;

            //DataGridView for the cart
            dataGridViewCart.Columns.Add("Item", "Προϊόν");
            dataGridViewCart.Columns.Add("Price", "Τιμή");
            dataGridViewCart.Columns[1].DefaultCellStyle.Format = "C2";
            dataGridViewCart.Columns[1].DefaultCellStyle.FormatProvider = euroCulture;

            // styling 
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
        }
        private void LoadMenu()
        {
            dataGridViewMenu.Rows.Clear();

            // strng connect with db
            string connectionString = "Data Source=museum.db";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Item, Price FROM Cafeteria";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //get items prices frm db
                        string itemName = reader.GetString(0); //menu items
                        decimal itemPrice = reader.GetDecimal(1); // price
                        dataGridViewMenu.Rows.Add(itemName, itemPrice);
                    }
                }
            }
        }



        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenu.SelectedRows[0];
                dataGridViewCart.Rows.Add(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value);
                UpdateTotal();
            }
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                dataGridViewCart.Rows.RemoveAt(dataGridViewCart.SelectedRows[0].Index);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[1].Value);
                }
            }
            labelTotal.Text = $"Σύνολο: {total.ToString("C2", euroCulture)}";
        }

        public void ClearCart()
        {
            dataGridViewCart.Rows.Clear();
            UpdateTotal();
        }

        private void buttonPayWithCard_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count > 0)
            {
                decimal total = decimal.Parse(labelTotal.Text.Split(':')[1].Trim(), NumberStyles.Currency, euroCulture);
                string items = string.Join(", ", dataGridViewCart.Rows.Cast<DataGridViewRow>().Select(r => r.Cells[0].Value.ToString()));

                // Save order to the database
                var db = MuseumDatabase.Instance;
                var order = new Order
                {
                    OrderDate = DateTime.Now,
                    TotalAmount = total,
                    OrderDetails = items
                };
                db.AddOrder(order); // Save the order to the database

                PaymentForm paymentForm = new PaymentForm(this, total, items);
                paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Το καλάθι είναι άδειο.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormCafeteria_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
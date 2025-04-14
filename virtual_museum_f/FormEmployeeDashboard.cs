using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormEmployeeDashboard : Form
    {
        private List<Exhibition> exhibitions;
        private List<Event> events;
        private List<Order> orders;
        private List<Booking> bookings;
        private List<DJBooking> djBookings;

        public bool IsAdmin { get; set; }

        public FormEmployeeDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var db = MuseumDatabase.Instance;
            exhibitions = db.GetExhibitions();
            events = db.GetEvents();
            orders = db.GetOrders();
            bookings = db.GetBookings();
            djBookings = db.GetDJBookings();
        }

        private void buttonManageExhibits_Click(object sender, EventArgs e)
        {
            string message = "Λίστα Εκθεμάτων:\n\n";
            foreach (var exhibition in exhibitions)
            {
                message += $"ID: {exhibition.Id}, Όνομα: {exhibition.Name}, Επισκέπτες: {exhibition.Visitors}, Προβολές: {exhibition.Views}\n";
            }
            MessageBox.Show(message, "Διαχείριση Εκθεμάτων", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageScreenings_Click(object sender, EventArgs e)
        {
            string message = "Λίστα Εκδηλώσεων:\n\n";
            foreach (var ev in events)
            {
                message += $"ID: {ev.EventID}, Από: {ev.FromDate},  Περιγραφή: {ev.Description} \n";
            }
            MessageBox.Show(message, "Διαχείριση Εκδηλώσεων", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            string message = "Λίστα Παραγγελιών:\n\n";
            foreach (var order in orders)
            {
                message += $"ID: {order.Id}, Ημερομηνία: {order.OrderDate}, Σύνολο: {order.TotalAmount:C2}, Λεπτομέρειες: {order.OrderDetails}\n";
            }
            MessageBox.Show(message, "Διαχείριση Παραγγελιών", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageBookings_Click(object sender, EventArgs e)
        {
            string message = "Λίστα Κρατήσεων:\n\n";
            foreach (var booking in bookings)
            {
                message += $"ID: {booking.Id}, Εκδήλωση: {booking.EventName}, Ημερομηνία: {booking.BookingDate}, Σύνολο: {booking.TotalAmount:C2}, Σχόλια: {booking.Comments}, Θέσεις: {booking.Seats}\n";
            }

            message += "\n\nΛίστα Κρατήσεων DJ:\n\n";
            foreach (var djBooking in djBookings)
            {
                message += $"ID: {djBooking.Id}, Ημερομηνία: {djBooking.BookingDate}\n";
            }

            MessageBox.Show(message, "Διαχείριση Κρατήσεων", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEmployeeDashboard_Load(object sender, EventArgs e)
        {
            //if (!IsAdmin)
            //{
            //buttonManageExhibits.Enabled = false;
            //buttonManageScreenings.Enabled = false;
            //}
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            string report = "Αναφορά Μουσείου:\n\n";
            report += $"Συνολικά Εκθέματα: {exhibitions.Count}\n";
            report += $"Συνολικές Εκδηλώσεις: {events.Count}\n";
            report += $"Συνολικές Παραγγελίες: {orders.Count}\n";
            report += $"Συνολικές Κρατήσεις: {bookings.Count + djBookings.Count}\n";
            report += $"Συνολικά Έσοδα Καφετέριας: {orders.Sum(o => o.TotalAmount):C2}\n";

            MessageBox.Show(report, "Αναφορά Μουσείου", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
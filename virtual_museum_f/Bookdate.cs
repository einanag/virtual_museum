using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using virtual_museum_f;

namespace App_DJ
{
    public partial class Bookdate : Form
    {
        private List<DateTime> occupiedDates;

        public Bookdate()
        {
            InitializeComponent();
            occupiedDates = new List<DateTime>();
            LoadOccupiedDates();
            buttonContinue.Enabled = false;
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void LoadOccupiedDates()
        {
            var db = MuseumDatabase.Instance;
            occupiedDates = db.GetOccupiedDates();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;
            if (occupiedDates.Contains(selectedDate))
            {
                labelStatus.Text = "Μη Διαθέσιμο";
                labelStatus.ForeColor = Color.Red;
                buttonContinue.Enabled = false;
            }
            else
            {
                labelStatus.Text = "Διαθέσιμο";
                labelStatus.ForeColor = Color.Green;
                buttonContinue.Enabled = true;
            }
        }

        private void Bookdate_Load(object sender, EventArgs e)
        {
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;

            if (!occupiedDates.Contains(selectedDate))
            {
                // save booking to  db and get the booking ID
                var db = MuseumDatabase.Instance;
                int bookingId = db.AddDJBooking(new DJBooking { BookingDate = selectedDate });

                occupiedDates.Add(selectedDate);

                MessageBox.Show($"Η κράτηση ολοκληρώθηκε επιτυχώς.\nΑριθμός Κράτησης: {bookingId}\nΗμερομηνία: {selectedDate.ToShortDateString()}",
                                "Επιτυχής Κράτηση",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // open  DJ form with the selected date & booking ID
                DJ djForm = new DJ(selectedDate, bookingId);
                OpenForm(djForm);
            }
            else
            {
                MessageBox.Show("Η επιλεγμένη ημερομηνία δεν είναι διαθέσιμη.",
                                "Σφάλμα Κράτησης",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
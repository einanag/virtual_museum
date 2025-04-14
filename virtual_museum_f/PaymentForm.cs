using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class PaymentForm : Form
    {
        private FormCafeteria formCafeteria;
        private decimal total;
        private string items;

        public PaymentForm(FormCafeteria formCafeteria, decimal total, string items)
        {
            InitializeComponent();
            this.formCafeteria = formCafeteria;
            this.total = total;
            this.items = items;
            this.Text = $"Payment - Total: {total.ToString("C2", new CultureInfo("el-GR"))}";
        }

        private void ConfirmPayment(object sender, EventArgs e)
        {
            if (IsValidPaymentDetails())
            {
                string orderCode = Guid.NewGuid().ToString().Substring(0, 8);
                DateTime orderDate = DateTime.Now;
                MessageBox.Show($"Πληρωμή επιτυχής!\n\nΗμερομηνία: {orderDate}\nΚωδικός παραγγελίας: {orderCode}\nΠροϊόντα: {items}\nΣύνολο: {total.ToString("C2", new CultureInfo("el-GR"))}", "Επιβεβαίωση Πληρωμής", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formCafeteria.ClearCart();
                this.Close();
            }
            else
            {
                MessageBox.Show("Παρακαλώ ελέγξτε τα στοιχεία πληρωμής.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate card number
        /// Validate card holder name (latin characters only)
        /// Validate expiration date (MM/YYYY)
        /// Validate CVV
        /// </summary>
        private bool IsValidPaymentDetails()
        {
            if (textBoxCardNumber.Text.Length != 16 || !textBoxCardNumber.Text.All(char.IsDigit))
                return false;

            if (!textBoxCardHolder.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                return false;

            if (!DateTime.TryParseExact(textBoxExpirationDate.Text, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            if (textBoxCVV.Text.Length != 3 || !textBoxCVV.Text.All(char.IsDigit))
                return false;

            return true;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ConfirmPayment(sender, e);
        }
    }
}
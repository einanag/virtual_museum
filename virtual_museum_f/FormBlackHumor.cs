using System;
using System.Drawing;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormBlackHumor : Form
    {
        public FormBlackHumor()
        {
            InitializeComponent();
            SetupBlackHumorExhibition();
        }

        private void SetupBlackHumorExhibition()
        {
            this.Text = "Έκθεση Μαύρου Χιούμορ";
            labelExhibitionName.Text = "Black Humor – Η επανάσταση του πνεύματος στην \r\nSianti Gallery με έργα ζωγραφικής από \r\n14 Έλληνες καλλιτέχνες";

            richTextBoxInfo.Text = "Η Sianti Gallery την Παρασκευή 11 Οκτωβρίου εγκαινιάζει την ομαδική έκθεση ζωγραφικής με τίτλο \"Black Humor\" – Η επανάσταση του πνεύματος.\n\n" +
            "Δεκατέσσερις καλλιτέχνες του σήμερα υποστηρίζουν ότι υπάρχει και το χρησιμοποιούν ο καθένας με τον δικό του ιδιαίτερο τρόπο, φτιάχνοντας έργα ειδικά για την έκθεση.";

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "black_humor.jpeg");
            pictureBoxExhibition.Image = Image.FromFile(imagePath);
            pictureBoxExhibition.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel contentPanel)
            {
                contentPanel.Controls.Clear();
                Form2 form2 = new Form2();
                form2.TopLevel = false;
                form2.FormBorderStyle = FormBorderStyle.None;
                form2.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(form2);
                form2.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}
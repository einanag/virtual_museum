using System;
using System.Drawing;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormKafka : Form
    {
        public FormKafka()
        {
            InitializeComponent();
            SetupKafkaExhibition();
        }

        private void SetupKafkaExhibition()
        {
            this.Text = "Έκθεση Κάφκα";
            labelExhibitionName.Text = "Τριπλή έκθεση για τα 100 χρόνια από τον θάνατο του Τσέχου συγγραφέα\r\nΦραντς Κάφκα στο Πολιτιστικό Κέντρο «Μελίνα»";

            richTextBoxInfo.Text = "Από τις Μεταμορφώσεις στην Πράγα και τον Άνθρωπο χωρίς εποχή\n\n" +
              "9 Οκτωβρίου 2024 - 31 Οκτωβρίου, 2024\n\n" +
              "Το Τσεχικό Κέντρο Αθήνας σε συνεργασία με την Ένωση Ελλήνων Χαρακτών, το Τμήμα Γερμανικής Γλώσσας και Φιλολογίας του ΕΚΠΑ και τις εκδόσεις ΟΞΥ σας προσκαλούν στην τριπλή έκθεση για την επέτειο των 100 ετών από τον θάνατο του Τσέχου συγγραφέα Φραντς Κάφκα, που πραγματοποιείται με την υποστήριξη του Οργανισμού Πολιτισμού, Αθλητισμού και Νεολαίας του Δήμου Αθηναίων. Η δράση εντάσσεται στο πλαίσιο του ετήσιου πολιτιστικού προγράμματος «Τέλος ή αρχή; Κάφκα 2024».\n\n" +
              "Στα εγκαίνια στις 9 Οκτωβρίου θα παρακολουθήσουμε τη βραβευμένη σόλο θεατρική performance \"ΙNSECTUM K.\" από την Πράγα.\n\n" +
              "Στους χώρους του Πολιτιστικού Κέντρου «Μελίνα» θα παρουσιάζονται όλο τον μήνα Οκτώβρη τρεις παράλληλες εκθέσεις με κοινό γνώμονα τον Φραντς Κάφκα:\n\n" +
              "1. «ΜΕΤΑΜΟΡΦΩΣΗ – ΠΡΟΣΕΓΓΙΣΕΙΣ ΣΤΟΝ ΚΑΦΚΑ» – έκθεση χαρακτικής\n" +
              "2. «Η ΠΡΑΓΑ ΤΟΥ ΚΑΦΚΑ» – έκθεση φωτογραφίας\n" +
              "3. «ΦΡΑΝΤΣ ΚΑΦΚΑ: ΑΝΘΡΩΠΟΣ ΧΩΡΙΣ ΕΠΟΧΗ» – έκθεση εικονογράφησης";

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "kafka.jpeg");
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
using System;
using System.Drawing;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormDaliCybernetics : Form
    {
        public FormDaliCybernetics()
        {
            InitializeComponent();
            SetupDaliCyberneticsExhibition();
        }

        private void SetupDaliCyberneticsExhibition()
        {
            this.Text = "Έκθεση Νταλί Κυβερνητική";
            labelExhibitionName.Text = "Dali Cybernetics – The Immersive Experience στην Αθήνα: \r\nΜια εμπειρία εμβύθισης στο σύμπαν του Σαλβαδόρ Νταλί";

            richTextBoxInfo.Text = "Παρακολουθούμε την πορεία των επιρροών του ζωγράφου, από τον υπερρεαλισμό και τον Φρόυντ ολοένα και περισσότερο προς τις θετικές επιστήμες, τα μαθηματικά, την πληροφορική\n\n" +
            "Η Τέχνη συναντά την Επιστήμη: Στην έκθεση θα απολαύσετε μία συναρπαστική περιήγηση στα πιο διάσημα έργα του Σαλβαδόρ Νταλί από μια εντελώς νέα οπτική. Μια εμπειρία αιχμής που βασίζεται σε παράλληλα σύμπαντα, την κβαντική φυσική, την τέταρτη διάσταση, την οπτική, την ιερή γεωμετρία και την αλληλουχία DNA όπως ερμηνεύονται από τον Νταλί μέσα από τα έργα του.";

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "dali_cybernetics.jpeg");
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
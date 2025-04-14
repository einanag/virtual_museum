using System;
using System.Drawing;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormDemocracy : Form
    {
        public FormDemocracy()
        {
            InitializeComponent();
            SetupDemocracyExhibition();
        }

        private void SetupDemocracyExhibition()
        {
            this.Text = "Έκθεση Δημοκρατίας";
            labelExhibitionName.Text = "«ΔΗΜΟΚΡΑΤΙΑ» στην Εθνική Πινακοθήκη – \r\nΜουσείο Αλεξάνδρου Σούτσου: Η σχέση της τέχνης \r\nμε την πολιτική ιστορία στη Νότια Ευρώπη μέσα από \r\n140 εικαστικά έργα";

            richTextBoxInfo.Text = "Η πρώτη μεγάλη, διεθνής έκθεση που πραγματεύεται τη σχέση της τέχνης με την δημοκρατία κατά την διάρκεια μιας από τις πιο καθοριστικές περιόδους για την ιστορία της Νότιας Ευρώπης\n\n" +
            "Η εκθεσιακή δραστηριότητα, η συγκρότηση καλλιτεχνικών ομάδων, ο κριτικός λόγος, ο ρόλος της αφηρημένης τέχνης, η ανάδειξη του κριτικού ρεαλισμού, η τέχνη της διαμαρτυρίας μέσω της αφίσας, της χαρακτικής και της performance, η διεκδίκηση της ορατότητας του σώματος σε ατομικό και συλλογικό επίπεδο, καθώς και η συνολικότερη εμπλοκή της τέχνης στη δημόσια σφαίρα επισφραγίζουν το αίτημα του εκδημοκρατισμού και αποτελούν σημαντικά πεδία έρευνας και εικαστικής δραστηριότητας.";

            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "dimokratia.jpg");
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

        private void pictureBoxExhibition_Click(object sender, EventArgs e)
        {
        }

        private void labelExhibitionName_Click(object sender, EventArgs e)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class Form2 : Form
    {
        private List<ExhibitionItem> exhibitions;

        public Form2()
        {
            InitializeComponent();
            exhibitions = new List<ExhibitionItem>();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeCustomComponents();
            LoadExhibitions();
        }

        private void InitializeCustomComponents()
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "rooms.jpg");
            pictureBoxMuseumMap.Image = Image.FromFile(imagePath);
            pictureBoxMuseumMap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadExhibitions()
        {
            var db = MuseumDatabase.Instance;
            var exhibitionList = db.GetExhibitions();

            foreach (var exhibition in exhibitionList)
            {
                exhibitions.Add(new ExhibitionItem { Name = exhibition.Name, Views = exhibition.Views });
            }
        }

        private void pictureBoxMuseumMap_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            if (IsInKafkaRoom(coordinates))
            {
                OpenExhibition("Kafka");
            }
            else if (IsInDemocracyRoom(coordinates))
            {
                OpenExhibition("Democracy");
            }
            else if (IsInBlackHumorRoom(coordinates))
            {
                OpenExhibition("Black Humor");
            }
            else if (IsInDaliCyberneticsRoom(coordinates))
            {
                OpenExhibition("Dali Cybernetics");
            }
        }

        private void OpenExhibition(string exhibitionName)
        {
            Form exhibitionForm = null;

            switch (exhibitionName)
            {
                case "Kafka":
                    exhibitionForm = new FormKafka();
                    break;
                case "Democracy":
                    exhibitionForm = new FormDemocracy();
                    break;
                case "Black Humor":
                    exhibitionForm = new FormBlackHumor();
                    break;
                case "Dali Cybernetics":
                    exhibitionForm = new FormDaliCybernetics();
                    break;
            }

            if (exhibitionForm != null)
            {
                var exhibition = exhibitions.FirstOrDefault(e => e.Name == exhibitionName);

                if (exhibition != null)
                {
                    exhibition.Views++;

                    var db = MuseumDatabase.Instance;
                    db.UpdateExhibitionViews(exhibitionName, exhibition.Views);
                }
                else
                {
                    MessageBox.Show($"Exhibition '{exhibitionName}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (this.Parent is Panel contentPanel)
                {
                    contentPanel.Controls.Clear();
                    exhibitionForm.TopLevel = false;
                    exhibitionForm.FormBorderStyle = FormBorderStyle.None;
                    exhibitionForm.Dock = DockStyle.Fill;
                    contentPanel.Controls.Add(exhibitionForm);
                    exhibitionForm.Show();
                }
            }
        }

        //  clickable areas for each room based on the image
        private bool IsInKafkaRoom(Point p) => p.X >= 0 && p.X <= 309 && p.Y >= 0 && p.Y <= 226;
        private bool IsInDemocracyRoom(Point p) => p.X >= 309 && p.X <= 618 && p.Y >= 0 && p.Y <= 226;
        private bool IsInBlackHumorRoom(Point p) => p.X >= 309 && p.X <= 618 && p.Y >= 226 && p.Y <= 452;
        private bool IsInDaliCyberneticsRoom(Point p) => p.X >= 0 && p.X <= 309 && p.Y >= 226 && p.Y <= 452;
    }

    public class ExhibitionItem
    {
        public string Name { get; set; }
        public int Views { get; set; }
    }
}
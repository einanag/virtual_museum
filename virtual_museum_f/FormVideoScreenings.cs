using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class FormVideoScreenings : Form
    {
        private List<VideoMenuItem> menuItems = new List<VideoMenuItem>();
        private List<VideoCartItem> cartItems = new List<VideoCartItem>();
        private CultureInfo euroCulture = new CultureInfo("el-GR");
        private Dictionary<string, List<VideoEvent>> events = new Dictionary<string, List<VideoEvent>>();
        private string selectedEventType = "";
        private string selectedEventName = "";

        private string lastPurchaseItems;
        private decimal lastPurchaseTotal;
        private string lastPurchaseEventType;
        private string lastPurchaseEventName;

        public FormVideoScreenings()
        {
            InitializeComponent();
            SetupDataGridViews();
            LoadMenu();
            LoadEvents();

            System.Threading.Thread.CurrentThread.CurrentCulture = euroCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = euroCulture;

            dataGridViewCart.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            buttonGeneratePdf.Enabled = false;
            buttonGeneratePdf.Click += buttonGeneratePdf_Click;
        }

        private void LoadEvents()
        {
            events.Clear();
            events["Συναυλίες"] = new List<VideoEvent>();
            events["Συνεντεύξεις"] = new List<VideoEvent>();
            events["Podcast"] = new List<VideoEvent>();


            // Συναυλίες
            AddEvent("AMELIE LENS & KI/KI", "23 Νοεμβρίου", "Σ.Ε.Φ. Στάδιο Ειρήνης & Φιλίας (Αρένα)", "https://www.youtube.com/embed/vjR_gc6c1xw?si=hA6w1mDjs15_555G", "Συναυλίες");
            AddEvent("Christmas Jazz με τους Glitter Grotesque", "15 Δεκ - 5 Ιαν", "Αμαξοστοιχία - Θέατρο το Τρένο στο Ρουφ - Μουσικό Βαγόνι Orient Express", "https://www.youtube.com/embed/hFulgsKJbVc?si=b46ufalahgkYv3Pd", "Συναυλίες");
            AddEvent("DAMIAN LAZARUS", "1 Νοεμβρίου", "Botoxe Athens", "https://www.youtube.com/embed/Uw29366xsRk?si=GxoHRQe3yq0OxW1a", "Συναυλίες");
            AddEvent("Halloween party 2024 🎃", "25 Οκτωβρίου", "Mezzo Athens", "https://www.youtube.com/embed/zgphH-YBmqg?si=cnyJpt1HgWQe_f_X", "Συναυλίες");
            AddEvent("HALLOWEEN PARTY with BEJEEZUS", "31 Οκτωβρίου", "Loulou is present", "https://www.youtube.com/embed/zgphH-YBmqg?si=cnyJpt1HgWQe_f_X", "Συναυλίες");
            AddEvent("HOGWARTS MAGIC SYMPHONY", "4 Ιανουαρίου", "CHRISTMAS THEATER", "https://www.youtube.com/embed/iFbwPzACEWw?si=VNEMFLCeCAVI_MFZ", "Συναυλίες");
            AddEvent("JASON DERULO", "15 - 16 Νοεμβρίου", "Πολλαπλοί χώροι", "https://www.youtube.com/embed/WDrEtuqDU1U?si=XdiVUfKnKEw6rYDG", "Συναυλίες");
            AddEvent("Madwalk 2024 by THREE CENTS", "2 Δεκεμβρίου", "Κλειστό Γήπεδο Tae Kwon Do", "https://www.youtube.com/embed/fo2Dd-QmL6I?si=EexxSRDv2-jXTK3q", "Συναυλίες");
            AddEvent("Mahmut Orhan @ Lohan", "15 Νοεμβρίου", "Lohan Night Club", "https://www.youtube.com/embed/xrStvqJzrZM?si=E8o_Sx5Bss_DLMhN", "Συναυλίες");
            AddEvent("Slimane World Tour", "15 - 16 Φεβρουαρίου", "Θέατρο Παλλάς", "https://www.youtube.com/embed/jJv2inLvupA?si=hJpGn-EOxGLoUTtz", "Συναυλίες");
            AddEvent("Stella Rose", "22 Νοεμβρίου", "Death Disco", "https://www.youtube.com/embed/U57TtwXKfew?si=ZzNFWqhVutNB9gPU", "Συναυλίες");
            AddEvent("Taylor Swift Night @ FRIDA", "20 Οκτωβρίου", "Frida Bar n' Stage", "https://www.youtube.com/embed/P5JLMp08GC0?si=IkTrbEWLbqboNbG6", "Συναυλίες");

            // Συνεντεύξεις
            AddEvent("Νίκος Καζαντζάκης στη Γαλλική Τηλεόραση (1957)", "1957", "Ο Καζαντζάκης μιλάει για τη φιλοσοφία του και τις πνευματικές του αναζητήσεις.", "https://fresques.ina.fr/europe-des-cultures-en/fiche-media/Europe00005/nikos-kazantzakis-regarding-zorba-the-greek-and-st-francis-of-assisi.html", "Συνεντεύξεις");
            AddEvent("David Frost Interviews Richard Nixon", "1977", "Ο Νίξον αποκαλύπτει στοιχεία για το σκάνδαλο Watergate.", "https://teachingamericanhistory.org/document/transcript-of-david-frosts-interview-with-richard-nixon/", "Συνεντεύξεις");
            AddEvent("Martin Bashir Interviews Princess Diana", "1995", "Η Πριγκίπισσα Νταϊάνα μιλάει για τον γάμο της και τη βασιλική ζωή.", "https://www.bbc.com/historyofthebbc/anniversaries/november/diana-interview", "Συνεντεύξεις");
            AddEvent("Oprah Winfrey Interviews Michael Jackson", "1993", "Ο Michael Jackson συζητά για την προσωπική του ζωή.", "https://en.wikipedia.org/wiki/Michael_Jackson_Talks_..._to_Oprah", "Συνεντεύξεις");
            AddEvent("Σαλβαδόρ Νταλί στο 'A fondo'", "1977", "Ο Νταλί αποκαλύπτει την εκκεντρική προσωπικότητά του.", "https://www.rtve.es/play/videos/a-fondo/salvador-dali-fondo-1977/4598867/", "Συνεντεύξεις");
            AddEvent("Σαρλ Ντε Γκωλ στον Michel Droit", "1965", "Ο Ντε Γκωλ αναλύει την εξωτερική πολιτική της Γαλλίας.", "https://www.ina.fr/ina-eclaire-actu/video/i00012574/le-general-de-gaulle-il-faut-le-progres-pas-la-pagaille", "Συνεντεύξεις");
            AddEvent("Freddie Mercury στον Rudi Dolezal", "1987", "Ο Mercury μιλάει για τη μουσική του και τις προκλήσεις του.", "https://www.e-tetradio.gr/Article/37141/h-teleytaia-thleoptikh-synenteyxh-toy-freddie-mercury--binteo", "Συνεντεύξεις");

            // Podcast
            AddEvent("The Brain Hacking Academy: Το κλειδί της επιτυχίας - Growth Mindset", "Επεισόδιο 1", "Ανάλυση του growth mindset και πώς να το υιοθετήσεις για επιτυχία.", "https://brainhackingacademy.gr/ep1-growth-mindset/", "Podcast");
            AddEvent("The Brain Hacking Academy: Μνήμη - Τεχνικές και μυστικά για να την κατακτήσεις", "Επεισόδιο 10", "Τεχνικές βελτίωσης της μνήμης και πρακτικές συμβουλές.", "https://brainhackingacademy.gr/ep10-memory/", "Podcast");
            AddEvent("GiatiOxi: Μήπως η Δουλειά σου Βλάπτει την Υγεία σου;", "Επεισόδιο #495", "Συζήτηση για τις επιπτώσεις της εργασίας στην υγεία με τον Ηλία Βασιλείου.", "https://giatioxi.gr/%CE%BC%CE%AE%CF%80%CF%89%CF%82-%CE%B7-%CE%B4%CE%BF%CF%85%CE%BB%CE%B5%CE%B9%CE%AC-%CF%83%CE%BF%CF%85-%CE%B2%CE%BB%CE%AC%CF%80%CF%84%CE%B5%CE%B9-%CF%84%CE%B7%CE%BD-%CF%85%CE%B3%CE%B5%CE%AF%CE%B1-%CF%83/", "Podcast");
            AddEvent("GiatiOxi: Τραύμα και Ντροπή", "Επεισόδιο", "Συζήτηση για το ψυχικό τραύμα, τη ντροπή και την αντιμετώπισή τους μέσω ψυχοθεραπείας.", "https://giatioxi.gr/trauma-shame-karageorgiou/", "Podcast");

            comboBoxEventType.Items.Clear();
            comboBoxEventType.Items.AddRange(events.Keys.ToArray());
        }

        private void AddEvent(string name, string time, string description, string link, string type)
        {
            events[type].Add(new VideoEvent
            {
                Name = name,
                Time = time,
                Description = description,
                Link = link,
                Type = type
            });
        }

        private void SetupDataGridViews()
        {
            dataGridViewMenu.ColumnCount = 2;
            dataGridViewMenu.Columns[0].Name = "Προϊόν";
            dataGridViewMenu.Columns[1].Name = "Τιμή";
            dataGridViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewCart.ColumnCount = 2;
            dataGridViewCart.Columns[0].Name = "Προϊόν";
            dataGridViewCart.Columns[1].Name = "Τιμή";
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadMenu()
        {
            menuItems.Add(new VideoMenuItem("Popcorn", 5.00m));
            menuItems.Add(new VideoMenuItem("Αναψυκτικό", 3.00m));
            menuItems.Add(new VideoMenuItem("Nachos", 5.50m));
            menuItems.Add(new VideoMenuItem("Hot Dog", 4.50m));

            foreach (var item in menuItems)
            {
                dataGridViewMenu.Rows.Add(item.Name, item.Price.ToString("C2", euroCulture));
            }
        }

        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            if (comboBoxEventType.SelectedItem != null)
            {
                selectedEventType = comboBoxEventType.SelectedItem.ToString();
                listBoxEvents.Items.AddRange(events[selectedEventType].Select(ev => ev.Name).ToArray());
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItem != null && comboBoxEventType.SelectedItem != null)
            {
                selectedEventName = listBoxEvents.SelectedItem.ToString();
                selectedEventType = comboBoxEventType.SelectedItem.ToString();
                VideoEvent selectedEvent = events[selectedEventType].Find(ev => ev.Name == selectedEventName);

                labelEventInfo.Text = selectedEvent.Name;
                textBoxEventDescription.Text = $"{selectedEvent.Time} {selectedEvent.Description}";

                linkLabelPodcast.Visible = false;
                linkLabelInterview.Visible = false;
                linkLabelConcert.Visible = false;

                if (!string.IsNullOrEmpty(selectedEvent.Link))
                {
                    if (selectedEventType == "Podcast")
                    {
                        linkLabelPodcast.Text = "Άκουσε το Podcast";
                        linkLabelPodcast.Visible = true;
                        linkLabelPodcast.Tag = selectedEvent.Link;
                    }
                    else if (selectedEventType == "Συνεντεύξεις")
                    {
                        linkLabelInterview.Text = "Δες τη συνέντευξη";
                        linkLabelInterview.Visible = true;
                        linkLabelInterview.Tag = selectedEvent.Link;
                    }
                    else if (selectedEventType == "Συναυλίες")
                    {
                        linkLabelConcert.Text = "Δες τη Συναυλία";
                        linkLabelConcert.Visible = true;
                        linkLabelConcert.Tag = selectedEvent.Link;
                    }
                }
            }
        }

        private void linkLabelPodcast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkLabelPodcast.Tag as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        private void linkLabelInterview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkLabelInterview.Tag as string;
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(url);
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewMenu.SelectedRows[0];
                string name = row.Cells["Προϊόν"].Value.ToString();
                decimal price = decimal.Parse(row.Cells["Τιμή"].Value.ToString(), NumberStyles.Currency, euroCulture);

                cartItems.Add(new VideoCartItem(name, price));
                dataGridViewCart.Rows.Add(name, price.ToString("C2", euroCulture));
                UpdateTotal();
            }
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewCart.SelectedRows[0];
                string name = row.Cells["Προϊόν"].Value.ToString();
                decimal price = decimal.Parse(row.Cells["Τιμή"].Value.ToString(), NumberStyles.Currency, euroCulture);

                cartItems.RemoveAll(item => item.Name == name && item.Price == price);
                dataGridViewCart.Rows.RemoveAt(row.Index);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            decimal total = cartItems.Sum(item => item.Price);
            labelTotal.Text = $"Συνολική τιμή: {total.ToString("C2", euroCulture)}";
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if (cartItems.Count > 0)
            {
                decimal total = cartItems.Sum(item => item.Price);
                string items = string.Join(", ", cartItems.Select(item => item.Name));
                string eventInfo = string.IsNullOrEmpty(selectedEventName) ? "" : $"\n\nΕπιλεγμένη εκδήλωση: {selectedEventType} - {selectedEventName}";

                MessageBox.Show($"Πληρωμή επιτυχής!\n\nΠροϊόντα: {items}\nΣύνολο: {total.ToString("C2", euroCulture)}{eventInfo}", "Επιβεβαίωση Πληρωμής", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // save booking to db
                var db = MuseumDatabase.Instance;
                var booking = new Booking
                {
                    EventName = selectedEventName,
                    BookingDate = DateTime.Now,
                    TotalAmount = total,
                    Comments = textBoxComments.Text,
                    Seats = string.Join(", ", cartItems.Select(item => item.Name)) // Assuming seats are represented by menu items
                };
                db.AddBooking(booking, total, textBoxComments.Text, string.Join(", ", cartItems.Select(item => item.Name)));

                lastPurchaseItems = items;
                lastPurchaseTotal = total;
                lastPurchaseEventType = selectedEventType;
                lastPurchaseEventName = selectedEventName;

                buttonGeneratePdf.Enabled = true;

                cartItems.Clear();
                dataGridViewCart.Rows.Clear();
                UpdateTotal();
                textBoxCreditCard.Clear();
                textBoxComments.Clear();
            }
            else
            {
                MessageBox.Show("Το καλάθι είναι άδειο.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastPurchaseItems))
            {
                SaveAsPdf(lastPurchaseItems, lastPurchaseTotal, lastPurchaseEventType, lastPurchaseEventName);
            }
            else
            {
                MessageBox.Show("Δεν υπάρχει πρόσφατη αγορά για την οποία να εκδοθεί απόδειξη.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveAsPdf(string items, decimal total, string eventType, string eventName)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                document.Open();
                document.Add(new Paragraph("Απόδειξη Αγοράς"));
                document.Add(new Paragraph($"Προϊόντα: {items}"));
                document.Add(new Paragraph($"Σύνολο: {total.ToString("C2", euroCulture)}"));
                if (!string.IsNullOrEmpty(eventName))
                {
                    document.Add(new Paragraph($"Επιλεγμένη εκδήλωση: {eventType} - {eventName}"));
                }
                document.Close();

                MessageBox.Show("Η απόδειξη δημιουργήθηκε επιτυχώς!", "Επιτυχία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormVideoScreenings_Load(object sender, EventArgs e)
        {
            LoadMenu();
            UpdateTotal();
        }


        private void linkLabelConcert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = linkLabelConcert.Tag as string;

            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(url);
            }

        }
    }

    public class VideoMenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public VideoMenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class VideoCartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public VideoCartItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class VideoEvent
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public string YouTubeUrl { get; set; }
    }
}
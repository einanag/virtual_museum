using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace App_DJ
{
    public partial class DJ : Form
    {
        private List<Song> songList;
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        private float volume = 1.0f;
        private string currentGenre;
        private Dictionary<string, List<int>> ratings;
        private TimeSpan currentPosition;
        private string currentLyrics;
        private float currentPlaybackSpeed = 1.0f;
        private string currentVoiceEffect = "Normal";

        Timer blinkTimer = new Timer();
        List<Color> lightColors = new List<Color>();
        int currentColorIndex = 0;
        bool lightsOn = true;
        private List<Participant> participants;

        private List<Confetti> confettiList;
        private Timer confettiTimer;
        private const int ConfettiCount = 100;
        private Random random = new Random();

        private DateTime bookingDate;
        private int bookingId;

        public DJ(DateTime selectedDate, int bookingId)
        {
            InitializeComponent();
            this.bookingDate = selectedDate;
            this.bookingId = bookingId;
            labelBookingDate.Text = $"Αριθμός Κράτησης: {bookingId}, Ημερομηνία: {selectedDate.ToShortDateString()}";
            InitializeSongList();
            SetupTrackBars();
            SetupGenreComboBox();
            SetupColorComboBox();
            SetupRatingDictionary();
            SetupPlaybackOrderComboBox();
            SetupVoiceEffects();

            comboBoxColors.SelectedItem = "Γκρι";

            panelLeftLight.BackColor = Color.Gray;
            panelRightLight.BackColor = Color.Gray;
            panelLeftDownLight.BackColor = Color.Gray;
            panelRightDownLight.BackColor = Color.Gray;

            lightColors.Add(Color.Gray);
            lightColors.Add(Color.Red);
            lightColors.Add(Color.Green);
            lightColors.Add(Color.Blue);
            lightColors.Add(Color.Yellow);
            lightColors.Add(Color.Pink);

            timerColor.Interval = 500;
            blinkTimer.Tick += timerColor_Tick;

            participants = new List<Participant>();

            confettiList = new List<Confetti>();
            TimerConfetti = new Timer();
            TimerConfetti.Interval = 50;
            TimerConfetti.Tick += TimerConfetti_Tick;

            labelBookingDate.Text = $"Ημερομηνία Κράτησης: {bookingDate.ToShortDateString()}";
        }

        private void InitializeSongList()
        {
            string audioDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio");


            listBox1.Items.Clear();
            songList = new List<Song>
    {
        new Song("I'm good (Blue)", "David Guetta, Bebe Rexha", Path.Combine(audioDirectory, "David Guetta, Bebe Rexha - I'm good (Blue).mp3"), "I'm good, yeah, I'm feelin' alright\r\n...", 128),
        new Song("Havana", "Camila Cabello", Path.Combine(audioDirectory, "Camila Cabello - Havana ft. Young Thug.mp3"), "Hey\r\nHavana, ooh na-na (ayy)\r\n...", 105),
        new Song("Swan Lake", "Tchaikovsky", Path.Combine(audioDirectory, "Swan Lake Tchaikovsky.mp3"), "Δεν έχει", 74)
    };


            foreach (var song in songList.Distinct())
            {
                listBox1.Items.Add($"{song.Title} - {song.Artist}");
            }
        }

        private void SetupVoiceEffects()
        {
            ComboBox comboBoxVoiceEffects = new ComboBox();
            comboBoxVoiceEffects.Items.AddRange(new string[] { "Normal", "Echo", "Low Volume", "High Volume" });


            comboBoxVoiceEffects.Location = new Point(450, 263);
            comboBoxVoiceEffects.Size = new Size(121, 24);
            comboBoxVoiceEffects.SelectedIndex = 0;
            comboBoxVoiceEffects.SelectedIndexChanged += ComboBoxVoiceEffects_SelectedIndexChanged;
            this.Controls.Add(comboBoxVoiceEffects);

            Label labelVoiceEffects = new Label();
            labelVoiceEffects.AutoSize = true;
            labelVoiceEffects.Location = new Point(450, 240);
            labelVoiceEffects.Text = "Προσθήκη εφέ φωνής";
            this.Controls.Add(labelVoiceEffects);
        }

        private void PlaySong(string filePath)
        {
            StopPlayback();

            if (File.Exists(filePath))
            {
                try
                {
                    waveOut = new WaveOutEvent();
                    audioFileReader = new AudioFileReader(filePath);


                    audioFileReader.Volume = volume;

                    if (currentPosition != TimeSpan.Zero)
                    {
                        audioFileReader.CurrentTime = currentPosition;
                    }

                    waveOut.Init(audioFileReader);
                    waveOut.Play();
                    UpdateTrackInfo(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Σφάλμα κατά την αναπαραγωγή: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Το αρχείο τραγουδιού δεν βρέθηκε.");
            }
        }

        private void StopPlayback()
        {
            if (audioFileReader != null)
            {
                currentPosition = audioFileReader.CurrentTime;

                waveOut?.Stop();
                waveOut?.Dispose();
                audioFileReader?.Dispose();

                waveOut = null;
                audioFileReader = null;
            }
        }

        private void ComboBoxVoiceEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            currentVoiceEffect = comboBox.SelectedItem.ToString();
            ApplyVoiceEffect(currentVoiceEffect);
        }

        private void ApplyVoiceEffect(string effect)
        {
            if (audioFileReader == null) return;

            switch (effect)
            {
                case "Echo":
                    volume = 0.5f;
                    break;
                case "Low Volume":
                    volume = 0.3f;
                    break;
                case "High Volume":
                    volume = 1.0f;
                    break;
                default:
                    volume = 0.7f;
                    break;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Volume = volume;
            }
        }

        private void SetupTrackBars()
        {
            trackBarBPM.Minimum = 60;
            trackBarBPM.Maximum = 180;
            trackBarBPM.Value = 120;
            labelBPM.Text = $"BPM: {trackBarBPM.Value}";
        }

        private void SetupGenreComboBox()
        {

            comboBoxGenres.Items.Clear();
            comboBoxGenres.Items.AddRange(new string[] { "Pop", "Rock", "Classical", "Hip Hop", "Electronic", "Jazz" });
            comboBoxGenres.SelectedIndex = 0;
        }

        private void SetupColorComboBox()
        {
            comboBoxColors.Items.Clear();
            comboBoxColors.Items.AddRange(new string[] { "Γκρι", "Κόκκινο", "Πράσινο", "Μπλε", "Κίτρινο", "Ροζ" });
            comboBoxColors.SelectedIndex = 0;
        }

        private void SetupRatingDictionary()
        {
            ratings = new Dictionary<string, List<int>>();
        }

        private void SetupPlaybackOrderComboBox()
        {

            comboBoxOrder.Items.Clear();
            comboBoxOrder.Items.AddRange(new string[] { "Αργά -> Γρήγορα", "Γρήγορα -> Αργά" });
            comboBoxOrder.SelectedIndex = 0;
        }

        private void UpdateTrackInfo(string filePath)
        {
            var song = songList.Find(s => s.FilePath == filePath);
            if (song != null)
            {
                label1.Text = $"Παίζει το \"{song.Title}\" από {song.Artist}";
                currentLyrics = song.Lyrics;
                richTextBoxLyrics.Text = currentLyrics;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Song selectedSong = songList[listBox1.SelectedIndex];
                PlaySong(selectedSong.FilePath);
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα τραγούδι από τη λίστα.");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void trackBarBPM_Scroll(object sender, EventArgs e)
        {
            int newBPM = trackBarBPM.Value;
            labelBPM.Text = $"BPM: {newBPM}";

            if (listBox1.SelectedIndex != -1)
            {
                Song selectedSong = songList[listBox1.SelectedIndex];
                float speedRatio = (float)newBPM / selectedSong.BPM;
                currentPlaybackSpeed = speedRatio;


                if (audioFileReader != null)
                {
                    var currentTime = audioFileReader.CurrentTime;
                    StopPlayback();
                    PlaySong(selectedSong.FilePath);
                    audioFileReader.CurrentTime = currentTime;
                }
            }
        }

        private void buttonKaraoke_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                richTextBoxLyrics.Text = currentLyrics;
            }
            else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα τραγούδι πρώτα.");
            }
        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGenre = comboBoxGenres.SelectedItem.ToString();
            labelGenre.Text = $"Το είδος της μουσικής άλλαξε σε \"{currentGenre}\"";

            switch (currentGenre)
            {
                case "Classical":
                    trackBarBPM.Minimum = 60;
                    trackBarBPM.Maximum = 120;
                    break;
                case "Rock":
                    trackBarBPM.Minimum = 100;
                    trackBarBPM.Maximum = 160;
                    break;
                case "Hip Hop":
                    trackBarBPM.Minimum = 85;
                    trackBarBPM.Maximum = 115;
                    break;
                default:
                    trackBarBPM.Minimum = 60;
                    trackBarBPM.Maximum = 180;
                    break;
            }

            trackBarBPM.Value = (trackBarBPM.Minimum + trackBarBPM.Maximum) / 2;
            labelBPM.Text = $"BPM: {trackBarBPM.Value}";
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = comboBoxColors.SelectedItem.ToString();
            Color newColor;

            switch (selectedColor)
            {
                case "Κόκκινο":
                    newColor = Color.Red;
                    break;
                case "Πράσινο":
                    newColor = Color.Green;
                    break;
                case "Μπλε":
                    newColor = Color.Blue;
                    break;
                case "Κίτρινο":
                    newColor = Color.Yellow;
                    break;
                case "Ροζ":
                    newColor = Color.Pink;
                    break;
                default:
                    newColor = Color.Gray;
                    break;
            }

            panelLeftLight.BackColor = newColor;
            panelRightLight.BackColor = newColor;
            panelLeftDownLight.BackColor = newColor;
            panelRightDownLight.BackColor = newColor;
            labelColorChange.Text = $"Το χρώμα άλλαξε σε {selectedColor}";
        }

        private void buttonLights_Click(object sender, EventArgs e)
        {
            if (timerColor.Enabled)
            {
                timerColor.Stop();
                buttonLights.Text = "Start Blinking";
            }
            else
            {
                timerColor.Start();
                buttonLights.Text = "Stop Blinking";
            }
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            if (lightsOn)
            {
                panelLeftLight.BackColor = Color.Gray;
                panelRightLight.BackColor = Color.Gray;
                panelLeftDownLight.BackColor = Color.Gray;
                panelRightDownLight.BackColor = Color.Gray;
            }
            else
            {
                ChangeLightColor();
            }

            lightsOn = !lightsOn;
        }

        private void ChangeLightColor()
        {
            Color currentColor = lightColors[currentColorIndex];
            panelLeftLight.BackColor = currentColor;
            panelRightLight.BackColor = currentColor;
            panelLeftDownLight.BackColor = currentColor;
            panelRightDownLight.BackColor = currentColor;

            currentColorIndex = (currentColorIndex + 1) % lightColors.Count;
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Παρακαλώ επιλέξτε ένα τραγούδι για βαθμολόγηση.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxParticipantName.Text))
            {
                MessageBox.Show("Παρακαλώ εισάγετε το όνομα του διαγωνιζόμενου.");
                return;
            }

            Song selectedSong = songList[listBox1.SelectedIndex];
            string participantName = textBoxParticipantName.Text;
            int rating = (int)numericUpDownRating.Value;

            if (!ratings.ContainsKey(selectedSong.Title))
            {
                ratings[selectedSong.Title] = new List<int>();
            }
            ratings[selectedSong.Title].Add(rating);

            participants.Add(new Participant(participantName, selectedSong.Title, rating));

            MessageBox.Show($"Η βαθμολογία {rating}/10 καταχωρήθηκε για το τραγούδι \"{selectedSong.Title}\"");
            UpdateFinalScores();
        }

        private void UpdateFinalScores()
        {
            listBoxFinalScores.Items.Clear();
            var averageScores = new Dictionary<string, double>();

            foreach (var songRatings in ratings)
            {
                double average = songRatings.Value.Average();
                averageScores[songRatings.Key] = average;
                listBoxFinalScores.Items.Add($"{songRatings.Key}: {average:F1}/10");
            }
        }

        private void buttonShowWinner_Click(object sender, EventArgs e)
        {
            if (participants.Count == 0)
            {
                MessageBox.Show("Δεν υπάρχουν ακόμα βαθμολογίες.");
                return;
            }

            var winner = participants.OrderByDescending(p => p.Rating).First();
            MessageBox.Show($"Νικητής: {winner.Name}\nΤραγούδι: {winner.Song}\nΒαθμολογία: {winner.Rating}/10");

            StartConfetti();
        }

        private void StartConfetti()
        {
            confettiList.Clear();
            for (int i = 0; i < ConfettiCount; i++)
            {
                confettiList.Add(new Confetti(random.Next(this.Width), 0, random));
            }
            TimerConfetti.Start();
        }

        private void TimerConfetti_Tick(object sender, EventArgs e)
        {
            bool allConfettiGone = true;
            foreach (var confetti in confettiList)
            {
                confetti.Update();
                if (confetti.Y < this.Height)
                {
                    allConfettiGone = false;
                }
            }

            if (allConfettiGone)
            {
                TimerConfetti.Stop();
                confettiList.Clear();
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var confetti in confettiList)
            {
                confetti.Draw(e.Graphics);
            }
        }

        private void buttonRequestSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRequestSong.Text))
            {
                MessageBox.Show("Παρακαλώ εισάγετε το όνομα του τραγουδιού.");
                return;
            }

            string requestedSong = textBoxRequestSong.Text;
            labelRequest.Text = $"Το τραγούδι \"{requestedSong}\" προστέθηκε στη λίστα αναμονής.";
            textBoxRequestSong.Clear();
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedIndex == 0)
            {
                songList = songList.OrderBy(s => s.BPM).ToList();
            }
            else
            {
                songList = songList.OrderByDescending(s => s.BPM).ToList();
            }

            listBox1.Items.Clear();
            foreach (var song in songList)
            {
                listBox1.Items.Add($"{song.Title} - {song.Artist}");
            }
        }

        //  Classes
        public class Song
        {
            public string Title { get; set; }
            public string Artist { get; set; }
            public string FilePath { get; set; }
            public string Lyrics { get; set; }
            public int BPM { get; set; }

            public Song(string title, string artist, string filePath, string lyrics, int bpm)
            {
                Title = title;
                Artist = artist;
                FilePath = filePath;
                Lyrics = lyrics;
                BPM = bpm;
            }
        }

        public class Participant
        {
            public string Name { get; set; }
            public string Song { get; set; }
            public int Rating { get; set; }

            public Participant(string name, string song, int rating)
            {
                Name = name;
                Song = song;
                Rating = rating;
            }
        }

        public class Confetti
        {
            public float X { get; set; }
            public float Y { get; set; }
            private float speed;
            private float angle;
            private Color color;
            private const int SIZE = 10;

            public Confetti(int x, int y, Random random)
            {
                X = x;
                Y = y;
                speed = random.Next(5, 15);
                angle = random.Next(-30, 30);

                Color[] colors = new Color[]
                {
                    Color.Red, Color.Blue, Color.Green,
                    Color.Yellow, Color.Pink, Color.Purple
                };
                color = colors[random.Next(colors.Length)];
            }

            public void Update()
            {
                Y += speed;
                X += (float)Math.Sin(angle * Math.PI / 180) * 2;
            }

            public void Draw(Graphics g)
            {
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, X, Y, SIZE, SIZE);
                }
            }
        }

        // Backup settings 
        private void BackupSettings(object sender, EventArgs e)
        {
            try
            {
                string backupPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "DJBackup.txt"
                );

                using (StreamWriter writer = new StreamWriter(backupPath))
                {
                    writer.WriteLine($"Booking Date: {bookingDate}");
                    writer.WriteLine($"Booking ID: {bookingId}");
                    writer.WriteLine($"Current Genre: {currentGenre}");
                    writer.WriteLine($"Current BPM: {trackBarBPM.Value}");
                    writer.WriteLine($"Voice Effect: {currentVoiceEffect}");

                    writer.WriteLine("\nSong Ratings:");
                    foreach (var rating in ratings)
                    {
                        writer.WriteLine($"{rating.Key}: {string.Join(", ", rating.Value)}");
                    }

                    writer.WriteLine("\nParticipants:");
                    foreach (var participant in participants)
                    {
                        writer.WriteLine($"{participant.Name} - {participant.Song}: {participant.Rating}");
                    }
                }

                MessageBox.Show("Οι ρυθμίσεις αποθηκεύτηκαν επιτυχώς!", "Backup Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Σφάλμα κατά την αποθήκευση: {ex.Message}", "Backup Error");
            }
        }

        private class labelColorChange
        {
            public static string Text { get; internal set; }
        }
    }

    internal class labelRequest
    {
        public static string Text { get; internal set; }
    }
}
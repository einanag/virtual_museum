using App_DJ;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace virtual_museum_f
{
    public partial class Form1 : Form
    {
        private bool isLoggedIn = false;
        private string loggedInUsername;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
            InitializeVideoPlayer();
        }

        public void ShowWelcomeContent()
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(logoPictureBox);
            contentPanel.Controls.Add(textBox1);
            contentPanel.Controls.Add(axWindowsMediaPlayer1);
        }

        private void InitializeCustomComponents()
        {
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "images", "logo1.png");
            logoPictureBox.Image = Image.FromFile(imagePath);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userguide.Cursor = Cursors.Hand;
        }

        private void InitializeVideoPlayer()
        {
            string videoPath = System.IO.Path.Combine(Application.StartupPath, "videos", "video_scenes.mp4");

            if (System.IO.File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Video file not found: " + videoPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void OpenForm(Form form)
        {
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void btnConcertHall_Click(object sender, EventArgs e)
        {
            OpenForm(new Form7());
        }

        private void btnArtistRooms_Click(object sender, EventArgs e)
        {
            OpenForm(new Form2());
        }

        private void btnCafeteria_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCafeteria());
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                FormEmployeeLogin loginForm = new FormEmployeeLogin();
                loginForm.LoginSuccessful += LoginForm_LoginSuccessful;
                OpenForm(loginForm);
            }
            else
            {
                isLoggedIn = false;
                loggedInUsername = null;
                UpdateLoginState();
                ShowWelcomeContent();
            }
        }

        private void LoginForm_LoginSuccessful(object sender, EventArgs e)
        {
            if (sender is FormEmployeeLogin loginForm)
            {
                isLoggedIn = true;
                loggedInUsername = loginForm.LoggedInUsername;
                UpdateLoginState();
                ShowWelcomeContent();
            }
        }

        private void UpdateLoginState()
        {
            btnEmployeeLogin.Text = isLoggedIn ? "Αποσύνδεση" : "ΕΙΣΟΔΟΣ ΥΠΑΛΛΗΛΩΝ";
            btnEmployeePlatform.Visible = isLoggedIn;
        }

        private void btnVideoScreenings_Click(object sender, EventArgs e)
        {
            OpenForm(new FormVideoScreenings());
        }

        private void btnPrivateScreenings_Click(object sender, EventArgs e)
        {
            OpenForm(new Bookdate());
        }

        private void btnDeviceSimulation_Click(object sender, EventArgs e)
        {
            OpenForm(new FormDeviceSimulation());
        }

        private void btnEmployeePlatform_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                OpenForm(new FormEmployeeDashboard());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            ShowWelcomeContent();
            UpdateLoginState();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {
            btnEmployeeLogin_Click(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowWelcomeContent();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            string aboutText = "Αυτή η εφαρμογή αναπτύχθηκε ως μέρος του μαθήματος ΑΛΛΗΛΕΠΙΔΡΑΣΗ ΑΝΘΡΩΠΟΥ – ΥΠΟΛΟΓΙΣΤΗ\n" +
                               "Εξάμηνο Β\n" +
                               "Μέρος υποχρεωτικού μαθήματος στο Μεταπτυχιακό Πληροφορικής.\n\n" +
                               "Οκτώβριος 2024\n\n" +
                               "© 2024 Όλα τα δικαιώματα διατηρούνται.";

            MessageBox.Show(aboutText, "Σχετικά", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void userguide_Click(object sender, EventArgs e)
        {
            HelpGuideForm helpGuideForm = new HelpGuideForm();
            helpGuideForm.ShowDialog();
        }
    }
}
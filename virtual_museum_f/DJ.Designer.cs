using System.Windows.Forms;
using System.Drawing;
using System;

namespace App_DJ
{
    partial class DJ
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void labelColorChange_Click(object sender, EventArgs e)
        {

            if (comboBoxColors.SelectedItem != null)
            {
                comboBoxColors_SelectedIndexChanged(comboBoxColors, EventArgs.Empty);
            }
        }

        private void DJ_Load(object sender, EventArgs e)
        {

            InitializeSongList();
            SetupTrackBars();
            SetupGenreComboBox();
            SetupColorComboBox();
            SetupRatingDictionary();
            SetupPlaybackOrderComboBox();
            SetupVoiceEffects();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBarBPM = new System.Windows.Forms.TrackBar();
            this.labelBPM = new System.Windows.Forms.Label();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxLyrics = new System.Windows.Forms.RichTextBox();
            this.buttonRate = new System.Windows.Forms.Button();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.buttonShowWinner = new System.Windows.Forms.Button();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonKaraoke = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRequestSong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLeftLight = new System.Windows.Forms.Panel();
            this.panelRightLight = new System.Windows.Forms.Panel();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.buttonLights = new System.Windows.Forms.Button();
            this.panelLeftDownLight = new System.Windows.Forms.Panel();
            this.panelRightDownLight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRequestSong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxParticipantName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxFinalScores = new System.Windows.Forms.ListBox();
            this.TimerConfetti = new System.Windows.Forms.Timer(this.components);
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.labelBookingDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(52, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 180);
            this.listBox1.TabIndex = 0;
            // 
            // trackBarBPM
            // 
            this.trackBarBPM.Location = new System.Drawing.Point(367, 72);
            this.trackBarBPM.Maximum = 200;
            this.trackBarBPM.Minimum = 60;
            this.trackBarBPM.Name = "trackBarBPM";
            this.trackBarBPM.Size = new System.Drawing.Size(181, 56);
            this.trackBarBPM.TabIndex = 1;
            this.trackBarBPM.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBPM.Value = 120;
            this.trackBarBPM.Scroll += new System.EventHandler(this.trackBarBPM_Scroll);
            // 
            // labelBPM
            // 
            this.labelBPM.AutoSize = true;
            this.labelBPM.Location = new System.Drawing.Point(629, 91);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(63, 16);
            this.labelBPM.TabIndex = 2;
            this.labelBPM.Text = "BPM: 120";
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(476, 464);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGenres.TabIndex = 3;
            this.comboBoxGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenres_SelectedIndexChanged);
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Location = new System.Drawing.Point(371, 219);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColors.TabIndex = 4;
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxColors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 34;
            // 
            // richTextBoxLyrics
            // 
            this.richTextBoxLyrics.Location = new System.Drawing.Point(809, 53);
            this.richTextBoxLyrics.Name = "richTextBoxLyrics";
            this.richTextBoxLyrics.ReadOnly = true;
            this.richTextBoxLyrics.Size = new System.Drawing.Size(368, 228);
            this.richTextBoxLyrics.TabIndex = 6;
            this.richTextBoxLyrics.Text = "";
            // 
            // buttonRate
            // 
            this.buttonRate.Location = new System.Drawing.Point(1138, 415);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(143, 43);
            this.buttonRate.TabIndex = 7;
            this.buttonRate.Text = "Υποβολή βαθμολογίας";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(1035, 363);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRating.TabIndex = 8;
            // 
            // buttonShowWinner
            // 
            this.buttonShowWinner.Location = new System.Drawing.Point(1066, 507);
            this.buttonShowWinner.Name = "buttonShowWinner";
            this.buttonShowWinner.Size = new System.Drawing.Size(131, 43);
            this.buttonShowWinner.TabIndex = 9;
            this.buttonShowWinner.Text = "Δείτε τον νικητή";
            this.buttonShowWinner.UseVisualStyleBackColor = true;
            this.buttonShowWinner.Click += new System.EventHandler(this.buttonShowWinner_Click);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(473, 430);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(152, 16);
            this.labelGenre.TabIndex = 10;
            this.labelGenre.Text = "Αλλαγή είδους μουσικής";
            // 
            // buttonKaraoke
            // 
            this.buttonKaraoke.Location = new System.Drawing.Point(266, 382);
            this.buttonKaraoke.Name = "buttonKaraoke";
            this.buttonKaraoke.Size = new System.Drawing.Size(110, 31);
            this.buttonKaraoke.TabIndex = 12;
            this.buttonKaraoke.Text = "Karaoke";
            this.buttonKaraoke.UseVisualStyleBackColor = true;
            this.buttonKaraoke.Click += new System.EventHandler(this.buttonKaraoke_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(22, 382);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(102, 31);
            this.buttonPlay.TabIndex = 13;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(146, 382);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(102, 31);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(68, 22);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(102, 55);
            this.buttonBackup.TabIndex = 15;
            this.buttonBackup.Text = "Backup Settings";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.BackupSettings);
            // 
            // buttonRequestSong
            // 
            this.buttonRequestSong.Location = new System.Drawing.Point(378, 557);
            this.buttonRequestSong.Name = "buttonRequestSong";
            this.buttonRequestSong.Size = new System.Drawing.Size(138, 31);
            this.buttonRequestSong.TabIndex = 16;
            this.buttonRequestSong.Text = "Request Song";
            this.buttonRequestSong.UseVisualStyleBackColor = true;
            this.buttonRequestSong.Click += new System.EventHandler(this.buttonRequestSong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(367, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Αλλαγή του BPM";
            // 
            // panelLeftLight
            // 
            this.panelLeftLight.BackColor = System.Drawing.Color.DarkGray;
            this.panelLeftLight.Location = new System.Drawing.Point(12, 22);
            this.panelLeftLight.Name = "panelLeftLight";
            this.panelLeftLight.Size = new System.Drawing.Size(50, 50);
            this.panelLeftLight.TabIndex = 18;
            // 
            // panelRightLight
            // 
            this.panelRightLight.BackColor = System.Drawing.Color.DarkGray;
            this.panelRightLight.Location = new System.Drawing.Point(1231, 12);
            this.panelRightLight.Name = "panelRightLight";
            this.panelRightLight.Size = new System.Drawing.Size(50, 50);
            this.panelRightLight.TabIndex = 19;
            // 
            // timerColor
            // 
            this.timerColor.Interval = 500;
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // buttonLights
            // 
            this.buttonLights.Location = new System.Drawing.Point(371, 258);
            this.buttonLights.Name = "buttonLights";
            this.buttonLights.Size = new System.Drawing.Size(121, 36);
            this.buttonLights.TabIndex = 20;
            this.buttonLights.Text = "Start Blinking";
            this.buttonLights.UseVisualStyleBackColor = true;
            this.buttonLights.Click += new System.EventHandler(this.buttonLights_Click);
            // 
            // panelLeftDownLight
            // 
            this.panelLeftDownLight.BackColor = System.Drawing.Color.DarkGray;
            this.panelLeftDownLight.Location = new System.Drawing.Point(12, 671);
            this.panelLeftDownLight.Name = "panelLeftDownLight";
            this.panelLeftDownLight.Size = new System.Drawing.Size(50, 50);
            this.panelLeftDownLight.TabIndex = 21;
            // 
            // panelRightDownLight
            // 
            this.panelRightDownLight.BackColor = System.Drawing.Color.DarkGray;
            this.panelRightDownLight.Location = new System.Drawing.Point(1231, 671);
            this.panelRightDownLight.Name = "panelRightDownLight";
            this.panelRightDownLight.Size = new System.Drawing.Size(50, 50);
            this.panelRightDownLight.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(805, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Karaoke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(367, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Άλλαξε το χρώμα";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(18, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ζητήστε ένα τραγούδι από το κοινό";
            // 
            // textBoxRequestSong
            // 
            this.textBoxRequestSong.Location = new System.Drawing.Point(22, 562);
            this.textBoxRequestSong.Name = "textBoxRequestSong";
            this.textBoxRequestSong.Size = new System.Drawing.Size(329, 22);
            this.textBoxRequestSong.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(836, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Όνομα διαγωνιζόμενου:";
            // 
            // textBoxParticipantName
            // 
            this.textBoxParticipantName.Location = new System.Drawing.Point(1035, 323);
            this.textBoxParticipantName.Name = "textBoxParticipantName";
            this.textBoxParticipantName.Size = new System.Drawing.Size(100, 22);
            this.textBoxParticipantName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(910, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Βαθμολογία:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(806, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "ΜΟ Βαθμολογιών";
            // 
            // listBoxFinalScores
            // 
            this.listBoxFinalScores.FormattingEnabled = true;
            this.listBoxFinalScores.ItemHeight = 16;
            this.listBoxFinalScores.Location = new System.Drawing.Point(809, 485);
            this.listBoxFinalScores.Name = "listBoxFinalScores";
            this.listBoxFinalScores.Size = new System.Drawing.Size(230, 100);
            this.listBoxFinalScores.TabIndex = 32;
            // 
            // TimerConfetti
            // 
            this.TimerConfetti.Interval = 50;
            this.TimerConfetti.Tick += new System.EventHandler(this.TimerConfetti_Tick);
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(36, 464);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(212, 24);
            this.comboBoxOrder.TabIndex = 33;
            this.comboBoxOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrder_SelectedIndexChanged);
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Location = new System.Drawing.Point(9, 3);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(143, 16);
            this.labelBookingDate.TabIndex = 0;
            this.labelBookingDate.Text = "Ημερομηνία Κράτησης:";
            // 
            // DJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 733);
            this.Controls.Add(this.labelBookingDate);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.listBoxFinalScores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxParticipantName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRequestSong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelRightDownLight);
            this.Controls.Add(this.panelLeftDownLight);
            this.Controls.Add(this.buttonLights);
            this.Controls.Add(this.panelRightLight);
            this.Controls.Add(this.panelLeftLight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRequestSong);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonKaraoke);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonShowWinner);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.richTextBoxLyrics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.labelBPM);
            this.Controls.Add(this.trackBarBPM);
            this.Controls.Add(this.listBox1);
            this.Name = "DJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DJ Application";
            this.Load += new System.EventHandler(this.DJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBarBPM;
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxLyrics;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.Button buttonShowWinner;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonKaraoke;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRequestSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeftLight;
        private System.Windows.Forms.Panel panelRightLight;
        private System.Windows.Forms.Timer timerColor;
        private System.Windows.Forms.Button buttonLights;
        private System.Windows.Forms.Panel panelLeftDownLight;
        private System.Windows.Forms.Panel panelRightDownLight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRequestSong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxParticipantName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxFinalScores;
        private System.Windows.Forms.Timer TimerConfetti;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label labelBookingDate;
        #endregion
    }
}
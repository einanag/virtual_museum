namespace virtual_museum_f
{
    partial class Form1
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnEmployeePlatform = new System.Windows.Forms.Button();
            this.btnDeviceSimulation = new System.Windows.Forms.Button();
            this.btnPrivateScreenings = new System.Windows.Forms.Button();
            this.btnVideoScreenings = new System.Windows.Forms.Button();
            this.btnCafeteria = new System.Windows.Forms.Button();
            this.btnArtistRooms = new System.Windows.Forms.Button();
            this.btnConcertHall = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.userguide = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userguide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidePanel.Controls.Add(this.btnAbout);
            this.sidePanel.Controls.Add(this.btnEmployeePlatform);
            this.sidePanel.Controls.Add(this.btnDeviceSimulation);
            this.sidePanel.Controls.Add(this.btnPrivateScreenings);
            this.sidePanel.Controls.Add(this.btnVideoScreenings);
            this.sidePanel.Controls.Add(this.btnCafeteria);
            this.sidePanel.Controls.Add(this.btnArtistRooms);
            this.sidePanel.Controls.Add(this.btnConcertHall);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 85);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(421, 986);
            this.sidePanel.TabIndex = 13;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(26, 914);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(294, 59);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "ΣΧΕΤΙΚΑ";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnEmployeePlatform
            // 
            this.btnEmployeePlatform.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEmployeePlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeePlatform.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEmployeePlatform.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeePlatform.Location = new System.Drawing.Point(26, 678);
            this.btnEmployeePlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeePlatform.Name = "btnEmployeePlatform";
            this.btnEmployeePlatform.Size = new System.Drawing.Size(312, 79);
            this.btnEmployeePlatform.TabIndex = 8;
            this.btnEmployeePlatform.Text = "ΠΛΑΤΦΟΡΜΑ ΥΠΑΛΛΗΛΟΥ";
            this.btnEmployeePlatform.UseVisualStyleBackColor = false;
            this.btnEmployeePlatform.Visible = false;
            this.btnEmployeePlatform.Click += new System.EventHandler(this.btnEmployeePlatform_Click);
            // 
            // btnDeviceSimulation
            // 
            this.btnDeviceSimulation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnDeviceSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceSimulation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeviceSimulation.ForeColor = System.Drawing.Color.Black;
            this.btnDeviceSimulation.Location = new System.Drawing.Point(26, 579);
            this.btnDeviceSimulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeviceSimulation.Name = "btnDeviceSimulation";
            this.btnDeviceSimulation.Size = new System.Drawing.Size(312, 79);
            this.btnDeviceSimulation.TabIndex = 7;
            this.btnDeviceSimulation.Text = "ΣΥΣΤΗΜΑ ΠΡΟΣΟΜΟΙΩΣΗΣ ΜΕ ΣΥΣΚΕΥΕΣ";
            this.btnDeviceSimulation.UseVisualStyleBackColor = false;
            this.btnDeviceSimulation.Click += new System.EventHandler(this.btnDeviceSimulation_Click);
            // 
            // btnPrivateScreenings
            // 
            this.btnPrivateScreenings.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnPrivateScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivateScreenings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPrivateScreenings.ForeColor = System.Drawing.Color.Black;
            this.btnPrivateScreenings.Location = new System.Drawing.Point(26, 469);
            this.btnPrivateScreenings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrivateScreenings.Name = "btnPrivateScreenings";
            this.btnPrivateScreenings.Size = new System.Drawing.Size(312, 92);
            this.btnPrivateScreenings.TabIndex = 6;
            this.btnPrivateScreenings.Text = "ΙΔΙΩΤΙΚΟΙ ΧΩΡΟΙ ΠΡΟΒΟΛΗΣ(DJ)";
            this.btnPrivateScreenings.UseVisualStyleBackColor = false;
            this.btnPrivateScreenings.Click += new System.EventHandler(this.btnPrivateScreenings_Click);
            // 
            // btnVideoScreenings
            // 
            this.btnVideoScreenings.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnVideoScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoScreenings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnVideoScreenings.ForeColor = System.Drawing.Color.Black;
            this.btnVideoScreenings.Location = new System.Drawing.Point(26, 351);
            this.btnVideoScreenings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVideoScreenings.Name = "btnVideoScreenings";
            this.btnVideoScreenings.Size = new System.Drawing.Size(312, 98);
            this.btnVideoScreenings.TabIndex = 5;
            this.btnVideoScreenings.Text = "ΑΙΘΟΥΣΕΣ ΠΡΟΒΟΛΗΣ ΒΙΝΤΕΟΣΚΟΠΗΜΕΝΩΝ ΕΚΔΗΛΩΣΕΩΝ";
            this.btnVideoScreenings.UseVisualStyleBackColor = false;
            this.btnVideoScreenings.Click += new System.EventHandler(this.btnVideoScreenings_Click);
            // 
            // btnCafeteria
            // 
            this.btnCafeteria.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCafeteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafeteria.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCafeteria.ForeColor = System.Drawing.Color.Black;
            this.btnCafeteria.Location = new System.Drawing.Point(26, 256);
            this.btnCafeteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCafeteria.Name = "btnCafeteria";
            this.btnCafeteria.Size = new System.Drawing.Size(312, 71);
            this.btnCafeteria.TabIndex = 4;
            this.btnCafeteria.Text = "ΚΑΦΕΤΕΡΙΑ-ΕΣΤΙΑΤΟΡΙΟ";
            this.btnCafeteria.UseVisualStyleBackColor = false;
            this.btnCafeteria.Click += new System.EventHandler(this.btnCafeteria_Click);
            // 
            // btnArtistRooms
            // 
            this.btnArtistRooms.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnArtistRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtistRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnArtistRooms.ForeColor = System.Drawing.Color.Black;
            this.btnArtistRooms.Location = new System.Drawing.Point(26, 164);
            this.btnArtistRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArtistRooms.Name = "btnArtistRooms";
            this.btnArtistRooms.Size = new System.Drawing.Size(312, 71);
            this.btnArtistRooms.TabIndex = 3;
            this.btnArtistRooms.Text = "ΑΙΘΟΥΣΕΣ ΚΑΛΛΙΤΕΧΝΩΝ";
            this.btnArtistRooms.UseVisualStyleBackColor = false;
            this.btnArtistRooms.Click += new System.EventHandler(this.btnArtistRooms_Click);
            // 
            // btnConcertHall
            // 
            this.btnConcertHall.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnConcertHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcertHall.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnConcertHall.ForeColor = System.Drawing.Color.Black;
            this.btnConcertHall.Location = new System.Drawing.Point(26, 62);
            this.btnConcertHall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConcertHall.Name = "btnConcertHall";
            this.btnConcertHall.Size = new System.Drawing.Size(312, 71);
            this.btnConcertHall.TabIndex = 2;
            this.btnConcertHall.Text = "ΑΙΘΟΥΣΑ ΣΥΝΑΥΛΙΩΝ";
            this.btnConcertHall.UseVisualStyleBackColor = false;
            this.btnConcertHall.Click += new System.EventHandler(this.btnConcertHall_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.logoPictureBox);
            this.contentPanel.Controls.Add(this.textBox1);
            this.contentPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(421, 85);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1148, 986);
            this.contentPanel.TabIndex = 14;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(34, 20);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(137, 138);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(416, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 60);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Καλωσήρθατε!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1148, 986);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.topPanel.Controls.Add(this.textBox2);
            this.topPanel.Controls.Add(this.btnEmployeeLogin);
            this.topPanel.Controls.Add(this.userguide);
            this.topPanel.Controls.Add(this.login);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1569, 85);
            this.topPanel.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(80, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 36);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Help Guide";
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeLogin.AutoSize = true;
            this.btnEmployeeLogin.BackColor = System.Drawing.Color.Black;
            this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEmployeeLogin.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(1143, 11);
            this.btnEmployeeLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(290, 59);
            this.btnEmployeeLogin.TabIndex = 4;
            this.btnEmployeeLogin.Text = "ΕΙΣΟΔΟΣ ΥΠΑΛΛΗΛΩΝ";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // userguide
            // 
            this.userguide.BackColor = System.Drawing.Color.NavajoWhite;
            this.userguide.Image = ((System.Drawing.Image)(resources.GetObject("userguide.Image")));
            this.userguide.Location = new System.Drawing.Point(14, 15);
            this.userguide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userguide.Name = "userguide";
            this.userguide.Size = new System.Drawing.Size(60, 59);
            this.userguide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userguide.TabIndex = 11;
            this.userguide.TabStop = false;
            this.userguide.Click += new System.EventHandler(this.userguide_Click);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.login.BackColor = System.Drawing.Color.NavajoWhite;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login.Image = ((System.Drawing.Image)(resources.GetObject("login.Image")));
            this.login.Location = new System.Drawing.Point(1468, 11);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(55, 53);
            this.login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login.TabIndex = 10;
            this.login.TabStop = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1569, 1071);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Virtual Museum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userguide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnConcertHall;
        private System.Windows.Forms.Button btnArtistRooms;
        private System.Windows.Forms.Button btnCafeteria;
        private System.Windows.Forms.Button btnVideoScreenings;
        private System.Windows.Forms.Button btnPrivateScreenings;
        private System.Windows.Forms.Button btnDeviceSimulation;
        private System.Windows.Forms.Button btnEmployeePlatform;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.PictureBox userguide;
        private System.Windows.Forms.PictureBox login;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
using System;

namespace virtual_museum_f
{
    partial class FormDeviceSimulation
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonControlLights = new System.Windows.Forms.Button();
            this.buttonControlHeating = new System.Windows.Forms.Button();
            this.buttonControlSound = new System.Windows.Forms.Button();
            this.buttonControlProjection = new System.Windows.Forms.Button();
            this.labelLights = new System.Windows.Forms.Label();
            this.labelHeating = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.labelProjection = new System.Windows.Forms.Label();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.checkBoxLights = new System.Windows.Forms.CheckBox();
            this.checkBoxProjection = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonControlLights
            // 
            this.buttonControlLights.BackColor = System.Drawing.Color.Linen;
            this.buttonControlLights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonControlLights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonControlLights.Location = new System.Drawing.Point(12, 197);
            this.buttonControlLights.Margin = new System.Windows.Forms.Padding(4);
            this.buttonControlLights.Name = "buttonControlLights";
            this.buttonControlLights.Size = new System.Drawing.Size(208, 37);
            this.buttonControlLights.TabIndex = 0;
            this.buttonControlLights.Text = "Έλεγχος Φώτων";
            this.buttonControlLights.UseVisualStyleBackColor = false;
            this.buttonControlLights.Click += new System.EventHandler(this.buttonControlLights_Click);
            // 
            // buttonControlHeating
            // 
            this.buttonControlHeating.BackColor = System.Drawing.Color.Linen;
            this.buttonControlHeating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonControlHeating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonControlHeating.Location = new System.Drawing.Point(13, 40);
            this.buttonControlHeating.Margin = new System.Windows.Forms.Padding(4);
            this.buttonControlHeating.Name = "buttonControlHeating";
            this.buttonControlHeating.Size = new System.Drawing.Size(208, 37);
            this.buttonControlHeating.TabIndex = 1;
            this.buttonControlHeating.Text = "Έλεγχος Θέρμανσης";
            this.buttonControlHeating.UseVisualStyleBackColor = false;
            this.buttonControlHeating.Click += new System.EventHandler(this.buttonControlHeating_Click);
            // 
            // buttonControlSound
            // 
            this.buttonControlSound.BackColor = System.Drawing.Color.Linen;
            this.buttonControlSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonControlSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonControlSound.Location = new System.Drawing.Point(13, 85);
            this.buttonControlSound.Margin = new System.Windows.Forms.Padding(4);
            this.buttonControlSound.Name = "buttonControlSound";
            this.buttonControlSound.Size = new System.Drawing.Size(208, 37);
            this.buttonControlSound.TabIndex = 2;
            this.buttonControlSound.Text = "Έλεγχος Ήχου";
            this.buttonControlSound.UseVisualStyleBackColor = false;
            this.buttonControlSound.Click += new System.EventHandler(this.buttonControlSound_Click);
            // 
            // buttonControlProjection
            // 
            this.buttonControlProjection.BackColor = System.Drawing.Color.Linen;
            this.buttonControlProjection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonControlProjection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonControlProjection.Location = new System.Drawing.Point(13, 142);
            this.buttonControlProjection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonControlProjection.Name = "buttonControlProjection";
            this.buttonControlProjection.Size = new System.Drawing.Size(208, 37);
            this.buttonControlProjection.TabIndex = 3;
            this.buttonControlProjection.Text = "Έλεγχος Προβολής";
            this.buttonControlProjection.UseVisualStyleBackColor = false;
            this.buttonControlProjection.Click += new System.EventHandler(this.buttonControlProjection_Click);
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelLights.Location = new System.Drawing.Point(229, 197);
            this.labelLights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(51, 20);
            this.labelLights.TabIndex = 4;
            this.labelLights.Text = "Φώτα:";
            // 
            // labelHeating
            // 
            this.labelHeating.AutoSize = true;
            this.labelHeating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHeating.Location = new System.Drawing.Point(229, 48);
            this.labelHeating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeating.Name = "labelHeating";
            this.labelHeating.Size = new System.Drawing.Size(140, 20);
            this.labelHeating.TabIndex = 5;
            this.labelHeating.Text = "Θερμοκρασία: 22°C";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelSound.Location = new System.Drawing.Point(229, 93);
            this.labelSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(95, 20);
            this.labelSound.TabIndex = 6;
            this.labelSound.Text = "Ένταση: 50%";
            // 
            // labelProjection
            // 
            this.labelProjection.AutoSize = true;
            this.labelProjection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelProjection.Location = new System.Drawing.Point(229, 142);
            this.labelProjection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjection.Name = "labelProjection";
            this.labelProjection.Size = new System.Drawing.Size(74, 20);
            this.labelProjection.TabIndex = 7;
            this.labelProjection.Text = "Προβολή:";
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.Location = new System.Drawing.Point(367, 40);
            this.trackBarTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarTemperature.Maximum = 30;
            this.trackBarTemperature.Minimum = 15;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(243, 56);
            this.trackBarTemperature.TabIndex = 12;
            this.trackBarTemperature.Value = 22;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(366, 93);
            this.trackBarVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(243, 56);
            this.trackBarVolume.TabIndex = 13;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.BackColor = System.Drawing.Color.Linen;
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Location = new System.Drawing.Point(13, 246);
            this.listBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(291, 244);
            this.listBoxStatus.TabIndex = 14;
            // 
            // checkBoxLights
            // 
            this.checkBoxLights.AutoSize = true;
            this.checkBoxLights.Location = new System.Drawing.Point(233, 221);
            this.checkBoxLights.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLights.Name = "checkBoxLights";
            this.checkBoxLights.Size = new System.Drawing.Size(18, 17);
            this.checkBoxLights.TabIndex = 10;
            this.checkBoxLights.UseVisualStyleBackColor = true;
            this.checkBoxLights.CheckedChanged += new System.EventHandler(this.checkBoxLights_CheckedChanged);
            // 
            // checkBoxProjection
            // 
            this.checkBoxProjection.AutoSize = true;
            this.checkBoxProjection.Location = new System.Drawing.Point(233, 166);
            this.checkBoxProjection.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxProjection.Name = "checkBoxProjection";
            this.checkBoxProjection.Size = new System.Drawing.Size(18, 17);
            this.checkBoxProjection.TabIndex = 11;
            this.checkBoxProjection.UseVisualStyleBackColor = true;
            // 
            // FormDeviceSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(744, 486);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.checkBoxProjection);
            this.Controls.Add(this.checkBoxLights);
            this.Controls.Add(this.labelProjection);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.labelHeating);
            this.Controls.Add(this.labelLights);
            this.Controls.Add(this.buttonControlProjection);
            this.Controls.Add(this.buttonControlSound);
            this.Controls.Add(this.buttonControlHeating);
            this.Controls.Add(this.buttonControlLights);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDeviceSimulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Προσομοίωση Συσκευών";
            this.Load += new System.EventHandler(this.FormDeviceSimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormDeviceSimulation_Load(object sender, EventArgs e)
        {
            // Initialize your devices or perform any startup tasks here
            InitializeDevices();
            UpdateUIFromDeviceStates();
        }

        #endregion

        private System.Windows.Forms.Button buttonControlLights;
        private System.Windows.Forms.Button buttonControlHeating;
        private System.Windows.Forms.Button buttonControlSound;
        private System.Windows.Forms.Button buttonControlProjection;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.Label labelHeating;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Label labelProjection;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox menuPictureBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.ToolStripMenuItem αρχικήΣελίδαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αίθουσαΣυναυλιώνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αίθουσεςΚαλλιτεχνώνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem καφετερίαΕστιατόριοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem είσοδοςΥπαλλήλωνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αίθουσεςΠροβολήςΒιντεοσκοπημένωνΕκδηλώσεωνToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ιδιωτικοίΧώροιΠροβολήςDJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem προσομοίωσηΑλληλεπίδρασηςΜεΤιςΔιάφορεςΣυσκευέςToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxLights;
        private System.Windows.Forms.CheckBox checkBoxProjection;
    }
}
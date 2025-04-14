namespace virtual_museum_f
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBoxMuseumMap = new System.Windows.Forms.PictureBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuseumMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMuseumMap
            // 
            this.pictureBoxMuseumMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMuseumMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMuseumMap.Image")));
            this.pictureBoxMuseumMap.Location = new System.Drawing.Point(12, 61);
            this.pictureBoxMuseumMap.Name = "pictureBoxMuseumMap";
            this.pictureBoxMuseumMap.Size = new System.Drawing.Size(618, 452);
            this.pictureBoxMuseumMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMuseumMap.TabIndex = 0;
            this.pictureBoxMuseumMap.TabStop = false;
            this.pictureBoxMuseumMap.Click += new System.EventHandler(this.pictureBoxMuseumMap_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelInstructions.Location = new System.Drawing.Point(12, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(473, 25);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Επιλέξτε την έκθεση που θέλετε να παρακολουθήσετε";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 525);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.pictureBoxMuseumMap);
            this.Name = "Form2";
            this.Text = "Εικονικό Μουσείο - Εκθέσεις";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuseumMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMuseumMap;
        private System.Windows.Forms.Label labelInstructions;
    }
} 
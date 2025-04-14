namespace virtual_museum_f
{
    partial class FormEmployeeDashboard
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonManageExhibits = new System.Windows.Forms.Button();
            this.buttonManageScreenings = new System.Windows.Forms.Button();
            this.buttonManageOrders = new System.Windows.Forms.Button();
            this.buttonManageBookings = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.buttonManageExhibits, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonManageScreenings, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonManageOrders, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonManageBookings, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonGenerateReport, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonBack, 0, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(400, 615);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonManageExhibits
            // 
            this.buttonManageExhibits.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonManageExhibits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManageExhibits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonManageExhibits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonManageExhibits.Location = new System.Drawing.Point(3, 3);
            this.buttonManageExhibits.Name = "buttonManageExhibits";
            this.buttonManageExhibits.Size = new System.Drawing.Size(394, 96);
            this.buttonManageExhibits.TabIndex = 0;
            this.buttonManageExhibits.Text = "Διαχείριση Εκθεμάτων";
            this.buttonManageExhibits.UseVisualStyleBackColor = false;
            this.buttonManageExhibits.Click += new System.EventHandler(this.buttonManageExhibits_Click);
            // 
            // buttonManageScreenings
            // 
            this.buttonManageScreenings.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonManageScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManageScreenings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonManageScreenings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonManageScreenings.Location = new System.Drawing.Point(3, 105);
            this.buttonManageScreenings.Name = "buttonManageScreenings";
            this.buttonManageScreenings.Size = new System.Drawing.Size(394, 96);
            this.buttonManageScreenings.TabIndex = 1;
            this.buttonManageScreenings.Text = "Διαχείριση Εκδηλώσεων";
            this.buttonManageScreenings.UseVisualStyleBackColor = false;
            this.buttonManageScreenings.Click += new System.EventHandler(this.buttonManageScreenings_Click);
            // 
            // buttonManageOrders
            // 
            this.buttonManageOrders.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManageOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonManageOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonManageOrders.Location = new System.Drawing.Point(3, 207);
            this.buttonManageOrders.Name = "buttonManageOrders";
            this.buttonManageOrders.Size = new System.Drawing.Size(394, 96);
            this.buttonManageOrders.TabIndex = 2;
            this.buttonManageOrders.Text = "Διαχείριση Παραγγελιών";
            this.buttonManageOrders.UseVisualStyleBackColor = false;
            this.buttonManageOrders.Click += new System.EventHandler(this.buttonManageOrders_Click);
            // 
            // buttonManageBookings
            // 
            this.buttonManageBookings.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonManageBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManageBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonManageBookings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonManageBookings.Location = new System.Drawing.Point(3, 309);
            this.buttonManageBookings.Name = "buttonManageBookings";
            this.buttonManageBookings.Size = new System.Drawing.Size(394, 96);
            this.buttonManageBookings.TabIndex = 3;
            this.buttonManageBookings.Text = "Διαχείριση Κρατήσεων";
            this.buttonManageBookings.UseVisualStyleBackColor = false;
            this.buttonManageBookings.Click += new System.EventHandler(this.buttonManageBookings_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonGenerateReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGenerateReport.Location = new System.Drawing.Point(3, 411);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(394, 96);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Δημιουργία Αναφοράς";
            this.buttonGenerateReport.UseVisualStyleBackColor = false;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(3, 513);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(394, 99);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Επιστροφή";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormEmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 615);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEmployeeDashboard";
            this.Text = "Πίνακας Ελέγχου Υπαλλήλου";
            this.Load += new System.EventHandler(this.FormEmployeeDashboard_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button buttonManageExhibits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonManageScreenings;
        private System.Windows.Forms.Button buttonManageOrders;
        private System.Windows.Forms.Button buttonManageBookings;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonBack;

    }
}
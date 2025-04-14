namespace virtual_museum_f
{
    partial class FormVideoScreenings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoScreenings));
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCreditCard = new System.Windows.Forms.TextBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelEventInfo = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.comboBoxEventType = new System.Windows.Forms.ComboBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkLabelPodcast = new System.Windows.Forms.LinkLabel();
            this.linkLabelInterview = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGeneratePdf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelConcert = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMenu.Location = new System.Drawing.Point(1061, 10);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.Size = new System.Drawing.Size(429, 231);
            this.dataGridViewMenu.TabIndex = 4;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCart.Location = new System.Drawing.Point(1061, 308);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.Size = new System.Drawing.Size(430, 238);
            this.dataGridViewCart.TabIndex = 5;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.Linen;
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddToCart.Location = new System.Drawing.Point(1061, 251);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(243, 46);
            this.buttonAddToCart.TabIndex = 6;
            this.buttonAddToCart.Text = "Προσθήκη στο καλάθι";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.BackColor = System.Drawing.Color.Linen;
            this.buttonRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(1264, 555);
            this.buttonRemoveFromCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(230, 46);
            this.buttonRemoveFromCart.TabIndex = 7;
            this.buttonRemoveFromCart.Text = "Αφαίρεση από το καλάθι";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = false;
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.buttonRemoveFromCart_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1058, 595);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(114, 20);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Συνολική τιμή:";
            // 
            // textBoxCreditCard
            // 
            this.textBoxCreditCard.BackColor = System.Drawing.Color.Linen;
            this.textBoxCreditCard.Location = new System.Drawing.Point(1061, 620);
            this.textBoxCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCreditCard.Name = "textBoxCreditCard";
            this.textBoxCreditCard.Size = new System.Drawing.Size(363, 26);
            this.textBoxCreditCard.TabIndex = 9;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Linen;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayment.Location = new System.Drawing.Point(1252, 658);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(172, 46);
            this.buttonPayment.TabIndex = 10;
            this.buttonPayment.Text = "Πληρωμή";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // textBoxComments
            // 
            this.textBoxComments.BackColor = System.Drawing.Color.Linen;
            this.textBoxComments.Location = new System.Drawing.Point(1068, 745);
            this.textBoxComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(421, 125);
            this.textBoxComments.TabIndex = 11;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(1064, 720);
            this.labelComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(118, 20);
            this.labelComments.TabIndex = 12;
            this.labelComments.Text = "Παρατηρήσεις:";
            // 
            // labelEventInfo
            // 
            this.labelEventInfo.AutoSize = true;
            this.labelEventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventInfo.Location = new System.Drawing.Point(12, 566);
            this.labelEventInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventInfo.Name = "labelEventInfo";
            this.labelEventInfo.Size = new System.Drawing.Size(97, 29);
            this.labelEventInfo.TabIndex = 14;
            this.labelEventInfo.Text = "Τίτλος";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.BackColor = System.Drawing.Color.Linen;
            this.textBoxEventDescription.Location = new System.Drawing.Point(16, 602);
            this.textBoxEventDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.ReadOnly = true;
            this.textBoxEventDescription.Size = new System.Drawing.Size(904, 90);
            this.textBoxEventDescription.TabIndex = 15;
            // 
            // comboBoxEventType
            // 
            this.comboBoxEventType.BackColor = System.Drawing.Color.Linen;
            this.comboBoxEventType.FormattingEnabled = true;
            this.comboBoxEventType.Location = new System.Drawing.Point(16, 179);
            this.comboBoxEventType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEventType.Name = "comboBoxEventType";
            this.comboBoxEventType.Size = new System.Drawing.Size(298, 28);
            this.comboBoxEventType.TabIndex = 16;
            this.comboBoxEventType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventType_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.Color.Linen;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(16, 220);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(465, 324);
            this.listBoxEvents.TabIndex = 17;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // linkLabelPodcast
            // 
            this.linkLabelPodcast.AutoSize = true;
            this.linkLabelPodcast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabelPodcast.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelPodcast.Location = new System.Drawing.Point(18, 716);
            this.linkLabelPodcast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelPodcast.Name = "linkLabelPodcast";
            this.linkLabelPodcast.Size = new System.Drawing.Size(164, 25);
            this.linkLabelPodcast.TabIndex = 18;
            this.linkLabelPodcast.TabStop = true;
            this.linkLabelPodcast.Text = "Άκουσε το Podcast";
            this.linkLabelPodcast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPodcast_LinkClicked);
            // 
            // linkLabelInterview
            // 
            this.linkLabelInterview.AutoSize = true;
            this.linkLabelInterview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabelInterview.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelInterview.Location = new System.Drawing.Point(18, 752);
            this.linkLabelInterview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelInterview.Name = "linkLabelInterview";
            this.linkLabelInterview.Size = new System.Drawing.Size(160, 25);
            this.linkLabelInterview.TabIndex = 19;
            this.linkLabelInterview.TabStop = true;
            this.linkLabelInterview.Text = "Δες τη συνέντευξη";
            this.linkLabelInterview.Visible = false;
            this.linkLabelInterview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInterview_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 76);
            this.label1.TabIndex = 20;
            this.label1.Text = "Οι πιο πρόσφατες συναυλίες, συνεντεύξεις που ξεχώρισαν\r\nκαι αγαπημένα podcast. Συ" +
    "ντονίσου!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Διάλεξε την κατηγορία που σου ταιριάζει:";
            // 
            // buttonGeneratePdf
            // 
            this.buttonGeneratePdf.BackColor = System.Drawing.Color.Linen;
            this.buttonGeneratePdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeneratePdf.Location = new System.Drawing.Point(1061, 658);
            this.buttonGeneratePdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGeneratePdf.Name = "buttonGeneratePdf";
            this.buttonGeneratePdf.Size = new System.Drawing.Size(172, 46);
            this.buttonGeneratePdf.TabIndex = 22;
            this.buttonGeneratePdf.Text = "Απόδειξη πληρωμής";
            this.buttonGeneratePdf.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1330, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelConcert
            // 
            this.linkLabelConcert.AutoSize = true;
            this.linkLabelConcert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabelConcert.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelConcert.Location = new System.Drawing.Point(18, 790);
            this.linkLabelConcert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelConcert.Name = "linkLabelConcert";
            this.linkLabelConcert.Size = new System.Drawing.Size(144, 25);
            this.linkLabelConcert.TabIndex = 24;
            this.linkLabelConcert.TabStop = true;
            this.linkLabelConcert.Text = "Δες τη συναυλία";
            this.linkLabelConcert.Visible = false;
            this.linkLabelConcert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelConcert_LinkClicked);
            // 
            // FormVideoScreenings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1608, 912);
            this.Controls.Add(this.linkLabelConcert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGeneratePdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelInterview);
            this.Controls.Add(this.linkLabelPodcast);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.comboBoxEventType);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.labelEventInfo);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textBoxCreditCard);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.dataGridViewMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVideoScreenings";
            this.Text = "Αίθουσες Προβολής Βίντεο";
            this.Load += new System.EventHandler(this.FormVideoScreenings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonRemoveFromCart;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxCreditCard;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelEventInfo;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.ComboBox comboBoxEventType;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel linkLabelPodcast;
        private System.Windows.Forms.LinkLabel linkLabelInterview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGeneratePdf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelConcert;
    }
}
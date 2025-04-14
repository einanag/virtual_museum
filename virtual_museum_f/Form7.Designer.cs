namespace virtual_museum_f
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxCreditCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choseevent = new System.Windows.Forms.Label();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.seatingMapControl1 = new virtual_museum_f.SeatingMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Linen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(771, 901);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(348, 84);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(766, 868);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Επιλεγμένες θέσεις";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTotal.Location = new System.Drawing.Point(765, 988);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(176, 32);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Συνολική τιμή: ";
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Linen;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonPayment.Location = new System.Drawing.Point(1206, 946);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(201, 44);
            this.buttonPayment.TabIndex = 5;
            this.buttonPayment.Text = "Πληρωμή";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // textBoxCreditCard
            // 
            this.textBoxCreditCard.BackColor = System.Drawing.Color.Linen;
            this.textBoxCreditCard.Location = new System.Drawing.Point(1206, 909);
            this.textBoxCreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCreditCard.Name = "textBoxCreditCard";
            this.textBoxCreditCard.Size = new System.Drawing.Size(246, 26);
            this.textBoxCreditCard.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(1202, 875);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Αριθμός πιστωτικής κάρτας";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // datePickerEvent
            // 
            this.datePickerEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.datePickerEvent.Location = new System.Drawing.Point(429, 864);
            this.datePickerEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePickerEvent.Name = "datePickerEvent";
            this.datePickerEvent.Size = new System.Drawing.Size(313, 31);
            this.datePickerEvent.TabIndex = 11;
            this.datePickerEvent.ValueChanged += new System.EventHandler(this.datePickerEvent_ValueChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(14, 905);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(728, 124);
            this.listBoxEvents.TabIndex = 12;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(1194, 9);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(426, 259);
            this.dataGridViewMenu.TabIndex = 14;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(1194, 336);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowTemplate.Height = 24;
            this.dataGridViewCart.Size = new System.Drawing.Size(426, 246);
            this.dataGridViewCart.TabIndex = 15;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAddToCart.Location = new System.Drawing.Point(1380, 275);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(240, 38);
            this.buttonAddToCart.TabIndex = 17;
            this.buttonAddToCart.Text = "Προσθήκη στο καλάθι";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(1206, 682);
            this.textBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(414, 136);
            this.textBoxComments.TabIndex = 20;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelComments.Location = new System.Drawing.Point(1202, 650);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(133, 25);
            this.labelComments.TabIndex = 21;
            this.labelComments.Text = "Παρατηρήσεις:";
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(1380, 601);
            this.buttonRemoveFromCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(240, 38);
            this.buttonRemoveFromCart.TabIndex = 22;
            this.buttonRemoveFromCart.Text = "Αφαίρεση από το καλάθι";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = true;
            this.buttonRemoveFromCart.Click += new System.EventHandler(this.buttonRemoveFromCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1206, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // choseevent
            // 
            this.choseevent.AutoSize = true;
            this.choseevent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.choseevent.Location = new System.Drawing.Point(14, 868);
            this.choseevent.Name = "choseevent";
            this.choseevent.Size = new System.Drawing.Size(566, 45);
            this.choseevent.TabIndex = 23;
            this.choseevent.Text = "Διάλεξε το event για να κλείσεις θέση:";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AllowUserToResizeColumns = false;
            this.dataGridViewEvents.AllowUserToResizeRows = false;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(19, 59);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.RowHeadersWidth = 10;
            this.dataGridViewEvents.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.RowTemplate.Height = 28;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1051, 779);
            this.dataGridViewEvents.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(833, 45);
            this.label2.TabIndex = 25;
            this.label2.Text = "Κάνε κλικ για να διαλέξεις ένα από τα διαθέσιμα Events:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seatingMapControl1
            // 
            this.seatingMapControl1.Location = new System.Drawing.Point(3, -1);
            this.seatingMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatingMapControl1.Name = "seatingMapControl1";
            this.seatingMapControl1.Size = new System.Drawing.Size(1184, 866);
            this.seatingMapControl1.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1844, 1034);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.choseevent);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.datePickerEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCreditCard);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.seatingMapControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Αίθουσα Συναυλιών";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeatingMapControl seatingMapControl1; 
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxCreditCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker datePickerEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Button buttonRemoveFromCart;
        private System.Windows.Forms.Label choseevent;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Label label2;
    }
}
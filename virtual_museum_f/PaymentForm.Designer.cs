namespace virtual_museum_f
{
    partial class PaymentForm
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
            this.labelCardType = new System.Windows.Forms.Label();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCardHolder = new System.Windows.Forms.Label();
            this.textBoxCardHolder = new System.Windows.Forms.TextBox();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.buttonConfirmPayment = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCardType
            // 
            this.labelCardType.AutoSize = true;
            this.labelCardType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCardType.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCardType.ForeColor = System.Drawing.Color.Black;
            this.labelCardType.Location = new System.Drawing.Point(18, 16);
            this.labelCardType.Name = "labelCardType";
            this.labelCardType.Size = new System.Drawing.Size(103, 17);
            this.labelCardType.TabIndex = 0;
            this.labelCardType.Text = "Τύπος Κάρτας:";
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "AMERICAN EXPRESS",
            "PREPAID MASTERCARD"});
            this.comboBoxCardType.Location = new System.Drawing.Point(142, 13);
            this.comboBoxCardType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCardType.Name = "comboBoxCardType";
            this.comboBoxCardType.Size = new System.Drawing.Size(206, 24);
            this.comboBoxCardType.TabIndex = 1;
            this.comboBoxCardType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCardType_SelectedIndexChanged);
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCardNumber.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCardNumber.ForeColor = System.Drawing.Color.Black;
            this.labelCardNumber.Location = new System.Drawing.Point(18, 48);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(119, 17);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Αριθμός Κάρτας:";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(170, 44);
            this.textBoxCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCardNumber.MaxLength = 16;
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(178, 22);
            this.textBoxCardNumber.TabIndex = 3;
            // 
            // labelCardHolder
            // 
            this.labelCardHolder.AutoSize = true;
            this.labelCardHolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCardHolder.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCardHolder.ForeColor = System.Drawing.Color.Black;
            this.labelCardHolder.Location = new System.Drawing.Point(18, 80);
            this.labelCardHolder.Name = "labelCardHolder";
            this.labelCardHolder.Size = new System.Drawing.Size(115, 17);
            this.labelCardHolder.TabIndex = 4;
            this.labelCardHolder.Text = "Όνομα Κατόχου:";
            // 
            // textBoxCardHolder
            // 
            this.textBoxCardHolder.Location = new System.Drawing.Point(170, 77);
            this.textBoxCardHolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCardHolder.Name = "textBoxCardHolder";
            this.textBoxCardHolder.Size = new System.Drawing.Size(178, 22);
            this.textBoxCardHolder.TabIndex = 5;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelExpirationDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.labelExpirationDate.Location = new System.Drawing.Point(18, 112);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(201, 17);
            this.labelExpirationDate.TabIndex = 6;
            this.labelExpirationDate.Text = "Ημερομηνία Λήξης (MM/YYYY):";
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Location = new System.Drawing.Point(258, 112);
            this.textBoxExpirationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExpirationDate.MaxLength = 7;
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(89, 22);
            this.textBoxExpirationDate.TabIndex = 7;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCVV.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCVV.ForeColor = System.Drawing.Color.Black;
            this.labelCVV.Location = new System.Drawing.Point(18, 144);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(41, 17);
            this.labelCVV.TabIndex = 8;
            this.labelCVV.Text = "CVV:";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(82, 138);
            this.textBoxCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCVV.MaxLength = 3;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(89, 22);
            this.textBoxCVV.TabIndex = 9;
            // 
            // buttonConfirmPayment
            // 
            this.buttonConfirmPayment.BackColor = System.Drawing.Color.Wheat;
            this.buttonConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmPayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonConfirmPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmPayment.Location = new System.Drawing.Point(21, 174);
            this.buttonConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfirmPayment.Name = "buttonConfirmPayment";
            this.buttonConfirmPayment.Size = new System.Drawing.Size(133, 33);
            this.buttonConfirmPayment.TabIndex = 10;
            this.buttonConfirmPayment.Text = "Επιβεβαίωση Πληρωμής";
            this.buttonConfirmPayment.UseVisualStyleBackColor = false;
            this.buttonConfirmPayment.Click += new System.EventHandler(this.ConfirmPayment);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(359, 216);
            this.Controls.Add(this.labelCardType);
            this.Controls.Add(this.comboBoxCardType);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelCardHolder);
            this.Controls.Add(this.textBoxCardHolder);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.textBoxExpirationDate);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.buttonConfirmPayment);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelCardType;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCardHolder;
        private System.Windows.Forms.TextBox textBoxCardHolder;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Button buttonConfirmPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
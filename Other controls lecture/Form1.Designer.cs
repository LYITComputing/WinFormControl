namespace Other_controls_lecture
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.grpCCInfo = new System.Windows.Forms.GroupBox();
            this.checkDefaultMethod = new System.Windows.Forms.CheckBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpCCInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCash);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Checked = true;
            this.rdoCash.Location = new System.Drawing.Point(8, 19);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(49, 17);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.radBillCust_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(124, 19);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(76, 17);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // grpCCInfo
            // 
            this.grpCCInfo.Controls.Add(this.checkDefaultMethod);
            this.grpCCInfo.Controls.Add(this.cmbYears);
            this.grpCCInfo.Controls.Add(this.cmbMonths);
            this.grpCCInfo.Controls.Add(this.label3);
            this.grpCCInfo.Controls.Add(this.txtCreditCard);
            this.grpCCInfo.Controls.Add(this.label2);
            this.grpCCInfo.Controls.Add(this.lstCards);
            this.grpCCInfo.Controls.Add(this.label1);
            this.grpCCInfo.Enabled = false;
            this.grpCCInfo.Location = new System.Drawing.Point(24, 89);
            this.grpCCInfo.Name = "grpCCInfo";
            this.grpCCInfo.Size = new System.Drawing.Size(357, 234);
            this.grpCCInfo.TabIndex = 1;
            this.grpCCInfo.TabStop = false;
            this.grpCCInfo.Text = "Credit card information";
            // 
            // checkDefaultMethod
            // 
            this.checkDefaultMethod.AutoSize = true;
            this.checkDefaultMethod.Location = new System.Drawing.Point(10, 199);
            this.checkDefaultMethod.Name = "checkDefaultMethod";
            this.checkDefaultMethod.Size = new System.Drawing.Size(156, 17);
            this.checkDefaultMethod.TabIndex = 7;
            this.checkDefaultMethod.Text = "Set as default blling method";
            this.checkDefaultMethod.UseVisualStyleBackColor = true;
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(236, 147);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(96, 21);
            this.cmbYears.TabIndex = 6;
            this.cmbYears.Text = "Select year";
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonths.Location = new System.Drawing.Point(106, 147);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(96, 21);
            this.cmbMonths.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiration date:";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(106, 110);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(226, 20);
            this.txtCreditCard.TabIndex = 3;
            this.txtCreditCard.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreditCard_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card number:";
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Americian Express"});
            this.lstCards.Location = new System.Drawing.Point(106, 37);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(226, 56);
            this.lstCards.TabIndex = 1;
            this.lstCards.SelectedIndexChanged += new System.EventHandler(this.lstCards_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit card type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount due: ";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(309, 328);
            this.txtAmountDue.MaxLength = 10;
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(72, 20);
            this.txtAmountDue.TabIndex = 3;
            this.txtAmountDue.TabStop = false;
            this.txtAmountDue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmountDue_KeyDown);
            this.txtAmountDue.Leave += new System.EventHandler(this.txtAmountDue_Leave);
            this.txtAmountDue.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountDue_Validating);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(309, 367);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(72, 20);
            this.txtDiscount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cash discount (10%):";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Enabled = false;
            this.txtTotalDue.Location = new System.Drawing.Point(309, 403);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(72, 20);
            this.txtTotalDue.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Payment method:";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Location = new System.Drawing.Point(22, 356);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(30, 13);
            this.lblPayMethod.TabIndex = 9;
            this.lblPayMethod.Text = "cash";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 445);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalDue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpCCInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPayment";
            this.Text = "Payment details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCCInfo.ResumeLayout(false);
            this.grpCCInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.GroupBox grpCCInfo;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.CheckBox checkDefaultMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPayMethod;
    }
}


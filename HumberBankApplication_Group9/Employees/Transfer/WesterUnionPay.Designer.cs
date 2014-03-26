namespace HumberBankApplication_Group9.Employees.Transfer
{
    partial class WesterUnionPay
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
            this.btnPayTo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNewBalances = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrasactionFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSendingAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExchangeRates = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPickupCurrency = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayTo
            // 
            this.btnPayTo.Location = new System.Drawing.Point(390, 383);
            this.btnPayTo.Name = "btnPayTo";
            this.btnPayTo.Size = new System.Drawing.Size(81, 25);
            this.btnPayTo.TabIndex = 18;
            this.btnPayTo.Text = "&Pay To";
            this.btnPayTo.UseVisualStyleBackColor = true;
            this.btnPayTo.Click += new System.EventHandler(this.btnPayTo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Balance :";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(628, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 25);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNewBalances
            // 
            this.txtNewBalances.Location = new System.Drawing.Point(490, 430);
            this.txtNewBalances.Name = "txtNewBalances";
            this.txtNewBalances.ReadOnly = true;
            this.txtNewBalances.Size = new System.Drawing.Size(126, 23);
            this.txtNewBalances.TabIndex = 21;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.txtTotalPay);
            this.grpLogin.Controls.Add(this.label8);
            this.grpLogin.Controls.Add(this.txtTotal);
            this.grpLogin.Controls.Add(this.label9);
            this.grpLogin.Controls.Add(this.txtTrasactionFee);
            this.grpLogin.Controls.Add(this.label7);
            this.grpLogin.Controls.Add(this.txtSendingAmount);
            this.grpLogin.Controls.Add(this.label6);
            this.grpLogin.Controls.Add(this.txtExchangeRates);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.btnCalculateTotal);
            this.grpLogin.Controls.Add(this.txtAmount);
            this.grpLogin.Controls.Add(this.textBox2);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.txtPickupCurrency);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.cmbCountry);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.lblReference);
            this.grpLogin.Controls.Add(this.pictureBox1);
            this.grpLogin.Controls.Add(this.btnPayTo);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.btnClose);
            this.grpLogin.Controls.Add(this.txtNewBalances);
            this.grpLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLogin.Location = new System.Drawing.Point(16, 17);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(719, 459);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Western Union Money Transfer";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(407, 328);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(154, 23);
            this.txtTotalPay.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Payable :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(407, 299);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 23);
            this.txtTotal.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Receivable :";
            // 
            // txtTrasactionFee
            // 
            this.txtTrasactionFee.Location = new System.Drawing.Point(407, 270);
            this.txtTrasactionFee.Name = "txtTrasactionFee";
            this.txtTrasactionFee.ReadOnly = true;
            this.txtTrasactionFee.Size = new System.Drawing.Size(154, 23);
            this.txtTrasactionFee.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Transaction Fee :";
            // 
            // txtSendingAmount
            // 
            this.txtSendingAmount.Location = new System.Drawing.Point(407, 241);
            this.txtSendingAmount.Name = "txtSendingAmount";
            this.txtSendingAmount.ReadOnly = true;
            this.txtSendingAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSendingAmount.Size = new System.Drawing.Size(154, 23);
            this.txtSendingAmount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sending Amount :";
            // 
            // txtExchangeRates
            // 
            this.txtExchangeRates.Location = new System.Drawing.Point(407, 212);
            this.txtExchangeRates.Name = "txtExchangeRates";
            this.txtExchangeRates.ReadOnly = true;
            this.txtExchangeRates.Size = new System.Drawing.Size(244, 23);
            this.txtExchangeRates.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exchange Rates :";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(333, 162);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(162, 25);
            this.btnCalculateTotal.TabIndex = 7;
            this.btnCalculateTotal.Text = "Calculate &Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(356, 123);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(154, 23);
            this.txtAmount.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(49, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "CAD$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount :";
            // 
            // txtPickupCurrency
            // 
            this.txtPickupCurrency.Location = new System.Drawing.Point(301, 90);
            this.txtPickupCurrency.Name = "txtPickupCurrency";
            this.txtPickupCurrency.ReadOnly = true;
            this.txtPickupCurrency.Size = new System.Drawing.Size(154, 23);
            this.txtPickupCurrency.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pickup Currency :";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "---Select---",
            "United States",
            "England UK",
            "Australia",
            "India",
            "China",
            "Pakistan",
            "Dubai",
            "South Africa",
            "Russia",
            "Nigeria",
            "Mumbai"});
            this.cmbCountry.Location = new System.Drawing.Point(301, 56);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(213, 24);
            this.cmbCountry.TabIndex = 1;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paying Country :";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(20, 428);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(217, 16);
            this.lblReference.TabIndex = 19;
            this.lblReference.Text = "Your transfer reference is :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HumberBankApplication_Group9.Properties.Resources.western_union;
            this.pictureBox1.Location = new System.Drawing.Point(23, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // WesterUnionPay
            // 
            this.AcceptButton = this.btnCalculateTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(750, 493);
            this.Controls.Add(this.grpLogin);
            this.Name = "WesterUnionPay";
            this.Text = "WesterUnionPay";
            this.Load += new System.EventHandler(this.WesterUnionPay_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPayTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNewBalances;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPickupCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTrasactionFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSendingAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExchangeRates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label label8;
    }
}
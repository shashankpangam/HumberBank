namespace HumberBankApplication_Group9.Employees.Transfer
{
    partial class InterBankTransfer
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
            this.lblReference = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNewBalance = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.pctTo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerified = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMothersName = new System.Windows.Forms.TextBox();
            this.txtAccHolderName = new System.Windows.Forms.TextBox();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(147, 400);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(217, 16);
            this.lblReference.TabIndex = 20;
            this.lblReference.Text = "Your transfer reference is: ";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(293, 342);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(111, 25);
            this.btnTransfer.TabIndex = 19;
            this.btnTransfer.Text = "&Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(307, 280);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(114, 23);
            this.txtAmount.TabIndex = 18;
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "---Select---",
            "TD Canada Trust",
            "Scotia Bank",
            "RBC Royal Bank",
            "Bank of Nova Scotia",
            "Bank of Montral",
            "National Bank of Canada",
            "HSBC Bank",
            "Canadian Western Bank"});
            this.cmbTo.Location = new System.Drawing.Point(306, 223);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(213, 24);
            this.cmbTo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transfer To (Bank) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "New Balance:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(628, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 25);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNewBalance
            // 
            this.txtNewBalance.Location = new System.Drawing.Point(490, 430);
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.ReadOnly = true;
            this.txtNewBalance.Size = new System.Drawing.Size(126, 23);
            this.txtNewBalance.TabIndex = 22;
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.pctTo);
            this.grpLogin.Controls.Add(this.pictureBox1);
            this.grpLogin.Controls.Add(this.btnVerified);
            this.grpLogin.Controls.Add(this.label7);
            this.grpLogin.Controls.Add(this.label6);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtPincode);
            this.grpLogin.Controls.Add(this.txtDate);
            this.grpLogin.Controls.Add(this.txtMothersName);
            this.grpLogin.Controls.Add(this.txtAccHolderName);
            this.grpLogin.Controls.Add(this.txtAcc2);
            this.grpLogin.Controls.Add(this.btnCheck);
            this.grpLogin.Controls.Add(this.txtAcc1);
            this.grpLogin.Controls.Add(this.label11);
            this.grpLogin.Controls.Add(this.txtAccNo);
            this.grpLogin.Controls.Add(this.lblReference);
            this.grpLogin.Controls.Add(this.btnTransfer);
            this.grpLogin.Controls.Add(this.label9);
            this.grpLogin.Controls.Add(this.txtAmount);
            this.grpLogin.Controls.Add(this.cmbTo);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.btnClose);
            this.grpLogin.Controls.Add(this.txtNewBalance);
            this.grpLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLogin.Location = new System.Drawing.Point(16, 15);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(719, 459);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "InterBank Transfer";
            // 
            // pctTo
            // 
            this.pctTo.Location = new System.Drawing.Point(553, 212);
            this.pctTo.Name = "pctTo";
            this.pctTo.Size = new System.Drawing.Size(125, 120);
            this.pctTo.TabIndex = 64;
            this.pctTo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HumberBankApplication_Group9.Properties.Resources.humber_logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerified
            // 
            this.btnVerified.Location = new System.Drawing.Point(332, 163);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(111, 25);
            this.btnVerified.TabIndex = 12;
            this.btnVerified.Text = "&Verified";
            this.btnVerified.UseVisualStyleBackColor = true;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "PinCode :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mothers Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Account Holders Name :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number :";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(528, 120);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.ReadOnly = true;
            this.txtPincode.Size = new System.Drawing.Size(126, 23);
            this.txtPincode.TabIndex = 11;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(528, 91);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(126, 23);
            this.txtDate.TabIndex = 7;
            // 
            // txtMothersName
            // 
            this.txtMothersName.Location = new System.Drawing.Point(250, 120);
            this.txtMothersName.Name = "txtMothersName";
            this.txtMothersName.ReadOnly = true;
            this.txtMothersName.Size = new System.Drawing.Size(126, 23);
            this.txtMothersName.TabIndex = 9;
            // 
            // txtAccHolderName
            // 
            this.txtAccHolderName.Location = new System.Drawing.Point(249, 91);
            this.txtAccHolderName.Name = "txtAccHolderName";
            this.txtAccHolderName.ReadOnly = true;
            this.txtAccHolderName.Size = new System.Drawing.Size(126, 23);
            this.txtAccHolderName.TabIndex = 5;
            // 
            // txtAcc2
            // 
            this.txtAcc2.Location = new System.Drawing.Point(293, 50);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(126, 23);
            this.txtAcc2.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(437, 50);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 25);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "&Check Validity";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAcc1
            // 
            this.txtAcc1.Location = new System.Drawing.Point(213, 50);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.ReadOnly = true;
            this.txtAcc1.Size = new System.Drawing.Size(74, 23);
            this.txtAcc1.TabIndex = 1;
            this.txtAcc1.Text = "101012";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Account Number :";
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(307, 253);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.ReadOnly = true;
            this.txtAccNo.Size = new System.Drawing.Size(174, 23);
            this.txtAccNo.TabIndex = 16;
            // 
            // InterBankTransfer
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(750, 489);
            this.Controls.Add(this.grpLogin);
            this.Name = "InterBankTransfer";
            this.Text = "InterBankTransfer";
            this.Load += new System.EventHandler(this.InterBankTransfer_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNewBalance;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMothersName;
        private System.Windows.Forms.TextBox txtAccHolderName;
        private System.Windows.Forms.TextBox txtAcc2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.PictureBox pctTo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
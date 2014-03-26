﻿namespace HumberBankApplication_Group9.Employees.Request
{
    partial class NewCard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbInfoType = new System.Windows.Forms.ComboBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerified = new System.Windows.Forms.Button();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtAccHolderName = new System.Windows.Forms.TextBox();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            this.grpCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(588, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip Code :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "MothersName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Holder\'s Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number :";
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.grpCard);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnClose);
            this.grpLogin.Controls.Add(this.label6);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.btnVerified);
            this.grpLogin.Controls.Add(this.txtPincode);
            this.grpLogin.Controls.Add(this.txtDOB);
            this.grpLogin.Controls.Add(this.txtMotherName);
            this.grpLogin.Controls.Add(this.txtAccHolderName);
            this.grpLogin.Controls.Add(this.txtAcc2);
            this.grpLogin.Controls.Add(this.btnCheck);
            this.grpLogin.Controls.Add(this.txtAcc1);
            this.grpLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLogin.Location = new System.Drawing.Point(33, 47);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(678, 406);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "New Card";
            // 
            // grpCard
            // 
            this.grpCard.Controls.Add(this.label7);
            this.grpCard.Controls.Add(this.cmbInfoType);
            this.grpCard.Controls.Add(this.btnGetInfo);
            this.grpCard.Location = new System.Drawing.Point(61, 235);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(484, 138);
            this.grpCard.TabIndex = 13;
            this.grpCard.TabStop = false;
            this.grpCard.Text = "New Card";
            this.grpCard.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Card Type";
            // 
            // cmbInfoType
            // 
            this.cmbInfoType.FormattingEnabled = true;
            this.cmbInfoType.Items.AddRange(new object[] {
            "---Select---",
            "Debit Card",
            "Credit Card (Visa)",
            "Credit Card (Master Card)",
            "Credit Card (American Express)",
            "Foreign Travel Card"});
            this.cmbInfoType.Location = new System.Drawing.Point(211, 38);
            this.cmbInfoType.Name = "cmbInfoType";
            this.cmbInfoType.Size = new System.Drawing.Size(161, 24);
            this.cmbInfoType.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(188, 77);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(93, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "&Request";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please Verify to Apply for a Card";
            // 
            // btnVerified
            // 
            this.btnVerified.Location = new System.Drawing.Point(267, 188);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(111, 25);
            this.btnVerified.TabIndex = 12;
            this.btnVerified.Text = "&Verified";
            this.btnVerified.UseVisualStyleBackColor = true;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(360, 159);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.ReadOnly = true;
            this.txtPincode.Size = new System.Drawing.Size(126, 23);
            this.txtPincode.TabIndex = 11;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(360, 130);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(126, 23);
            this.txtDOB.TabIndex = 9;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(360, 101);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.ReadOnly = true;
            this.txtMotherName.Size = new System.Drawing.Size(126, 23);
            this.txtMotherName.TabIndex = 7;
            // 
            // txtAccHolderName
            // 
            this.txtAccHolderName.Location = new System.Drawing.Point(360, 72);
            this.txtAccHolderName.Name = "txtAccHolderName";
            this.txtAccHolderName.ReadOnly = true;
            this.txtAccHolderName.Size = new System.Drawing.Size(126, 23);
            this.txtAccHolderName.TabIndex = 5;
            // 
            // txtAcc2
            // 
            this.txtAcc2.Location = new System.Drawing.Point(302, 36);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(126, 23);
            this.txtAcc2.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(434, 34);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(139, 25);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "&Check Validity";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAcc1
            // 
            this.txtAcc1.Location = new System.Drawing.Point(222, 36);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.ReadOnly = true;
            this.txtAcc1.Size = new System.Drawing.Size(74, 23);
            this.txtAcc1.TabIndex = 1;
            this.txtAcc1.Text = "101012";
            // 
            // NewCard
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.grpLogin);
            this.Name = "NewCard";
            this.Text = "New Card";
            this.Load += new System.EventHandler(this.NewCard_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtAccHolderName;
        private System.Windows.Forms.TextBox txtAcc2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbInfoType;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label label1;
    }
}
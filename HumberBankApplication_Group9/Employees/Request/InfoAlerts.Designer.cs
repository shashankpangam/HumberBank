namespace HumberBankApplication_Group9.Employees.Request
{
    partial class InfoAlerts
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
            this.btnVerified = new System.Windows.Forms.Button();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtAccHolderName = new System.Windows.Forms.TextBox();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.cmbInfoType = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerified
            // 
            this.btnVerified.Location = new System.Drawing.Point(267, 188);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(111, 25);
            this.btnVerified.TabIndex = 49;
            this.btnVerified.Text = "Verified";
            this.btnVerified.UseVisualStyleBackColor = true;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(360, 159);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.ReadOnly = true;
            this.txtPincode.Size = new System.Drawing.Size(126, 23);
            this.txtPincode.TabIndex = 43;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(360, 130);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(126, 23);
            this.txtDOB.TabIndex = 42;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(360, 101);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.ReadOnly = true;
            this.txtMotherName.Size = new System.Drawing.Size(126, 23);
            this.txtMotherName.TabIndex = 41;
            // 
            // txtAccHolderName
            // 
            this.txtAccHolderName.Location = new System.Drawing.Point(360, 72);
            this.txtAccHolderName.Name = "txtAccHolderName";
            this.txtAccHolderName.ReadOnly = true;
            this.txtAccHolderName.Size = new System.Drawing.Size(126, 23);
            this.txtAccHolderName.TabIndex = 40;
            // 
            // txtAcc2
            // 
            this.txtAcc2.Location = new System.Drawing.Point(302, 36);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(126, 23);
            this.txtAcc2.TabIndex = 35;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(434, 34);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 25);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Check Validity";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAcc1
            // 
            this.txtAcc1.Location = new System.Drawing.Point(222, 36);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.ReadOnly = true;
            this.txtAcc1.Size = new System.Drawing.Size(74, 23);
            this.txtAcc1.TabIndex = 32;
            this.txtAcc1.Text = "101012";
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.grpInfo);
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
            this.grpLogin.Location = new System.Drawing.Point(39, 51);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(674, 427);
            this.grpLogin.TabIndex = 8;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Info Alerts Request";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.lblInfoType);
            this.grpInfo.Controls.Add(this.cmbInfoType);
            this.grpInfo.Controls.Add(this.txtInfo);
            this.grpInfo.Controls.Add(this.btnGetInfo);
            this.grpInfo.Location = new System.Drawing.Point(96, 233);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(488, 171);
            this.grpInfo.TabIndex = 62;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info Alerts";
            this.grpInfo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "InfoAlert Type";
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Location = new System.Drawing.Point(119, 75);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(92, 16);
            this.lblInfoType.TabIndex = 63;
            this.lblInfoType.Text = "lblInfoType";
            // 
            // cmbInfoType
            // 
            this.cmbInfoType.FormattingEnabled = true;
            this.cmbInfoType.Items.AddRange(new object[] {
            "---Select---",
            "Mobile",
            "E-Mail"});
            this.cmbInfoType.Location = new System.Drawing.Point(244, 43);
            this.cmbInfoType.Name = "cmbInfoType";
            this.cmbInfoType.Size = new System.Drawing.Size(121, 24);
            this.cmbInfoType.TabIndex = 62;
            this.cmbInfoType.SelectedIndexChanged += new System.EventHandler(this.cmbInfoType_SelectedIndexChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(244, 72);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(126, 23);
            this.txtInfo.TabIndex = 61;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(187, 104);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(93, 23);
            this.btnGetInfo.TabIndex = 60;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Please Verify to get InfoAlerts";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(590, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Pincode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "MothersName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Account Holder\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Account Number:";
            // 
            // InfoAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 481);
            this.Controls.Add(this.grpLogin);
            this.Name = "InfoAlerts";
            this.Text = "InfoAlerts";
            this.Load += new System.EventHandler(this.InfoAlerts_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtAccHolderName;
        private System.Windows.Forms.TextBox txtAcc2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.ComboBox cmbInfoType;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGetInfo;
    }
}
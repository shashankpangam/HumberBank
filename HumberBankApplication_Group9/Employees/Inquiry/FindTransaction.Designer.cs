namespace HumberBankApplication_Group9.Employees.Inquiry
{
    partial class FindTransaction
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.grpFind = new System.Windows.Forms.GroupBox();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDate2 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtDate1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtAmt2 = new System.Windows.Forms.TextBox();
            this.txtAmt1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtAccHolderName = new System.Windows.Forms.TextBox();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.grpFind);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnSearch);
            this.grpLogin.Controls.Add(this.btnVerify);
            this.grpLogin.Controls.Add(this.label7);
            this.grpLogin.Controls.Add(this.label6);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtPincode);
            this.grpLogin.Controls.Add(this.txtDOB);
            this.grpLogin.Controls.Add(this.txtMotherName);
            this.grpLogin.Controls.Add(this.txtAccHolderName);
            this.grpLogin.Controls.Add(this.txtAcc2);
            this.grpLogin.Controls.Add(this.btnCheck);
            this.grpLogin.Controls.Add(this.txtAcc1);
            this.grpLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLogin.Location = new System.Drawing.Point(19, 18);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(719, 459);
            this.grpLogin.TabIndex = 23;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Find Transaction";
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.cmbAccType);
            this.grpFind.Controls.Add(this.label8);
            this.grpFind.Controls.Add(this.txtDate2);
            this.grpFind.Controls.Add(this.textBox10);
            this.grpFind.Controls.Add(this.txtDate1);
            this.grpFind.Controls.Add(this.label3);
            this.grpFind.Controls.Add(this.textBox9);
            this.grpFind.Controls.Add(this.txtAmt2);
            this.grpFind.Controls.Add(this.txtAmt1);
            this.grpFind.Controls.Add(this.label9);
            this.grpFind.Location = new System.Drawing.Point(35, 219);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(632, 185);
            this.grpFind.TabIndex = 51;
            this.grpFind.TabStop = false;
            this.grpFind.Text = "Find";
            this.grpFind.Visible = false;
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "---Select---",
            "Cheqing",
            "Savings",
            "Any"});
            this.cmbAccType.Location = new System.Drawing.Point(293, 23);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(205, 24);
            this.cmbAccType.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Select Account Type:";
            // 
            // txtDate2
            // 
            this.txtDate2.Location = new System.Drawing.Point(297, 147);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(198, 23);
            this.txtDate2.TabIndex = 59;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(385, 118);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(21, 23);
            this.textBox10.TabIndex = 58;
            this.textBox10.Text = "to";
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(300, 89);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(198, 23);
            this.txtDate1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Date Range:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(358, 57);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(21, 23);
            this.textBox9.TabIndex = 55;
            this.textBox9.Text = "to";
            // 
            // txtAmt2
            // 
            this.txtAmt2.Location = new System.Drawing.Point(385, 57);
            this.txtAmt2.Name = "txtAmt2";
            this.txtAmt2.Size = new System.Drawing.Size(66, 23);
            this.txtAmt2.TabIndex = 54;
            // 
            // txtAmt1
            // 
            this.txtAmt1.Location = new System.Drawing.Point(293, 57);
            this.txtAmt1.Name = "txtAmt1";
            this.txtAmt1.Size = new System.Drawing.Size(59, 23);
            this.txtAmt1.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Amount Range:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Please Verify to Find a Transaction";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(602, 428);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 25);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(295, 179);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(111, 25);
            this.btnVerify.TabIndex = 39;
            this.btnVerify.Text = "Verified";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "PinCode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mothers Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Account Holders Name:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Account Number:";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(492, 143);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.ReadOnly = true;
            this.txtPincode.Size = new System.Drawing.Size(126, 23);
            this.txtPincode.TabIndex = 28;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(492, 114);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(126, 23);
            this.txtDOB.TabIndex = 27;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(214, 141);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.ReadOnly = true;
            this.txtMotherName.Size = new System.Drawing.Size(126, 23);
            this.txtMotherName.TabIndex = 26;
            // 
            // txtAccHolderName
            // 
            this.txtAccHolderName.Location = new System.Drawing.Point(213, 112);
            this.txtAccHolderName.Name = "txtAccHolderName";
            this.txtAccHolderName.ReadOnly = true;
            this.txtAccHolderName.Size = new System.Drawing.Size(126, 23);
            this.txtAccHolderName.TabIndex = 25;
            // 
            // txtAcc2
            // 
            this.txtAcc2.Location = new System.Drawing.Point(255, 41);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(126, 23);
            this.txtAcc2.TabIndex = 20;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(399, 41);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 25);
            this.btnCheck.TabIndex = 17;
            this.btnCheck.Text = "Check Validity";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtAcc1
            // 
            this.txtAcc1.Location = new System.Drawing.Point(175, 41);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.ReadOnly = true;
            this.txtAcc1.Size = new System.Drawing.Size(74, 23);
            this.txtAcc1.TabIndex = 15;
            this.txtAcc1.Text = "101012";
            // 
            // FindTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 494);
            this.Controls.Add(this.grpLogin);
            this.Name = "FindTransaction";
            this.Text = "FindTransaction";
            this.Load += new System.EventHandler(this.FindTransaction_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtAccHolderName;
        private System.Windows.Forms.TextBox txtAcc2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpFind;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDate2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DateTimePicker txtDate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtAmt2;
        private System.Windows.Forms.TextBox txtAmt1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
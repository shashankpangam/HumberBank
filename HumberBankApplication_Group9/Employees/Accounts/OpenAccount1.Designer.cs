namespace HumberBankApplication_Group9
{
    partial class OpenAccount1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAutoGenerate = new System.Windows.Forms.Button();
            this.txtAcc2 = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.TextBox();
            this.txtAcc1 = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpLogin.Controls.Add(this.button1);
            this.grpLogin.Controls.Add(this.btnNext);
            this.grpLogin.Controls.Add(this.label5);
            this.grpLogin.Controls.Add(this.btnAutoGenerate);
            this.grpLogin.Controls.Add(this.txtAcc2);
            this.grpLogin.Controls.Add(this.btnValid);
            this.grpLogin.Controls.Add(this.txtAcc1);
            this.grpLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpLogin.Location = new System.Drawing.Point(28, 50);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(675, 370);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Step 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Check Validity";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.Location = new System.Drawing.Point(605, 337);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 27);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Generate Account Number :";
            // 
            // btnAutoGenerate
            // 
            this.btnAutoGenerate.Location = new System.Drawing.Point(265, 143);
            this.btnAutoGenerate.Name = "btnAutoGenerate";
            this.btnAutoGenerate.Size = new System.Drawing.Size(130, 25);
            this.btnAutoGenerate.TabIndex = 3;
            this.btnAutoGenerate.Text = "Auto-&Generate";
            this.btnAutoGenerate.UseVisualStyleBackColor = true;
            this.btnAutoGenerate.Click += new System.EventHandler(this.btnAutoGenerate_Click);
            // 
            // txtAcc2
            // 
            this.txtAcc2.Location = new System.Drawing.Point(372, 97);
            this.txtAcc2.Name = "txtAcc2";
            this.txtAcc2.Size = new System.Drawing.Size(126, 23);
            this.txtAcc2.TabIndex = 2;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(344, 193);
            this.btnValid.Name = "btnValid";
            this.btnValid.ReadOnly = true;
            this.btnValid.Size = new System.Drawing.Size(98, 23);
            this.btnValid.TabIndex = 5;
            // 
            // txtAcc1
            // 
            this.txtAcc1.Location = new System.Drawing.Point(302, 97);
            this.txtAcc1.Name = "txtAcc1";
            this.txtAcc1.ReadOnly = true;
            this.txtAcc1.Size = new System.Drawing.Size(65, 23);
            this.txtAcc1.TabIndex = 1;
            this.txtAcc1.Text = "101012";
            // 
            // OpenAccount1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.grpLogin);
            this.Name = "OpenAccount1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpenAccount_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtAcc2;
        private System.Windows.Forms.TextBox btnValid;
        private System.Windows.Forms.TextBox txtAcc1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAutoGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;

    }
}
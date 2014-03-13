namespace HumberBankApplication_Group9
{
    partial class BranchManager
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
            this.grpAddEmployee = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblBranchManager = new System.Windows.Forms.Label();
            this.pctBranchManager = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.grpAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddEmployee
            // 
            this.grpAddEmployee.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpAddEmployee.Controls.Add(this.btnLogout);
            this.grpAddEmployee.Controls.Add(this.txtEmployee);
            this.grpAddEmployee.Controls.Add(this.lblMemberType);
            this.grpAddEmployee.Controls.Add(this.txtPassword);
            this.grpAddEmployee.Controls.Add(this.txtUName);
            this.grpAddEmployee.Controls.Add(this.btnAddEmployee);
            this.grpAddEmployee.Controls.Add(this.lblUName);
            this.grpAddEmployee.Controls.Add(this.lblPassword);
            this.grpAddEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddEmployee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpAddEmployee.Location = new System.Drawing.Point(252, 203);
            this.grpAddEmployee.Name = "grpAddEmployee";
            this.grpAddEmployee.Size = new System.Drawing.Size(430, 196);
            this.grpAddEmployee.TabIndex = 11;
            this.grpAddEmployee.TabStop = false;
            this.grpAddEmployee.Text = "Add an Employee";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(251, 147);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 33);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(191, 105);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(159, 27);
            this.txtEmployee.TabIndex = 9;
            this.txtEmployee.Text = "Employee";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(47, 105);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(129, 20);
            this.lblMemberType.TabIndex = 8;
            this.lblMemberType.Text = "Member Type";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(191, 37);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(159, 27);
            this.txtUName.TabIndex = 6;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(81, 147);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(164, 33);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(61, 40);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(101, 20);
            this.lblUName.TabIndex = 3;
            this.lblUName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(63, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(249, 438);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(52, 16);
            this.lblWarning.TabIndex = 13;
            this.lblWarning.Text = "label2";
            this.lblWarning.Visible = false;
            // 
            // lblBranchManager
            // 
            this.lblBranchManager.AutoSize = true;
            this.lblBranchManager.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchManager.ForeColor = System.Drawing.Color.DimGray;
            this.lblBranchManager.Location = new System.Drawing.Point(249, 165);
            this.lblBranchManager.Name = "lblBranchManager";
            this.lblBranchManager.Size = new System.Drawing.Size(206, 16);
            this.lblBranchManager.TabIndex = 12;
            this.lblBranchManager.Text = "Welcome, Branch Manager";
            // 
            // pctBranchManager
            // 
            this.pctBranchManager.Image = global::HumberBankApplication_Group9.Properties.Resources.admin;
            this.pctBranchManager.Location = new System.Drawing.Point(4, 22);
            this.pctBranchManager.Name = "pctBranchManager";
            this.pctBranchManager.Size = new System.Drawing.Size(162, 180);
            this.pctBranchManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBranchManager.TabIndex = 10;
            this.pctBranchManager.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HumberBankApplication_Group9.Properties.Resources.humber_logo;
            this.pctLogo.Location = new System.Drawing.Point(383, 22);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(373, 77);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 9;
            this.pctLogo.TabStop = false;
            // 
            // BranchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 477);
            this.Controls.Add(this.grpAddEmployee);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblBranchManager);
            this.Controls.Add(this.pctBranchManager);
            this.Controls.Add(this.pctLogo);
            this.Name = "BranchManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchAdmin";
            this.Load += new System.EventHandler(this.BranchAdmin_Load);
            this.grpAddEmployee.ResumeLayout(false);
            this.grpAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBranchManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddEmployee;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblBranchManager;
        private System.Windows.Forms.PictureBox pctBranchManager;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnLogout;
    }
}
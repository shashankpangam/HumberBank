namespace HumberBankApplication_Group9
{
    partial class Admin
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
            this.pctAdmin = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.grpAddBranchManager = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtBranchManager = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpAddBranchManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctAdmin
            // 
            this.pctAdmin.Image = global::HumberBankApplication_Group9.Properties.Resources.masteradmin;
            this.pctAdmin.Location = new System.Drawing.Point(632, 12);
            this.pctAdmin.Name = "pctAdmin";
            this.pctAdmin.Size = new System.Drawing.Size(162, 180);
            this.pctAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdmin.TabIndex = 3;
            this.pctAdmin.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HumberBankApplication_Group9.Properties.Resources.humber_logo;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(373, 77);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // grpAddBranchManager
            // 
            this.grpAddBranchManager.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpAddBranchManager.Controls.Add(this.btnLogout);
            this.grpAddBranchManager.Controls.Add(this.txtBranchManager);
            this.grpAddBranchManager.Controls.Add(this.lblMemberType);
            this.grpAddBranchManager.Controls.Add(this.txtPassword);
            this.grpAddBranchManager.Controls.Add(this.txtUName);
            this.grpAddBranchManager.Controls.Add(this.btnAdd);
            this.grpAddBranchManager.Controls.Add(this.lblUName);
            this.grpAddBranchManager.Controls.Add(this.lblPassword);
            this.grpAddBranchManager.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddBranchManager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpAddBranchManager.Location = new System.Drawing.Point(62, 160);
            this.grpAddBranchManager.Name = "grpAddBranchManager";
            this.grpAddBranchManager.Size = new System.Drawing.Size(430, 196);
            this.grpAddBranchManager.TabIndex = 6;
            this.grpAddBranchManager.TabStop = false;
            this.grpAddBranchManager.Text = "Add Branch Manager";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(276, 148);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 33);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBranchManager
            // 
            this.txtBranchManager.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchManager.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBranchManager.Location = new System.Drawing.Point(191, 106);
            this.txtBranchManager.Name = "txtBranchManager";
            this.txtBranchManager.ReadOnly = true;
            this.txtBranchManager.Size = new System.Drawing.Size(159, 27);
            this.txtBranchManager.TabIndex = 9;
            this.txtBranchManager.Text = "Branch Manager";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Branch Manager";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(59, 122);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 16);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(59, 395);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(52, 16);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "label2";
            this.lblWarning.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(819, 480);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.grpAddBranchManager);
            this.Controls.Add(this.pctAdmin);
            this.Controls.Add(this.pctLogo);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterAdmin";
            this.Load += new System.EventHandler(this.MasterAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpAddBranchManager.ResumeLayout(false);
            this.grpAddBranchManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctAdmin;
        private System.Windows.Forms.GroupBox grpAddBranchManager;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtBranchManager;
        private System.Windows.Forms.Button btnLogout;
    }
}
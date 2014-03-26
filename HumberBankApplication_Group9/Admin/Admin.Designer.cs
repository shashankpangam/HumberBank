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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtBranchManager = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnAddBranchManager = new System.Windows.Forms.Button();
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
            this.pctAdmin.Location = new System.Drawing.Point(955, 154);
            this.pctAdmin.Name = "pctAdmin";
            this.pctAdmin.Size = new System.Drawing.Size(162, 180);
            this.pctAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdmin.TabIndex = 3;
            this.pctAdmin.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::HumberBankApplication_Group9.Properties.Resources.humber_logo;
            this.pctLogo.Location = new System.Drawing.Point(335, 154);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(373, 77);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // grpAddBranchManager
            // 
            this.grpAddBranchManager.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpAddBranchManager.Controls.Add(this.txtName);
            this.grpAddBranchManager.Controls.Add(this.label1);
            this.grpAddBranchManager.Controls.Add(this.btnLogout);
            this.grpAddBranchManager.Controls.Add(this.txtBranchManager);
            this.grpAddBranchManager.Controls.Add(this.lblMemberType);
            this.grpAddBranchManager.Controls.Add(this.txtPassword);
            this.grpAddBranchManager.Controls.Add(this.txtUName);
            this.grpAddBranchManager.Controls.Add(this.btnAddBranchManager);
            this.grpAddBranchManager.Controls.Add(this.lblUName);
            this.grpAddBranchManager.Controls.Add(this.lblPassword);
            this.grpAddBranchManager.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddBranchManager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpAddBranchManager.Location = new System.Drawing.Point(385, 302);
            this.grpAddBranchManager.Name = "grpAddBranchManager";
            this.grpAddBranchManager.Size = new System.Drawing.Size(483, 267);
            this.grpAddBranchManager.TabIndex = 6;
            this.grpAddBranchManager.TabStop = false;
            this.grpAddBranchManager.Text = "Add Branch Manager";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 27);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(294, 196);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 33);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBranchManager
            // 
            this.txtBranchManager.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchManager.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBranchManager.Location = new System.Drawing.Point(209, 154);
            this.txtBranchManager.Name = "txtBranchManager";
            this.txtBranchManager.ReadOnly = true;
            this.txtBranchManager.Size = new System.Drawing.Size(159, 27);
            this.txtBranchManager.TabIndex = 9;
            this.txtBranchManager.Text = "Branch Manager";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Location = new System.Drawing.Point(65, 157);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(144, 20);
            this.lblMemberType.TabIndex = 8;
            this.lblMemberType.Text = "Member Type :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(209, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(209, 85);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(159, 27);
            this.txtUName.TabIndex = 6;
            // 
            // btnAddBranchManager
            // 
            this.btnAddBranchManager.Location = new System.Drawing.Point(53, 196);
            this.btnAddBranchManager.Name = "btnAddBranchManager";
            this.btnAddBranchManager.Size = new System.Drawing.Size(226, 33);
            this.btnAddBranchManager.TabIndex = 5;
            this.btnAddBranchManager.Text = "Add &Branch Manager";
            this.btnAddBranchManager.UseVisualStyleBackColor = true;
            this.btnAddBranchManager.Click += new System.EventHandler(this.btnAddBranchManager_Click);
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(93, 88);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(116, 20);
            this.lblUName.TabIndex = 3;
            this.lblUName.Text = "UserName :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(100, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(382, 264);
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
            this.lblWarning.Location = new System.Drawing.Point(382, 572);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(52, 16);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "label2";
            this.lblWarning.Visible = false;
            // 
            // Admin
            // 
            this.AcceptButton = this.btnAddBranchManager;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(1248, 529);
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
        private System.Windows.Forms.Button btnAddBranchManager;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtBranchManager;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == null || txtUName.Text == "")
            {
                MessageBox.Show("Please Enter UserName");
            }
            else if (txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                if (txtUName.Text == "admin" && txtPassword.Text == "admin")
                {
                    Admin madmin = new Admin();
                    this.Hide();
                    madmin.Show();
                }
                else if (txtUName.Text == "branch" && txtPassword.Text == "branch")
                {
                    BranchManager badmin = new BranchManager();
                    this.Hide();
                    badmin.Show();
                }
                else if (txtUName.Text == "emp" && txtPassword.Text == "emp")
                {
                    MainBank obj = new MainBank();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    lblWarning.Visible = true;
                    lblWarning.Text = "Invalid Login Credentials.";
                    txtUName.BackColor = Color.Red;
                    txtPassword.BackColor = Color.Red;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

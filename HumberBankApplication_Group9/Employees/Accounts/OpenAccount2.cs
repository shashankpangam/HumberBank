using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Accounts
{
    public partial class OpenAccount2 : Form
    {
        public OpenAccount2()
        {
            InitializeComponent();
        }

        private void OpenAccount3_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="" || txtFirstName.Text==null)
            {
                MessageBox.Show("Please Enter First Name ");
            }
            else if (txtLastName.Text == "" || txtLastName.Text == null)
            {
                MessageBox.Show("Please Enter Last Name ");
            }
            else if (txtMotherName.Text == "" || txtMotherName.Text == null)
            {
                MessageBox.Show("Please Enter Mothers Name");
            }
            else if(cmbGender.SelectedIndex<0)
            {
                MessageBox.Show("Please select Gender. ");
            }
                else if (txtMobileNum.Text == "" || txtMobileNum.Text == null)
            {
                MessageBox.Show("Please Enter MobileNumber ");
            }
                else if (txtEMail.Text == "" || txtEMail.Text == null)
            {
                MessageBox.Show("Please Enter Email ID ");
            }
                else if (txtAddress.Text == "" || txtAddress.Text == null)
            {
                MessageBox.Show("Please Enter Address ");
            }
                else if (txtPinCode.Text == "" || txtPinCode.Text == null)
            {
                MessageBox.Show("Please Enter Pincode ");
            }
            else
            {
                Employees.Accounts.OpenAccount3 obj = new Employees.Accounts.OpenAccount3();
                obj.MdiParent = this.MdiParent;
                this.Hide();
                obj.Show();
            }
        }
    }
}

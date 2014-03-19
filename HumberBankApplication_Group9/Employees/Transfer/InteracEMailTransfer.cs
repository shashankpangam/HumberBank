using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Transfer
{
    public partial class InteracEMailTransfer : Form
    {
        public InteracEMailTransfer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InteracEMailTransfer_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAcc2.Text == null || txtAcc2.Text == "" || Convert.ToInt32(txtAcc2.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Account Number.");
            }
            else
            {

            }

        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            txtEMail.ReadOnly = false;
            txtSecQue.ReadOnly = false;
            txtSecAns.ReadOnly = false;
            txtAmount.ReadOnly = false;
            txtMessage.ReadOnly = false;

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (txtEMail.Text == "" || txtEMail.Text == null)
            {
                MessageBox.Show("Please Enter the EMail");
            }
            if (txtSecQue.Text == "" || txtSecQue.Text == null)
            {
                MessageBox.Show("Please Enter the Security Question");
            }

            else if (txtSecAns.Text == "" || txtSecAns.Text == null)
            {
                MessageBox.Show("Please Enter the Security Answer");
            }
            else if (txtAmount.Text == "" || txtAmount.Text == null)
            {
                MessageBox.Show("Please Enter the Amount");
            }
            else
            {
                MessageBox.Show("Amount Transferred.");
                Random r = new Random();
                int n = r.Next();
                lblReference.Text += n.ToString();
                txtNewBalance.Text = "new bal";
            }
        }
    }
}

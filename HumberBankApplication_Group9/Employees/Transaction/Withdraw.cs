using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Transaction
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            txtAmount.ReadOnly = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amout Withdrawn.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnVerified_Click_1(object sender, EventArgs e)
        {
            grpWithdraw.Visible = true;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == null || txtAmount.Text == null )
            {
                MessageBox.Show("Please Enter a Valid Amount");
            }
            else
            {
                MessageBox.Show("Amount Withdrawn");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Inquiry
{
    public partial class TransactionInfo : Form
    {
        public TransactionInfo()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionInfo_Load(object sender, EventArgs e)
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

        private void btnVerify_Click(object sender, EventArgs e)
        {
            grpTransaction.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTransactionNumber.Text == "" || txtTransactionNumber.Text == null)
            {
                MessageBox.Show("Please Enter Transaction Number");
            }
            else
            { 
            
            }
        }
    }
}

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
    public partial class FindTransaction : Form
    {
        public FindTransaction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (cmbAccType.SelectedIndex <= 0)
            //{
            //    MessageBox.Show("Please Select Account");
            //}
            //else
            if (txtAmt1.Text == null || txtAmt2.Text == null || txtAmt1.Text == "" || txtAmt2.Text == "")
            {
                MessageBox.Show("Please Enter Search Values.");
            }
            else
            {
                FindTransactionResult obj = new FindTransactionResult();
                obj.MdiParent = this.MdiParent;
                this.Hide();
                obj.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FindTransaction_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            grpFind.Visible = true;
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
    }
}

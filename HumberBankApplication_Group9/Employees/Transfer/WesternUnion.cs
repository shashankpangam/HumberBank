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
    public partial class WesternUnion : Form
    {
        public WesternUnion()
        {
            InitializeComponent();
        }

        

        private void WesternUnion_Load(object sender, EventArgs e)
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
            txtRecName.ReadOnly = false;
            txtSecQue.ReadOnly = false;
            txtAnswer.ReadOnly = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtRecName.Text=="" || txtRecName==null)
            {
                MessageBox.Show("Please Enter Recipiant Name");
            }
            else if(txtSecQue.Text=="" || txtSecQue.Text==null)
            {
                MessageBox.Show("Please Enter Security Question");
            }
            else if(txtAnswer.Text=="" || txtAnswer.Text==null)
            {
                MessageBox.Show("Please Enter Security Answer");
            }
            else
            {
                WesterUnionPay obj = new WesterUnionPay();
                this.Hide();
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
        }
    }
}

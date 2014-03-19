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
    public partial class OpenAccount1 : Form
    {
        public OpenAccount1()
        {
            InitializeComponent();
        }

        private void OpenAccount_Load(object sender, EventArgs e)
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
            if (txtAcc2.Text == null || txtAcc2.Text == "" || Convert.ToInt32(txtAcc2.Text) <= 0)
            {
                MessageBox.Show("Please Enter Valid Account Number.");
            }
            else
            {
                Employees.Accounts.OpenAccount2 obj = new Employees.Accounts.OpenAccount2();
                obj.MdiParent = this.MdiParent;
                this.Hide();
                obj.Show();
            }
           
        }

        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next();
            txtAcc2.Text = n.ToString();
        }
    }
}

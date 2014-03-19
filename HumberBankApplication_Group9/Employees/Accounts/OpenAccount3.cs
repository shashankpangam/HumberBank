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
    public partial class OpenAccount3 : Form
    {
        public OpenAccount3()
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

            // center
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenAccount2 obj = new OpenAccount2();
            obj.MdiParent = this.MdiParent;
            this.Hide();
            obj.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Opened.");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

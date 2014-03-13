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
            this.Width = 800;
            this.Height = 520;

            // for border style
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;

            // center
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employees.Accounts.OpenAccount3 obj = new Employees.Accounts.OpenAccount3();
            obj.MdiParent = this.MdiParent;
            this.Hide();
            obj.Show();
        }

        
    }
}

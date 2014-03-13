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
            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

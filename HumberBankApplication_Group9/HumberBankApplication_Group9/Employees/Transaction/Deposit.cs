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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void btnVerified_Click(object sender, EventArgs e)
        {
            txtAmount.ReadOnly = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amout Deposited.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

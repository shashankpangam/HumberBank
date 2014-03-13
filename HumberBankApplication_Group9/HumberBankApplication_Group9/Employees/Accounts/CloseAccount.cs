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
    public partial class CloseAccount : Form
    {
        public CloseAccount()
        {
            InitializeComponent();
        }

        private void CloseAccount_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 800;
            this.Height = 520;
         
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Closed.");
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

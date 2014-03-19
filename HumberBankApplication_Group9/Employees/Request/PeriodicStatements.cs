using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Request
{
    public partial class PeriodicStatements : Form
    {
        public PeriodicStatements()
        {
            InitializeComponent();
        }

        private void PeriodicStatements_Load(object sender, EventArgs e)
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
            grpStatements.Visible = true;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (cmbInfoType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select the Periodic Type.");
            }
            else
            {
                MessageBox.Show("Youwill now receive statements every  " + cmbInfoType.Text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

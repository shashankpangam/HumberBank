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
    public partial class InfoAlerts : Form
    {
        public InfoAlerts()
        {
            InitializeComponent();
        }

       
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InfoAlerts_Load(object sender, EventArgs e)
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
            grpInfo.Visible = true;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (cmbInfoType.SelectedIndex <= 0)
            {
                MessageBox.Show("Please Select a InfoAlert Type for Alerts");
            }
            else if (txtInfo.Text == null || txtInfo.Text == "")
            {
                MessageBox.Show("Please Enter InfoType Details");
            }
            else
            {
                MessageBox.Show("Tou will now receive updates on your."+ lblInfoType.Text);
            }
        }

        private void cmbInfoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInfoType.SelectedIndex == 1)
            {
                lblInfoType.Text = "Mobile Number:";
            }
            else if (cmbInfoType.SelectedIndex == 2)
            {
                lblInfoType.Text = "E-Mail ID:";
            }
            else
            {
                MessageBox.Show("Please Select the InfoAlerts Type.");
                cmbInfoType.BackColor = Color.Tomato;
            }
        }
    }
}

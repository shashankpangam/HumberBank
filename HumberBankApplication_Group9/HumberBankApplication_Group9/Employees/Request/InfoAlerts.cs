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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

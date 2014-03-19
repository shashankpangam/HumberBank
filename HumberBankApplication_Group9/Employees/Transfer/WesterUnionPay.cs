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
    public partial class WesterUnionPay : Form
    {
        public WesterUnionPay()
        {
            InitializeComponent();
        }

        private void WesterUnionPay_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text==null || txtAmount.Text=="")
            {
                MessageBox.Show("Please Enter Amount to be Sent.");
            }
            else
            {
                //sequence

            //1     United States
            //2     England UK
            //3     Australia
            //4     India
            //5     China
            //6     Pakistan
            //7     Dubai
            //8     South Africa
            //9     Russia
            //10    Nigeria
            //11    Mumbai

            if (cmbCountry.SelectedIndex <= 0)
            {
                MessageBox.Show("Please Select a Country");
            }
            else if (cmbCountry.SelectedIndex == 1)
            {
                txtPickupCurrency.Text = "USD";
                txtExchangeRates.Text = "0.90486854984651";
            }
            else if (cmbCountry.SelectedIndex == 2)
            {
                txtPickupCurrency.Text = "POUNDS";
                txtExchangeRates.Text = "0.5496846513651";
            }
            else if (cmbCountry.SelectedIndex == 3)
            {
                txtPickupCurrency.Text = "AUD";
                txtExchangeRates.Text = "1.0686546984654968";
            }
            else if (cmbCountry.SelectedIndex == 4)
            {
                txtPickupCurrency.Text = "INR";
                txtExchangeRates.Text = "55.2769854965469";
            }
            else if (cmbCountry.SelectedIndex == 5)
            {
                txtPickupCurrency.Text = "CHINASE YUAN";
                txtExchangeRates.Text = "5.59984651654";
            }
            else if (cmbCountry.SelectedIndex == 6)
            {
                txtPickupCurrency.Text = "PAK RUPEE";
                txtExchangeRates.Text = "89.769865196849";
            }
            else if (cmbCountry.SelectedIndex == 7)
            {
                txtPickupCurrency.Text = "DIRHAM";
                txtExchangeRates.Text = "3.32685498498";
            }
            else if (cmbCountry.SelectedIndex == 8)
            {
                txtPickupCurrency.Text = "ZAR";
                txtExchangeRates.Text = "9.7165196846516";
            }
            else if (cmbCountry.SelectedIndex == 9)
            {
                txtPickupCurrency.Text = "RUSSIA RUBLE";
                txtExchangeRates.Text = "32849654965196581";
            }
            else if (cmbCountry.SelectedIndex == 10)
            {
                txtPickupCurrency.Text = "NIGERIAN NIARA";
                txtExchangeRates.Text = "148.9365196849684";
            }
            else if (cmbCountry.SelectedIndex == 11)
            {
                txtPickupCurrency.Text = "VADAPAV mere bhai";
                txtExchangeRates.Text = "15";
            }

            txtSendingAmount.Text = txtAmount.Text;
            txtTrasactionFee.Text = "CAD $ 18.60";

            double a = Convert.ToDouble(txtExchangeRates.Text);
            double b = Convert.ToDouble(txtAmount.Text);
            double c = 18.60;
            double ans = (a * b) + c;

            txtTotalPay.Text = (Convert.ToDouble(txtAmount.Text) + 18.60).ToString();
            txtTotal.Text = ans.ToString();
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sequence

            //1     United States
            //2     England UK
            //3     Australia
            //4     India
            //5     China
            //6     Pakistan
            //7     Dubai
            //8     South Africa
            //9     Russia
            //10    Nigeria
            //11    Mumbai

            if (cmbCountry.SelectedIndex <= 0)
            {
                MessageBox.Show("Please Select a Country");
            }
            else if (cmbCountry.SelectedIndex == 1)
            {
                txtPickupCurrency.Text = "USD";
            }
            else if (cmbCountry.SelectedIndex == 2)
            {
                txtPickupCurrency.Text = "POUNDS";
            }
            else if (cmbCountry.SelectedIndex == 3)
            {
                txtPickupCurrency.Text = "AUD";
            }
            else if (cmbCountry.SelectedIndex == 4)
            {
                txtPickupCurrency.Text = "INR";
            }
            else if (cmbCountry.SelectedIndex == 5)
            {
                txtPickupCurrency.Text = "CHINASE YUAN";
            }
            else if (cmbCountry.SelectedIndex == 6)
            {
                txtPickupCurrency.Text = "PAK RUPEE";
            }
            else if (cmbCountry.SelectedIndex == 7)
            {
                txtPickupCurrency.Text = "DIRHAM";
            }
            else if (cmbCountry.SelectedIndex == 8)
            {
                txtPickupCurrency.Text = "ZAR";
            }
            else if (cmbCountry.SelectedIndex == 9)
            {
                txtPickupCurrency.Text = "RUSSIA RUBLE";
            }
            else if (cmbCountry.SelectedIndex == 10)
            {
                txtPickupCurrency.Text = "NIGERIAN NIARA";
            }
            else if (cmbCountry.SelectedIndex == 11)
            {
                txtPickupCurrency.Text = "VADAPAV mere bhai";
            }
        }

        private void btnPayTo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount Transferred.");
            Random r = new Random();
            int n = r.Next();
            lblReference.Text += n.ToString();
            txtNewBalances.Text = "new bal";
        }
    }
}

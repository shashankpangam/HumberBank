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
    public partial class WesternUnion : Form
    {
        public WesternUnion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WesterUnionPay obj = new WesterUnionPay();
            this.Hide();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }
    }
}

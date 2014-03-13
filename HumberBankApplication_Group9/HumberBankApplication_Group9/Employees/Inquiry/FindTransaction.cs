using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumberBankApplication_Group9.Employees.Inquiry
{
    public partial class FindTransaction : Form
    {
        public FindTransaction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindTransactionResult obj = new FindTransactionResult();
            this.Hide();
            obj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

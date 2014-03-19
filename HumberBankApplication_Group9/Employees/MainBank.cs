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
    public partial class MainBank : Form
    {
        public MainBank()
        {
            InitializeComponent();
        }

        private void MainBank_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;

            MessageBox.Show("Welcome to Humber Bank of Canada...!!");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAccount1 opn = new OpenAccount1();
            opn.MdiParent = this;
            opn.Show();
        }

        private void closeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAccount close = new CloseAccount();
            close.MdiParent = this;
            close.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit obj = new Deposit();
            obj.MdiParent = this;
            obj.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Transaction.Withdraw obj = new Employees.Transaction.Withdraw();
            obj.MdiParent = this;
            obj.Show();
        }

        private void infoAlertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Request.InfoAlerts obj = new Employees.Request.InfoAlerts();
            obj.MdiParent = this;
            obj.Show();
        }

        private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Inquiry.AccountInfo obj = new Employees.Inquiry.AccountInfo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void transactionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Inquiry.TransactionInfo obj = new Employees.Inquiry.TransactionInfo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void findTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Inquiry.FindTransaction obj = new Employees.Inquiry.FindTransaction();
            obj.MdiParent = this;
            obj.Show();
        }

        private void getStatementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Inquiry.GetStatements obj = new Employees.Inquiry.GetStatements();
            obj.MdiParent = this;
            obj.Show();
        }

        private void newCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Request.NewCard obj = new Employees.Request.NewCard();
            obj.MdiParent = this;
            obj.Show();
        }

        
        private void periodicStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Request.PeriodicStatements obj = new Employees.Request.PeriodicStatements();
            obj.MdiParent = this;
            obj.Show();
        }

        
        private void interAccountTransfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Transfer.InterAccountTransfer obj = new Employees.Transfer.InterAccountTransfer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void interAccountTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Transfer.InterBankTransfer obj = new Employees.Transfer.InterBankTransfer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void interactEMailTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Transfer.InteracEMailTransfer obj = new Employees.Transfer.InteracEMailTransfer();
            obj.MdiParent = this;
            obj.Show();
        }

        private void westernUnionMoneyTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Transfer.WesternUnion obj = new Employees.Transfer.WesternUnion();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}

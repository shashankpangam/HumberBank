﻿using System;
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
    public partial class BranchManager : Form
    {
        public BranchManager()
        {
            InitializeComponent();
        }

        private void BranchAdmin_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 1760;
            this.Height = 960;

            // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null || txtName.Text == "")
            {
                MessageBox.Show("Please Enter Employee's Name");
            }
            else if (txtUName.Text == null || txtUName.Text == "")
            {
                MessageBox.Show("Please Enter UserName");
            }
             else if (txtPassword.Text == null || txtPassword.Text == "")
             {
                 MessageBox.Show("Please Enter Password");
             }
             else
             {
                 MessageBox.Show("Employee Added.");
             }
        }
    }
}

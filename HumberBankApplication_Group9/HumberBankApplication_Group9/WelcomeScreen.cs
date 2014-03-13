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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // for windows size
            this.Width = 800;
            this.Height = 520;
            
            // for progress bar
            this.timer1.Start();

           // for border 
            this.FormBorderStyle = FormBorderStyle.None;

            // for full screen
            //this.WindowState = FormWindowState.Maximized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 250;
            this.progressBar1.Increment(5);
            if (Convert.ToInt32(progressBar1.Value) == 250)
            {
                progressBar1.Value = 0;
                Login login = new Login();
                this.Hide();
                login.Show();
                this.timer1.Stop();
            }
        }
    }
}

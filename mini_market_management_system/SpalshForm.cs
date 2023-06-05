using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_market_management_system
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
        }

        private void SpalshForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            myProgressBar.Value = startPoint;
            startPoint += 2;
            if( myProgressBar.Value == 100)
            {
                myProgressBar.Value = 0;
                timer1.Stop() ;
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}

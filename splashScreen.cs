using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lab2
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          splashScreenTimer.Enabled = false;

            initialForm startForm = new initialForm();
            startForm.Show();
            this.Hide();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

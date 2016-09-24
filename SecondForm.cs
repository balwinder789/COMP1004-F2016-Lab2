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
    public partial class SecondForm : Form
    {
        public initialForm previousForm { get; set; }
        public SecondForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm going back", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.previousForm.Show();
                this.Close();
            }
            else
            {
                this.previousForm.Show();

            }
        }

       
    }
}

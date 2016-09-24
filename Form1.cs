using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lab2
{
    public partial class initialForm : Form
    {
        public initialForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (label1.Text != null)
            {
                Debug.WriteLine("Switching values...");
                label1.Text = (label1.Text == "Hello") ? "Good Bye!" : "Hello";

            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            SecondForm nextForm = new SecondForm();
            nextForm.previousForm= this;
            // show the next form 
            nextForm.Show();
            this.Hide();
        }

        private void initialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblMessage.BackColor = btnBlue.BackColor;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnLeft.Text;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblMessage.Text = btnRight.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }
    }
}

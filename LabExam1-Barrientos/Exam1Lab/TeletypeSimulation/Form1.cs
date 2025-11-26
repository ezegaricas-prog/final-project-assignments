// Student: Ezequiel Barrientos
// Class: ITD 2343
// Trimester: Fall 2025
// Due Date: 9/30/25
// Project: Exam 1 Lab - Teletype Simulation

using System;
using System.Windows.Forms;

namespace TeletypeSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtMessage != null) txtMessage.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage != null && lblSent != null)
            {
                lblSent.Text = txtMessage.Text;
                txtMessage.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlank_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += " "; }
        private void btnPeriod_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "."; }

        private void btnA_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "A"; }
        private void btnB_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "B"; }
        private void btnC_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "C"; }
        private void btnD_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "D"; }
        private void btnE_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "E"; }
        private void btnF_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "F"; }
        private void btnG_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "G"; }
        private void btnH_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "H"; }
        private void btnI_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "I"; }
        private void btnJ_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "J"; }
        private void btnK_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "K"; }
        private void btnL_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "L"; }
        private void btnM_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "M"; }
        private void btnN_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "N"; }
        private void btnO_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "O"; }
        private void btnP_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "P"; }
        private void btnQ_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "Q"; }
        private void btnR_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "R"; }
        private void btnS_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "S"; }
        private void btnT_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "T"; }
        private void btnU_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "U"; }
        private void btnV_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "V"; }
        private void btnW_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "W"; }
        private void btnX_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "X"; }
        private void btnY_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "Y"; }
        private void btnZ_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "Z"; }

        private void btn0_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "0"; }
        private void btn1_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "1"; }
        private void btn2_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { if (txtMessage != null) txtMessage.Text += "9"; }

        private void btaA(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int leftI = 10, rightI = 3, resultI;
            resultI = leftI / rightI;
            lblDisplay.Text = String.Format("{0} / {1} = {2}", leftI, rightI, resultI);

        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            byte leftB = 10, rightB = 20, resultB;
            resultB = (byte)(leftB + rightB);
            lblDisplay.Text = String.Format("{0} + {1} = {2}", leftB, rightB, resultB);

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short leftS = 50, rightS = 25, resultS;
            resultS = (short)(leftS - rightS);
            lblDisplay.Text = String.Format("{0} - {1} = {2}", leftS, rightS, resultS);

        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            long leftL = 100, rightL = 30, resultL;
            resultL = leftL % rightL;
            lblDisplay.Text = String.Format("{0} % {1} = {2}", leftL, rightL, resultL);

        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float leftF = 10.5f, rightF = 3.2f, resultF;
            resultF = leftF % rightF;
            lblDisplay.Text = String.Format("{0} % {1} = {2:F7}", leftF, rightF, resultF);

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double leftD = 22.0, rightD = 7.0, resultD;
            resultD = leftD / rightD;
            lblDisplay.Text = String.Format("{0} / {1} = {2:F15}", leftD, rightD, resultD);

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            decimal leftDec = 15.5m, rightDec = 2.3m, resultDec;
            resultDec = leftDec * rightDec;
            lblDisplay.Text = String.Format("{0} * {1} = {2:F28}", leftDec, rightDec, resultDec);

        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double baseNum = 2.0, exponent = 8.0, resultPow;
            resultPow = Math.Pow(baseNum, exponent);
            lblDisplay.Text = String.Format("{0} ^ {1} = {2}", baseNum, exponent, resultPow);

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double valueR = 3.14159;
            int decimals = 2;
            double resultR = Math.Round(valueR, decimals);
            lblDisplay.Text = String.Format("Round {0} to {1} decimals = {2}", valueR, decimals, resultR);

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double valueS = 25.0, resultS;
            resultS = Math.Sqrt(valueS);
            lblDisplay.Text = String.Format("Sqrt({0}) = {1}", valueS, resultS);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

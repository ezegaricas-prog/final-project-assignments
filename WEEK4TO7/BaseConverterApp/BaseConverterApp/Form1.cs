using System;
using System.Globalization;
using System.Windows.Forms;

namespace BaseConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Conversion logic
        private string ConvertToBase(int number, int baseNum)
        {
            if (baseNum < 2 || baseNum > 16)
                return "Error: Base must be between 2 and 16.";

            string result = "";
            int n = number;

            if (n == 0) result = "0";

            while (n > 0)
            {
                int remainder = n % baseNum;
                if (remainder >= 10)
                    result = (char)('A' + remainder - 10) + result;
                else
                    result = remainder + result;
                n /= baseNum;
            }

            string prefix = baseNum == 16 ? "0x" : baseNum + "x";
            return prefix + result;
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text.Trim(), out int number) || number < 0)
            {
                lblMessage.Text = "Invalid number!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!int.TryParse(txtBase.Text.Trim(), out int baseNum) || baseNum < 2 || baseNum > 16)
            {
                lblMessage.Text = "Invalid base!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            lblMessage.ForeColor = System.Drawing.Color.Black;
            lblMessage.Text = ConvertToBase(number, baseNum);
        }

        private void BtnBinary_Click(object sender, EventArgs e) => ConvertPreset(2);
        private void BtnOctal_Click(object sender, EventArgs e) => ConvertPreset(8);
        private void BtnHex_Click(object sender, EventArgs e) => ConvertPreset(16);
        private void BtnBase6_Click(object sender, EventArgs e) => ConvertPreset(6);
        private void BtnBase9_Click(object sender, EventArgs e) => ConvertPreset(9);

        private void ConvertPreset(int baseNum)
        {
            if (!int.TryParse(txtNumber.Text.Trim(), out int number) || number < 0)
            {
                lblMessage.Text = "Invalid number!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            lblMessage.ForeColor = System.Drawing.Color.Black;
            lblMessage.Text = ConvertToBase(number, baseNum);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtBase.Text = "";
            lblMessage.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

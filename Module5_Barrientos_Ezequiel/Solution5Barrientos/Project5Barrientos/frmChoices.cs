using System;
using System.Windows.Forms;

namespace Project5Barrientos
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
            this.AcceptButton = btnCheck;
            this.CancelButton = btnExit;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            txtLeft.Text = "";
            txtMiddle.Text = "";
            txtRight.Text = "";
            txtMiddle.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double leftNum, middleNum, rightNum;

            if (double.TryParse(txtLeft.Text, out leftNum) &&
                double.TryParse(txtMiddle.Text, out middleNum) &&
                double.TryParse(txtRight.Text, out rightNum))
            {
                if (middleNum == leftNum)
                    lblMessage.Text = "The number is equal to the lower end of the range.";
                else if (middleNum == rightNum)
                    lblMessage.Text = "The number is equal to the higher end of the range.";
                else if (middleNum < leftNum)
                    lblMessage.Text = "The number is lower than the low end of the range.";
                else if (middleNum > rightNum)
                    lblMessage.Text = "The number is higher than the high end of the range.";
                else
                    lblMessage.Text = $"The number is within the range of {leftNum} and {rightNum}.";

                txtMiddle.Text = "";
                txtMiddle.Focus();
            }
            else
            {
                lblMessage.Text = "Please enter valid numbers in all boxes.";
            }
        }
    }
}

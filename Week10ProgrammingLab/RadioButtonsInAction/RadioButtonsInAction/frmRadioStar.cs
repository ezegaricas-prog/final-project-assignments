using System;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonsInAction
{
    /*
     * Name: YOUR NAME HERE
     * Class: YOUR CLASS INFORMATION HERE
     * Assignment: Radio Buttons in Action
     * Due Date: MM/DD/YYYY
     */

    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblMessage.Text = "";
            rdoAdd.Checked = true;
            chkVerbose.Checked = true;
            txtLeftOperand.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            StringBuilder errors = new StringBuilder();

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            if (leftText == "")
                errors.AppendLine("Left operand is empty.");
            if (rightText == "")
                errors.AppendLine("Right operand is empty.");

            if (errors.Length > 0)
            {
                lblMessage.Text = errors.ToString();
                return;
            }

            int left, right;
            bool leftOk = int.TryParse(leftText, out left);
            bool rightOk = int.TryParse(rightText, out right);

            if (!leftOk)
                errors.AppendLine("Left operand is not a valid integer.");
            if (!rightOk)
                errors.AppendLine("Right operand is not a valid integer.");

            if (errors.Length > 0)
            {
                lblMessage.Text = errors.ToString();
                return;
            }

            char op = '+';
            if (rdoAdd.Checked) op = '+';
            else if (rdoSubtract.Checked) op = '-';
            else if (rdoMultiply.Checked) op = '*';
            else if (rdoDivide.Checked) op = '/';
            else if (rdoModulus.Checked) op = '%';

            if ((op == '/' || op == '%') && right == 0)
                errors.AppendLine("Cannot divide or modulus by zero.");

            if (op == '%' && (left < 0 || right < 0))
                errors.AppendLine("Modulus cannot be done on negative numbers.");

            if (errors.Length > 0)
            {
                lblMessage.Text = errors.ToString();
                return;
            }

            int result = 0;
            try
            {
                switch (op)
                {
                    case '+': result = left + right; break;
                    case '-': result = left - right; break;
                    case '*': result = left * right; break;
                    case '/': result = left / right; break;
                    case '%': result = left % right; break;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An unexpected error occurred: " + ex.Message;
                return;
            }

            if (chkVerbose.Checked)
                lblMessage.Text = $"{left} {op} {right} = {result}";
            else
                lblMessage.Text = $"The Answer is: {result}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Module6MethodsProjectDL
{
    public partial class frmRealID : Form
    {
        public frmRealID()
        {
            InitializeComponent();

            // Set form properties
            this.Text = "Valid ID Required";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue; // change to any color you like

            // Set label font smaller for validation messages
            lblDisplay.Font = new Font(lblDisplay.Font.FontFamily, 10, FontStyle.Bold);
            lblDisplay.Text = "";
        }

        // Button event handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation('/');
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            PerformOperation('%');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Shared method for calculations and validation
        private void PerformOperation(char op)
        {
            lblDisplay.ForeColor = Color.Black; // valid text color
            List<string> errors;
            double left, right;

            bool valid = ValidateOperands(out left, out right, op, out errors);

            if (!valid)
            {
                lblDisplay.ForeColor = Color.Red;
                lblDisplay.Text = string.Join(Environment.NewLine, errors);
                return;
            }

            try
            {
                double result = Calculate(left, right, op);
                lblDisplay.ForeColor = Color.Black;
                lblDisplay.Text = "Result: " + result;
            }
            catch (DivideByZeroException)
            {
                lblDisplay.ForeColor = Color.Red;
                lblDisplay.Text = "Error: Division or modulus by zero is not allowed.";
            }
            catch (Exception ex)
            {
                lblDisplay.ForeColor = Color.Red;
                lblDisplay.Text = "Unexpected error: " + ex.Message;
            }
        }

        private bool ValidateOperands(out double left, out double right, char op, out List<string> errors)
        {
            errors = new List<string>();
            left = right = 0;

            string leftText = txtLeftOperand.Text.Trim();
            string rightText = txtRightOperand.Text.Trim();

            if (string.IsNullOrEmpty(leftText))
                errors.Add("Left operand cannot be empty.");
            if (string.IsNullOrEmpty(rightText))
                errors.Add("Right operand cannot be empty.");

            bool leftParsed = double.TryParse(leftText, out left);
            if (!leftParsed && !string.IsNullOrEmpty(leftText))
                errors.Add("Left operand must be a number.");

            bool rightParsed = double.TryParse(rightText, out right);
            if (!rightParsed && !string.IsNullOrEmpty(rightText))
                errors.Add("Right operand must be a number.");

            if ((op == '/' || op == '%') && rightParsed && right == 0)
                errors.Add("Right operand cannot be zero for division or modulus.");

            if (op == '%' && ((leftParsed && left < 0) || (rightParsed && right < 0)))
            {
                if (left < 0) errors.Add("Left operand must be non-negative for modulus.");
                if (right < 0) errors.Add("Right operand must be non-negative for modulus.");
            }

            return errors.Count == 0;
        }

        private double Calculate(double left, double right, char op)
        {
            switch (op)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    return left * right;
                case '/':
                    if (right == 0) throw new DivideByZeroException();
                    return left / right;
                case '%':
                    if (right == 0) throw new DivideByZeroException();
                    return left % right;
                default:
                    throw new InvalidOperationException("Unknown operation");
            }
        }
    }
}

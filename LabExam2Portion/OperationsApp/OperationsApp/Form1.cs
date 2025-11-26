using System;
using System.Globalization;
using System.Windows.Forms;
// Name: Ezequiel Barrientos
// Class: ITD 2343
// Semester: Fall 2025
// Due Date: October 31, 2025
namespace OperationsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnShowMod_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Modulus: Enter two integers. Division will be done by repeated subtraction (no / or %).";
            SetActive("mod");
        }
        private void BtnShowFact_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Factorial: Enter one non-negative integer (0..15).";
            SetActive("fact");
        }
        private void BtnShowFib_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Fibonacci: Enter one non-negative integer (0..45).";
            SetActive("fib");
        }
        private void SetActive(string op)
        {
            btnDoMod.Enabled = (op == "mod");
            btnDoFact.Enabled = (op == "fact");
            btnDoFib.Enabled = (op == "fib");
            if (op == "mod")
            {
                lblOperand1.Visible = lblOperand2.Visible = txtOperand1.Visible = txtOperand2.Visible = true;
                lblOperand1.Text = "Dividend:";
                lblOperand2.Text = "Divisor:";
            }
            else if (op == "fact")
            {
                lblOperand1.Visible = txtOperand1.Visible = true;
                lblOperand1.Text = "Number:";
                lblOperand2.Visible = txtOperand2.Visible = false;
            }
            else if (op == "fib")
            {
                lblOperand1.Visible = txtOperand1.Visible = true;
                lblOperand1.Text = "Term index:";
                lblOperand2.Visible = txtOperand2.Visible = false;
            }
            else
            {
                lblOperand1.Visible = lblOperand2.Visible = txtOperand1.Visible = txtOperand2.Visible = false;
            }
        }
        private void BtnDoMod_Click(object sender, EventArgs e)
        {
            string err = ValidateOperandsForMod(txtOperand1.Text, txtOperand2.Text, out long dividend, out long divisor);
            if (!string.IsNullOrEmpty(err)) { Append(err); return; }
            if (divisor == 0) { Append("Divisor cannot be zero."); return; }
            long quotient = 0;
            long remainder = Math.Abs(dividend);
            long absDiv = Math.Abs(divisor);
            while (remainder >= absDiv)
            {
                remainder -= absDiv;
                quotient++;
            }
            if ((dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0)) quotient = -quotient;
            Append($"{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}");
        }
        private void BtnDoFact_Click(object sender, EventArgs e)
        {
            string err = ValidateInteger(txtOperand1.Text, out long n, false);
            if (!string.IsNullOrEmpty(err)) { Append(err); return; }
            if (n < 0) { Append("Factorial cannot be calculated on negative numbers. Allowed: 0..15."); return; }
            if (n > 15) { Append("Factorial input too large. Allowed: 0..15."); return; }
            long f = 1;
            for (long i = 2; i <= n; i++) f *= i;
            Append($"The answer to {n}! is {f}");
        }
        private void BtnDoFib_Click(object sender, EventArgs e)
        {
            string err = ValidateInteger(txtOperand1.Text, out long n, false);
            if (!string.IsNullOrEmpty(err)) { Append(err); return; }
            if (n < 0) { Append("Fibonacci cannot be calculated on negative numbers. Allowed: 0..45."); return; }
            if (n > 45) { Append("Fibonacci input too large. Allowed: 0..45."); return; }
            long result;
            if (n == 0) result = 0;
            else if (n == 1) result = 1;
            else
            {
                long a = 0, b = 1;
                for (long i = 2; i <= n; i++)
                {
                    long c = a + b;
                    a = b; b = c;
                }
                result = b;
            }
            Append($"Fibonacci({n}) = {result}");
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            Append("Message area cleared. Operand values remain.");
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using the app.", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private string ValidateInteger(string input, out long value, bool allowEmpty)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                if (allowEmpty) return "";
                return "Operand is empty.";
            }
            if (input.Contains(".") || input.Contains(",")) return "Decimal values are prohibited. Enter an integer.";
            if (!long.TryParse(input.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out value)) return $"Invalid integer: '{input}'.";
            return "";
        }
        private string ValidateOperandsForMod(string s1, string s2, out long v1, out long v2)
        {
            v1 = v2 = 0;
            string m1 = ValidateInteger(s1, out v1, false);
            string m2 = ValidateInteger(s2, out v2, false);
            string msg = "";
            if (!string.IsNullOrEmpty(m1)) msg += "Dividend error: " + m1 + Environment.NewLine;
            if (!string.IsNullOrEmpty(m2)) msg += "Divisor error: " + m2 + Environment.NewLine;
            return msg;
        }
        private void Append(string text)
        {
            if (string.IsNullOrEmpty(lblMessage.Text)) lblMessage.Text = text;
            else lblMessage.Text += Environment.NewLine + text;
        }
    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace CheckDigitVerification
{
    public partial class frmCheckDigit : Form
    {
        private const int ACCOUNT_LENGTH = 8;

        public frmCheckDigit()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtConfirmAccount.Text = "";
            txtPayment.Text = "";
            txtMessage.Text = "";
            txtAccount.Focus();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            string account = txtAccount.Text.Trim();
            string confirm = txtConfirmAccount.Text.Trim();
            string paymentText = txtPayment.Text.Trim();

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(paymentText))
            {
                AppendMessage("Error: All fields must be filled (account, confirmation, payment).");
                return;
            }

            if (account.Length != ACCOUNT_LENGTH)
            {
                AppendMessage($"Error: Account number must be {ACCOUNT_LENGTH} digits long.");
                return;
            }

            if (!IsAllDigits(account))
            {
                AppendMessage("Error: Account number must contain only numeric digits (0-9).");
                return;
            }

            if (!IsAllDigits(confirm))
            {
                AppendMessage("Error: Confirmation account must contain only numeric digits (0-9).");
                return;
            }

            if (account != confirm)
            {
                AppendMessage("Error: Account number and confirmation do not match.");
                return;
            }

            if (!ValidateCheckDigit(account))
            {
                AppendMessage("Error: Account number failed check digit verification.");
                return;
            }

            if (!TryParseCurrency(paymentText, out decimal payment))
            {
                AppendMessage("Error: Payment amount is invalid. Enter a numeric currency value (e.g., 140.13 or $1,000.00).");
                return;
            }

            string dateText = DateTime.Now.ToString("MMMM d, yyyy", CultureInfo.CurrentCulture);
            string paymentFormatted = payment.ToString("C", CultureInfo.CurrentCulture);
            AppendMessage($"A payment of {paymentFormatted} was applied to account {account} on {dateText}.");
        }

        private void AppendMessage(string message)
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
                txtMessage.Text = message;
            else
                txtMessage.AppendText(Environment.NewLine + message);
        }

        private bool IsAllDigits(string s)
        {
            return !string.IsNullOrEmpty(s) && s.All(char.IsDigit);
        }

        private bool ValidateCheckDigit(string s)
        {
            if (s.Length != ACCOUNT_LENGTH) return false;
            int sum = 0;
            for (int i = 0; i < s.Length - 1; i++)
                sum += s[i] - '0';
            int check = sum % 10;
            int lastDigit = s[s.Length - 1] - '0';
            return check == lastDigit;
        }

        private bool TryParseCurrency(string input, out decimal value)
        {
            var styles = NumberStyles.AllowCurrencySymbol | NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint;
            return Decimal.TryParse(input, styles, CultureInfo.CurrentCulture, out value);
        }
    }
}

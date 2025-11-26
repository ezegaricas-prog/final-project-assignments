using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sec3LabExam_Barrientos
{
    public partial class MainForm : Form
    {
        private int plainToCipherCount = 0;
        private int cipherToPlainCount = 0;
        private readonly Dictionary<char, char> plainToCipherMap;
        private readonly Dictionary<char, char> cipherToPlainMap;

        public MainForm()
        {
            InitializeComponent();

            plainToCipherMap = new Dictionary<char, char>()
            {
                {'A','R'}, {'B','S'}, {'C','N'}, {'D','E'}, {'E','P'}, {'F','H'},
                {'G','C'}, {'H','A'}, {'I','T'}, {'J','I'}, {'K','M'}, {'L','G'},
                {'M','L'}, {'N','X'}, {'O','W'}, {'P','V'}, {'Q','F'}, {'R','U'},
                {'S','J'}, {'T','Z'}, {'U','K'}, {'V','O'}, {'W','B'}, {'X','Y'},
                {'Y','D'}, {'Z','Q'}
            };

            cipherToPlainMap = new Dictionary<char, char>();
            foreach (var kvp in plainToCipherMap)
            {
                cipherToPlainMap[kvp.Value] = kvp.Key;
            }

            this.AcceptButton = btnConvert;
            this.CancelButton = btnExit;
            txtOutput.ReadOnly = true;
            rdoPlainToCipher.Checked = true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            List<string> errors = ValidateInputs();

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = txtInput.Text;
            bool toCipher = rdoPlainToCipher.Checked;

            string result = ConvertUsingDecoder(input, toCipher);

            txtOutput.Text = result;

            if (toCipher)
                plainToCipherCount++;
            else
                cipherToPlainCount++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            rdoPlainToCipher.Checked = true;
            txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = $"You converted {plainToCipherCount} Plain -> Cipher message(s) and {cipherToPlainCount} Cipher -> Plain message(s).";
            MessageBox.Show(message, "Conversion Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private List<string> ValidateInputs()
        {
            List<string> errors = new List<string>();

            if (!rdoPlainToCipher.Checked && !rdoCipherToPlain.Checked)
            {
                errors.Add("Please select convert direction (Plain -> Cipher or Cipher -> Plain).");
            }

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                errors.Add("Input text is empty. Enter the text to convert.");
            }

            const int maxLen = 20000;
            if (txtInput.Text.Length > maxLen)
            {
                errors.Add($"Input text is too long. Maximum allowed length is {maxLen} characters.");
            }

            return errors;
        }

        private string ConvertUsingDecoder(string input, bool plainToCipher)
        {
            if (input == null) return string.Empty;

            Dictionary<char, char> map = plainToCipher ? plainToCipherMap : cipherToPlainMap;
            StringBuilder sb = new StringBuilder(input.Length);

            foreach (char ch in input)
            {
                char upper = char.ToUpperInvariant(ch);

                if (char.IsLetter(upper))
                {
                    if (map.TryGetValue(upper, out char mapped))
                    {
                        sb.Append(mapped);
                    }
                    else
                    {
                        sb.Append(upper);
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString().ToUpperInvariant();
        }
    }
}

using System;
using System.Text;
using System.Windows.Forms;

namespace Week8ProgrammingLab
{
    public partial class frmCollections : Form
    {
        private const int MAX_ELEMENTS = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;

        private int[] numbers = new int[MAX_ELEMENTS];
        private int itemCount = 0;

        public frmCollections()
        {
            InitializeComponent();
            this.Text = "Collection Lab";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnAddNumber;
            this.CancelButton = btnExit;
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            txtStatsBox.Text = "";
            txtCollectionDisplay.Text = "";

            string input = txtNumberInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                txtStatsBox.Text = "Input error: No value entered. Please enter an integer.";
                txtNumberInput.Text = "";
                return;
            }

            if (!int.TryParse(input, out int parsedValue))
            {
                if (input.Contains(".") || input.Contains(","))
                    txtStatsBox.Text = "Input error: Decimal numbers not allowed. Enter a whole integer.";
                else
                    txtStatsBox.Text = "Input error: Non-integer value entered. Enter a whole integer.";
                txtNumberInput.Text = "";
                return;
            }

            if (itemCount >= MAX_ELEMENTS)
            {
                txtStatsBox.Text = $"Collection Full Error: Maximum of {MAX_ELEMENTS} numbers reached.";
                txtNumberInput.Text = "";
                return;
            }

            if (parsedValue < MIN_VALUE)
            {
                txtStatsBox.Text = $"Value Out Of Range Error: {parsedValue} is less than minimum allowed ({MIN_VALUE}).";
                txtNumberInput.Text = "";
                return;
            }

            if (parsedValue > MAX_VALUE)
            {
                txtStatsBox.Text = $"Value Out Of Range Error: {parsedValue} is greater than maximum allowed ({MAX_VALUE}).";
                txtNumberInput.Text = "";
                return;
            }

            numbers[itemCount] = parsedValue;
            itemCount++;
            txtStatsBox.Text = $"Number {parsedValue} added. Collection contains {itemCount} item(s).";
            txtNumberInput.Text = "";
            txtNumberInput.Focus();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            txtCollectionDisplay.Text = "";
            txtStatsBox.Text = "";

            if (itemCount == 0)
            {
                txtStatsBox.Text = "Collection is empty. No statistics to display.";
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < itemCount; i++)
            {
                sb.AppendLine(numbers[i].ToString());
            }
            txtCollectionDisplay.Text = sb.ToString();

            int count = itemCount;
            long sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < itemCount; i++)
            {
                int n = numbers[i];
                sum += n;
                if (n < min) min = n;
                if (n > max) max = n;
            }

            double average = (double)sum / count;

            StringBuilder stats = new StringBuilder();
            stats.AppendLine($"Average: {average.ToString("F4")}");
            stats.AppendLine($"High Number: {max}");
            stats.AppendLine($"Low Number: {min}");
            stats.AppendLine($"Number of Items: {count}");

            txtStatsBox.Text = stats.ToString();

            ClearCollection();
            txtNumberInput.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearCollection();
            txtCollectionDisplay.Text = "";
            txtNumberInput.Text = "";
            txtStatsBox.Text = "Collection cleared.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearCollection()
        {
            itemCount = 0;
            for (int i = 0; i < numbers.Length; i++) numbers[i] = 0;
        }
    }
}

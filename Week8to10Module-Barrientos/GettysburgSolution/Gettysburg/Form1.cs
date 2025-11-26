using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gettysburg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initial UI state
            rdoAll.Checked = true;
            chkFrequency.Enabled = false;
            txtInput.Text = "Paste text here or click Load Gettysburg then press Process.";
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        // Escape key closes (ties to Exit)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                BtnExit_Click(this, EventArgs.Empty);
        }

        private void ViewOptionChanged(object sender, EventArgs e)
        {
            chkFrequency.Enabled = rdoUnique.Checked;
            if (!chkFrequency.Enabled)
                chkFrequency.Checked = false;
        }

        private void BtnLoadGettysburg_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Gettysburg.txt");
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Gettysburg.txt not found in application folder:\n{filePath}\n\nAdd Gettysburg.txt to the project and set 'Copy to Output Directory' to 'Copy if newer'.",
                                    "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtInput.Text = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Gettysburg.txt:\n" + ex.Message, "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessTextAndDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected processing error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstWords.Items.Clear();
            rdoAll.Checked = true;
            chkFrequency.Checked = false;
            chkFrequency.Enabled = false;
            ResetStatsDisplays();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void ResetStatsDisplays()
        {
            lblSentencesVal.Text = "0";
            lblWordsVal.Text = "0";
            lblUniqueVal.Text = "0";
            lblPairsVal.Text = "0";
            lblCharsVal.Text = "0";
            lblAvgWordLenVal.Text = "0.00";
            lblAvgUniqueLenVal.Text = "0.00";
        }

        private void ProcessTextAndDisplay()
        {
            string text = txtInput.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Input is empty. Paste or load text before processing.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Characters (include spaces & punctuation)
            int charCount = text.Length;

            // Sentence count: '.', '?', '!'
            int sentenceCount = CountSentences(text);

            // Clean tokens: remove punctuation except hyphen and apostrophe (allow typographic apostrophe)
            string cleaned = Regex.Replace(text, @"[^\w\-\s'’]", " ");
            cleaned = cleaned.Replace("’", "'");

            var tokens = Regex.Split(cleaned, @"\s+")
                              .Where(t => !string.IsNullOrWhiteSpace(t))
                              .Select(t => t.Trim())
                              .ToList();

            // Remove pure-numeric tokens (numbers-only)
            var wordTokens = tokens.Where(t => !Regex.IsMatch(t, @"^\d+$")).ToList();
            int wordCount = wordTokens.Count;

            // Unique words (case-insensitive) with frequency
            var uniqueLookup = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var w in wordTokens)
            {
                string wn = w.ToLowerInvariant();
                if (uniqueLookup.ContainsKey(wn)) uniqueLookup[wn]++;
                else uniqueLookup[wn] = 1;
            }
            int uniqueCount = uniqueLookup.Count;

            // Average lengths (includes hyphen/apostrophe in length)
            double avgWordLen = wordCount > 0 ? wordTokens.Average(w => (double)w.Length) : 0.0;
            double avgUniqueLen = uniqueCount > 0 ? uniqueLookup.Keys.Average(k => (double)k.Length) : 0.0;

            // Two-word pairs (per sentence, do not cross sentences)
            var pairs = BuildTwoWordPairs(text);
            var pairCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var p in pairs)
            {
                var key = p.ToLowerInvariant();
                if (pairCounts.ContainsKey(key)) pairCounts[key]++;
                else pairCounts[key] = 1;
            }

            // For stats display show total pair occurrences (sum of counts)
            int totalPairs = pairCounts.Values.Sum();

            // Populate stats labels
            lblSentencesVal.Text = sentenceCount.ToString();
            lblWordsVal.Text = wordCount.ToString();
            lblUniqueVal.Text = uniqueCount.ToString();
            lblPairsVal.Text = totalPairs.ToString();
            lblCharsVal.Text = charCount.ToString();
            lblAvgWordLenVal.Text = avgWordLen.ToString("0.00");
            lblAvgUniqueLenVal.Text = avgUniqueLen.ToString("0.00");

            // Populate listbox
            lstWords.BeginUpdate();
            lstWords.Items.Clear();

            if (rdoAll.Checked)
            {
                // Alphabetic listing of all words (duplicates included)
                var sortedAll = wordTokens.OrderBy(w => w, StringComparer.OrdinalIgnoreCase).ToList();
                foreach (var w in sortedAll) lstWords.Items.Add(w);
            }
            else if (rdoUnique.Checked)
            {
                var uniqueSorted = uniqueLookup.Keys.OrderBy(k => k, StringComparer.OrdinalIgnoreCase).ToList();
                if (chkFrequency.Checked)
                {
                    foreach (var k in uniqueSorted)
                        lstWords.Items.Add($"{k} ({uniqueLookup[k]})");
                }
                else
                {
                    foreach (var k in uniqueSorted) lstWords.Items.Add(k);
                }
            }
            else if (rdoPairs.Checked)
            {
                // Only include pairs that appear more than once; if a pair appears n>1 times, show it n times
                var pairsToShow = new List<string>();
                foreach (var kv in pairCounts.OrderBy(k => k.Key))
                {
                    if (kv.Value > 1)
                    {
                        for (int i = 0; i < kv.Value; i++)
                            pairsToShow.Add(kv.Key);
                    }
                }

                foreach (var p in pairsToShow.OrderBy(p => p, StringComparer.OrdinalIgnoreCase))
                    lstWords.Items.Add(p);
            }

            lstWords.EndUpdate();
        }

        private static int CountSentences(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            int count = 0;
            foreach (char c in text)
            {
                if (c == '.' || c == '?' || c == '!') count++;
            }
            return count;
        }

        private static List<string> BuildTwoWordPairs(string text)
        {
            var pairs = new List<string>();
            // Split sentences on ., ?, !
            var sentenceSplit = Regex.Split(text, @"(?<=[\.!\?])\s+");
            foreach (var sentence in sentenceSplit)
            {
                if (string.IsNullOrWhiteSpace(sentence)) continue;
                string cleaned = Regex.Replace(sentence, @"[^\w\-\s'’]", " ");
                cleaned = cleaned.Replace("’", "'");
                var tokens = Regex.Split(cleaned, @"\s+")
                                  .Where(t => !string.IsNullOrWhiteSpace(t))
                                  .Select(t => t.Trim())
                                  .ToList();
                var wordTokens = tokens.Where(t => !Regex.IsMatch(t, @"^\d+$")).ToList();
                for (int i = 0; i + 1 < wordTokens.Count; i++)
                {
                    string a = wordTokens[i];
                    string b = wordTokens[i + 1];
                    pairs.Add($"{a} {b}");
                }
            }
            return pairs;
        }
    }
}

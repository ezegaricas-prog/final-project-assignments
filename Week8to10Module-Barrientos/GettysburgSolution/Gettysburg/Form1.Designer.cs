namespace Gettysburg
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoadGettysburg;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoUnique;
        private System.Windows.Forms.RadioButton rdoPairs;
        private System.Windows.Forms.CheckBox chkFrequency;
        private System.Windows.Forms.Label lblSentences, lblWords, lblUnique, lblPairs, lblChars, lblAvgWordLen, lblAvgUniqueLen;
        private System.Windows.Forms.Label lblSentencesVal, lblWordsVal, lblUniqueVal, lblPairsVal, lblCharsVal, lblAvgWordLenVal, lblAvgUniqueLenVal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Form
            this.Text = "Text Stats Processor - Gettysburg";
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // txtInput
            this.txtInput = new System.Windows.Forms.TextBox()
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(640, 380),
                Multiline = true,
                ScrollBars = System.Windows.Forms.ScrollBars.Both,
                WordWrap = true,
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right,
                Name = "txtInput"
            };

            // lstWords
            this.lstWords = new System.Windows.Forms.ListBox()
            {
                Location = new System.Drawing.Point(660, 12),
                Size = new System.Drawing.Size(320, 660),
                Font = new System.Drawing.Font("Consolas", 10F),
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom,
                Name = "lstWords"
            };

            // Buttons
            this.btnLoadGettysburg = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(12, 400),
                Size = new System.Drawing.Size(140, 32),
                Text = "Load Gettysburg",
                Name = "btnLoadGettysburg"
            };
            this.btnLoadGettysburg.Click += new System.EventHandler(this.BtnLoadGettysburg_Click);

            this.btnProcess = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(160, 400),
                Size = new System.Drawing.Size(110, 32),
                Text = "Process",
                Name = "btnProcess"
            };
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);

            this.btnClear = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(280, 400),
                Size = new System.Drawing.Size(110, 32),
                Text = "Clear",
                Name = "btnClear"
            };
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.btnExit = new System.Windows.Forms.Button()
            {
                Location = new System.Drawing.Point(400, 400),
                Size = new System.Drawing.Size(110, 32),
                Text = "Exit",
                Name = "btnExit"
            };
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // grpView
            this.grpView = new System.Windows.Forms.GroupBox()
            {
                Location = new System.Drawing.Point(12, 450),
                Size = new System.Drawing.Size(300, 120),
                Text = "View",
                Name = "grpView"
            };

            this.rdoAll = new System.Windows.Forms.RadioButton() { Location = new System.Drawing.Point(12, 24), Text = "Show Word List (All Words)", AutoSize = true, Name = "rdoAll" };
            this.rdoAll.CheckedChanged += new System.EventHandler(this.ViewOptionChanged);

            this.rdoUnique = new System.Windows.Forms.RadioButton() { Location = new System.Drawing.Point(12, 52), Text = "Show Unique Word List", AutoSize = true, Name = "rdoUnique" };
            this.rdoUnique.CheckedChanged += new System.EventHandler(this.ViewOptionChanged);

            this.rdoPairs = new System.Windows.Forms.RadioButton() { Location = new System.Drawing.Point(12, 80), Text = "Show Two-Word Pair List (optional)", AutoSize = true, Name = "rdoPairs" };
            this.rdoPairs.CheckedChanged += new System.EventHandler(this.ViewOptionChanged);

            this.grpView.Controls.Add(this.rdoAll);
            this.grpView.Controls.Add(this.rdoUnique);
            this.grpView.Controls.Add(this.rdoPairs);

            // chkFrequency
            this.chkFrequency = new System.Windows.Forms.CheckBox()
            {
                Location = new System.Drawing.Point(330, 450),
                Size = new System.Drawing.Size(320, 24),
                Text = "Include Frequency (Unique only)",
                Name = "chkFrequency"
            };

            // Labels
            int startX = 330, startY = 500, lineHeight = 28;

            this.lblSentences = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY), Text = "Sentences:", AutoSize = true };
            this.lblSentencesVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 150, startY), Text = "0", AutoSize = true };

            this.lblWords = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight), Text = "Words (all):", AutoSize = true };
            this.lblWordsVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 150, startY + lineHeight), Text = "0", AutoSize = true };

            this.lblUnique = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight * 2), Text = "Unique Words:", AutoSize = true };
            this.lblUniqueVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 150, startY + lineHeight * 2), Text = "0", AutoSize = true };

            this.lblPairs = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight * 3), Text = "Two-word pairs (total):", AutoSize = true };
            this.lblPairsVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 200, startY + lineHeight * 3), Text = "0", AutoSize = true };

            this.lblChars = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight * 4), Text = "Characters (incl. spaces):", AutoSize = true };
            this.lblCharsVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 200, startY + lineHeight * 4), Text = "0", AutoSize = true };

            this.lblAvgWordLen = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight * 5), Text = "Avg word length:", AutoSize = true };
            this.lblAvgWordLenVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 150, startY + lineHeight * 5), Text = "0.00", AutoSize = true };

            this.lblAvgUniqueLen = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX, startY + lineHeight * 6), Text = "Avg unique word length:", AutoSize = true };
            this.lblAvgUniqueLenVal = new System.Windows.Forms.Label() { Location = new System.Drawing.Point(startX + 200, startY + lineHeight * 6), Text = "0.00", AutoSize = true };

            // Add controls
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                txtInput, lstWords, grpView, chkFrequency,
                btnLoadGettysburg, btnProcess, btnClear, btnExit,
                lblSentences, lblSentencesVal, lblWords, lblWordsVal,
                lblUnique, lblUniqueVal, lblPairs, lblPairsVal,
                lblChars, lblCharsVal, lblAvgWordLen, lblAvgWordLenVal,
                lblAvgUniqueLen, lblAvgUniqueLenVal
            });

            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

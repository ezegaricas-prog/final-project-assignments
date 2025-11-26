namespace Week8ProgrammingLab
{
    partial class frmCollections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCollectionDisplay;
        private System.Windows.Forms.TextBox txtStatsBox;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCollectionDisplay = new System.Windows.Forms.TextBox();
            this.txtStatsBox = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // 
            // frmCollections (basic form properties)
            // 
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCollections";

            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 18);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(200, 15);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Enter an integer (-1217 to 1217):";

            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(23, 40);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(200, 24);
            this.txtNumberInput.TabIndex = 1;

            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(240, 38);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(130, 26);
            this.btnAddNumber.TabIndex = 2;
            this.btnAddNumber.Text = "Add Number";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);

            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(380, 38);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(130, 26);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);

            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(520, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 26);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(600, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // txtCollectionDisplay
            // 
            this.txtCollectionDisplay.Location = new System.Drawing.Point(23, 80);
            this.txtCollectionDisplay.Multiline = true;
            this.txtCollectionDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCollectionDisplay.ReadOnly = true;
            this.txtCollectionDisplay.BackColor = System.Drawing.Color.LightBlue;
            this.txtCollectionDisplay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCollectionDisplay.Size = new System.Drawing.Size(260, 260);
            this.txtCollectionDisplay.Name = "txtCollectionDisplay";
            this.txtCollectionDisplay.TabIndex = 6;

            // 
            // txtStatsBox
            // 
            this.txtStatsBox.Location = new System.Drawing.Point(300, 80);
            this.txtStatsBox.Multiline = true;
            this.txtStatsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatsBox.ReadOnly = true;
            this.txtStatsBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatsBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatsBox.Size = new System.Drawing.Size(370, 260);
            this.txtStatsBox.Name = "txtStatsBox";
            this.txtStatsBox.TabIndex = 7;

            // 
            // Add controls to the form
            // 
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCollectionDisplay);
            this.Controls.Add(this.txtStatsBox);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

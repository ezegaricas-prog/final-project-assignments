namespace Sec3LabExam_Barrientos
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.RadioButton rdoPlainToCipher;
        private System.Windows.Forms.RadioButton rdoCipherToPlain;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.rdoPlainToCipher = new System.Windows.Forms.RadioButton();
            this.rdoCipherToPlain = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Decoder Wheel (Plain ↔ Cipher)";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 60);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(73, 19);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input Text:";
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.AcceptsTab = true;
            this.txtInput.Location = new System.Drawing.Point(20, 85);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(480, 120);
            this.txtInput.TabIndex = 0;
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.rdoPlainToCipher);
            this.grpDirection.Controls.Add(this.rdoCipherToPlain);
            this.grpDirection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpDirection.Location = new System.Drawing.Point(520, 85);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(210, 120);
            this.grpDirection.TabIndex = 2;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Conversion Direction";
            // 
            // rdoPlainToCipher
            // 
            this.rdoPlainToCipher.AutoSize = true;
            this.rdoPlainToCipher.Location = new System.Drawing.Point(12, 28);
            this.rdoPlainToCipher.Name = "rdoPlainToCipher";
            this.rdoPlainToCipher.Size = new System.Drawing.Size(120, 23);
            this.rdoPlainToCipher.TabIndex = 0;
            this.rdoPlainToCipher.Text = "Plain -> Cipher";
            // 
            // rdoCipherToPlain
            // 
            this.rdoCipherToPlain.AutoSize = true;
            this.rdoCipherToPlain.Location = new System.Drawing.Point(12, 60);
            this.rdoCipherToPlain.Name = "rdoCipherToPlain";
            this.rdoCipherToPlain.Size = new System.Drawing.Size(120, 23);
            this.rdoCipherToPlain.TabIndex = 1;
            this.rdoCipherToPlain.Text = "Cipher -> Plain";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(520, 220);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(110, 38);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(640, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(520, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(20, 220);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(150, 19);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Converted Text (result):";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(20, 264);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(710, 110);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpDirection);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(760, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decoder Wheel - Sec3LabExam-Barrientos";
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

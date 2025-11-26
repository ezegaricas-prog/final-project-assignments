namespace CheckDigitVerification
{
    partial class frmCheckDigit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirmAccount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirmAccount = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmCheckDigit
            // 
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtConfirmAccount);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCheckDigit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Digit Verification";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check Digit Verification";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(20, 60);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(149, 23);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Account Number:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(200, 55);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(250, 30);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.MaxLength = 8;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(20, 100);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(147, 23);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "Confirm Account:";
            // 
            // txtConfirmAccount
            // 
            this.txtConfirmAccount.Location = new System.Drawing.Point(200, 95);
            this.txtConfirmAccount.Name = "txtConfirmAccount";
            this.txtConfirmAccount.Size = new System.Drawing.Size(250, 30);
            this.txtConfirmAccount.TabIndex = 4;
            this.txtConfirmAccount.MaxLength = 8;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(20, 140);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(146, 23);
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "Payment Amount:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(200, 135);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(250, 30);
            this.txtPayment.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(200, 180);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 35);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(310, 180);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(20, 230);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(560, 100);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.TabStop = false;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            // 
            // Finalize
            // 
            this.AcceptButton = this.btnProcess;
            this.CancelButton = this.btnExit;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

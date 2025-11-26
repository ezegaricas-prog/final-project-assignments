namespace BaseConverterApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnOctal;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnBase6;
        private System.Windows.Forms.Button btnBase9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnOctal = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnBase6 = new System.Windows.Forms.Button();
            this.btnBase9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(20, 20);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(160, 20);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(60, 20);
            this.txtBase.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(20, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(400, 30);
            this.lblMessage.TabIndex = 2;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(20, 100);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(80, 30);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(120, 100);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(80, 30);
            this.btnBinary.TabIndex = 4;
            this.btnBinary.Text = "Binary";
            this.btnBinary.Click += new System.EventHandler(this.BtnBinary_Click);
            // 
            // btnOctal
            // 
            this.btnOctal.Location = new System.Drawing.Point(220, 100);
            this.btnOctal.Name = "btnOctal";
            this.btnOctal.Size = new System.Drawing.Size(80, 30);
            this.btnOctal.TabIndex = 5;
            this.btnOctal.Text = "Octal";
            this.btnOctal.Click += new System.EventHandler(this.BtnOctal_Click);
            // 
            // btnHex
            // 
            this.btnHex.Location = new System.Drawing.Point(320, 100);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(80, 30);
            this.btnHex.TabIndex = 6;
            this.btnHex.Text = "Hex";
            this.btnHex.Click += new System.EventHandler(this.BtnHex_Click);
            // 
            // btnBase6
            // 
            this.btnBase6.Location = new System.Drawing.Point(420, 100);
            this.btnBase6.Name = "btnBase6";
            this.btnBase6.Size = new System.Drawing.Size(80, 30);
            this.btnBase6.TabIndex = 7;
            this.btnBase6.Text = "Base 6";
            this.btnBase6.Click += new System.EventHandler(this.BtnBase6_Click);
            // 
            // btnBase9
            // 
            this.btnBase9.Location = new System.Drawing.Point(520, 100);
            this.btnBase9.Name = "btnBase9";
            this.btnBase9.Size = new System.Drawing.Size(80, 30);
            this.btnBase9.TabIndex = 8;
            this.btnBase9.Text = "Base 9";
            this.btnBase9.Click += new System.EventHandler(this.BtnBase9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(120, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Decimal Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Base(2-16) :";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(640, 220);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnOctal);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnBase6);
            this.Controls.Add(this.btnBase9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Base Converter App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

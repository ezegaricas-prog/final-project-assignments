namespace OperationsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // control declarations
        private System.Windows.Forms.Button btnShowMod;
        private System.Windows.Forms.Button btnDoMod;
        private System.Windows.Forms.Button btnShowFact;
        private System.Windows.Forms.Button btnDoFact;
        private System.Windows.Forms.Button btnShowFib;
        private System.Windows.Forms.Button btnDoFib;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblMessage;

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

        /// <summary>
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowMod = new System.Windows.Forms.Button();
            this.btnDoMod = new System.Windows.Forms.Button();
            this.btnShowFact = new System.Windows.Forms.Button();
            this.btnDoFact = new System.Windows.Forms.Button();
            this.btnShowFib = new System.Windows.Forms.Button();
            this.btnDoFib = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowMod
            // 
            this.btnShowMod.BackColor = System.Drawing.Color.SlateGray;
            this.btnShowMod.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnShowMod.ForeColor = System.Drawing.Color.White;
            this.btnShowMod.Location = new System.Drawing.Point(30, 20);
            this.btnShowMod.Name = "btnShowMod";
            this.btnShowMod.Size = new System.Drawing.Size(200, 60);
            this.btnShowMod.TabIndex = 0;
            this.btnShowMod.Text = "Show Modulus";
            this.btnShowMod.UseVisualStyleBackColor = false;
            this.btnShowMod.Click += new System.EventHandler(this.BtnShowMod_Click);
            // 
            // btnDoMod
            // 
            this.btnDoMod.BackColor = System.Drawing.Color.SlateGray;
            this.btnDoMod.Enabled = false;
            this.btnDoMod.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnDoMod.ForeColor = System.Drawing.Color.White;
            this.btnDoMod.Location = new System.Drawing.Point(30, 90);
            this.btnDoMod.Name = "btnDoMod";
            this.btnDoMod.Size = new System.Drawing.Size(200, 60);
            this.btnDoMod.TabIndex = 1;
            this.btnDoMod.Text = "&Do Modulus";
            this.btnDoMod.UseVisualStyleBackColor = false;
            this.btnDoMod.Click += new System.EventHandler(this.BtnDoMod_Click);
            // 
            // btnShowFact
            // 
            this.btnShowFact.BackColor = System.Drawing.Color.SlateGray;
            this.btnShowFact.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnShowFact.ForeColor = System.Drawing.Color.White;
            this.btnShowFact.Location = new System.Drawing.Point(260, 20);
            this.btnShowFact.Name = "btnShowFact";
            this.btnShowFact.Size = new System.Drawing.Size(200, 60);
            this.btnShowFact.TabIndex = 2;
            this.btnShowFact.Text = "Show Factorial";
            this.btnShowFact.UseVisualStyleBackColor = false;
            this.btnShowFact.Click += new System.EventHandler(this.BtnShowFact_Click);
            // 
            // btnDoFact
            // 
            this.btnDoFact.BackColor = System.Drawing.Color.SlateGray;
            this.btnDoFact.Enabled = false;
            this.btnDoFact.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnDoFact.ForeColor = System.Drawing.Color.White;
            this.btnDoFact.Location = new System.Drawing.Point(260, 90);
            this.btnDoFact.Name = "btnDoFact";
            this.btnDoFact.Size = new System.Drawing.Size(200, 60);
            this.btnDoFact.TabIndex = 3;
            this.btnDoFact.Text = "&Do Factorial";
            this.btnDoFact.UseVisualStyleBackColor = false;
            this.btnDoFact.Click += new System.EventHandler(this.BtnDoFact_Click);
            // 
            // btnShowFib
            // 
            this.btnShowFib.BackColor = System.Drawing.Color.SlateGray;
            this.btnShowFib.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnShowFib.ForeColor = System.Drawing.Color.White;
            this.btnShowFib.Location = new System.Drawing.Point(490, 20);
            this.btnShowFib.Name = "btnShowFib";
            this.btnShowFib.Size = new System.Drawing.Size(200, 60);
            this.btnShowFib.TabIndex = 4;
            this.btnShowFib.Text = "Show Fibonacci";
            this.btnShowFib.UseVisualStyleBackColor = false;
            this.btnShowFib.Click += new System.EventHandler(this.BtnShowFib_Click);
            // 
            // btnDoFib
            // 
            this.btnDoFib.BackColor = System.Drawing.Color.SlateGray;
            this.btnDoFib.Enabled = false;
            this.btnDoFib.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnDoFib.ForeColor = System.Drawing.Color.White;
            this.btnDoFib.Location = new System.Drawing.Point(490, 90);
            this.btnDoFib.Name = "btnDoFib";
            this.btnDoFib.Size = new System.Drawing.Size(200, 60);
            this.btnDoFib.TabIndex = 5;
            this.btnDoFib.Text = "&Do Fibonacci";
            this.btnDoFib.UseVisualStyleBackColor = false;
            this.btnDoFib.Click += new System.EventHandler(this.BtnDoFib_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(360, 174);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 48);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear Message";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(530, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Font = new System.Drawing.Font("Courier New", 14F);
            this.lblOperand1.Location = new System.Drawing.Point(30, 200);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(120, 21);
            this.lblOperand1.TabIndex = 6;
            this.lblOperand1.Text = "Operand 1:";
            this.lblOperand1.Visible = false;
            // 
            // txtOperand1
            // 
            this.txtOperand1.BackColor = System.Drawing.Color.Beige;
            this.txtOperand1.Font = new System.Drawing.Font("Courier New", 14F);
            this.txtOperand1.Location = new System.Drawing.Point(150, 195);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(204, 29);
            this.txtOperand1.TabIndex = 7;
            this.txtOperand1.TabStop = false;
            this.txtOperand1.Visible = false;
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Font = new System.Drawing.Font("Courier New", 14F);
            this.lblOperand2.Location = new System.Drawing.Point(30, 240);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(120, 21);
            this.lblOperand2.TabIndex = 8;
            this.lblOperand2.Text = "Operand 2:";
            this.lblOperand2.Visible = false;
            // 
            // txtOperand2
            // 
            this.txtOperand2.BackColor = System.Drawing.Color.Beige;
            this.txtOperand2.Font = new System.Drawing.Font("Courier New", 14F);
            this.txtOperand2.Location = new System.Drawing.Point(150, 235);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(204, 29);
            this.txtOperand2.TabIndex = 9;
            this.txtOperand2.TabStop = false;
            this.txtOperand2.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(30, 290);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(660, 130);
            this.lblMessage.TabIndex = 10;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.btnShowMod);
            this.Controls.Add(this.btnDoMod);
            this.Controls.Add(this.btnShowFact);
            this.Controls.Add(this.btnDoFact);
            this.Controls.Add(this.btnShowFib);
            this.Controls.Add(this.btnDoFib);
            this.Controls.Add(this.lblOperand1);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Courier New", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Ezequiel Barrientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

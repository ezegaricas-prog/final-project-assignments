namespace RadioButtonsInAction
{
    partial class frmRadioStar
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSubtract = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.rdoModulus = new System.Windows.Forms.RadioButton();
            this.chkVerbose = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.BackColor = System.Drawing.Color.LightYellow;
            this.txtLeftOperand.Location = new System.Drawing.Point(140, 20);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(180, 23);
            this.txtLeftOperand.TabIndex = 0;
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.BackColor = System.Drawing.Color.LightYellow;
            this.txtRightOperand.Location = new System.Drawing.Point(480, 20);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(180, 23);
            this.txtRightOperand.TabIndex = 1;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(30, 23);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(86, 15);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Left Operand:";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(380, 23);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(94, 15);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "Right Operand:";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rdoAdd);
            this.grpOperations.Controls.Add(this.rdoSubtract);
            this.grpOperations.Controls.Add(this.rdoMultiply);
            this.grpOperations.Controls.Add(this.rdoDivide);
            this.grpOperations.Controls.Add(this.rdoModulus);
            this.grpOperations.Location = new System.Drawing.Point(30, 60);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Size = new System.Drawing.Size(630, 100);
            this.grpOperations.TabIndex = 4;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Math Operations Available";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(20, 30);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(70, 19);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Add (+)";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            this.rdoSubtract.AutoSize = true;
            this.rdoSubtract.Location = new System.Drawing.Point(150, 30);
            this.rdoSubtract.Name = "rdoSubtract";
            this.rdoSubtract.Size = new System.Drawing.Size(99, 19);
            this.rdoSubtract.TabIndex = 1;
            this.rdoSubtract.Text = "Subtract (-)";
            this.rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Location = new System.Drawing.Point(300, 30);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(96, 19);
            this.rdoMultiply.TabIndex = 2;
            this.rdoMultiply.Text = "Multiply (*)";
            this.rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(20, 65);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(87, 19);
            this.rdoDivide.TabIndex = 3;
            this.rdoDivide.Text = "Divide (/)";
            this.rdoDivide.UseVisualStyleBackColor = true;
            // 
            // rdoModulus
            // 
            this.rdoModulus.AutoSize = true;
            this.rdoModulus.Location = new System.Drawing.Point(150, 65);
            this.rdoModulus.Name = "rdoModulus";
            this.rdoModulus.Size = new System.Drawing.Size(104, 19);
            this.rdoModulus.TabIndex = 4;
            this.rdoModulus.Text = "Modulus (%)";
            this.rdoModulus.UseVisualStyleBackColor = true;
            // 
            // chkVerbose
            // 
            this.chkVerbose.AutoSize = true;
            this.chkVerbose.Checked = true;
            this.chkVerbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerbose.Location = new System.Drawing.Point(30, 180);
            this.chkVerbose.Name = "chkVerbose";
            this.chkVerbose.Size = new System.Drawing.Size(209, 19);
            this.chkVerbose.TabIndex = 5;
            this.chkVerbose.Text = "Check to turn on Verbose mode";
            this.chkVerbose.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.Location = new System.Drawing.Point(30, 280);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(630, 110);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRadioStar
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(700, 410);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkVerbose);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.txtLeftOperand);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons in Action";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.CheckBox chkVerbose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}


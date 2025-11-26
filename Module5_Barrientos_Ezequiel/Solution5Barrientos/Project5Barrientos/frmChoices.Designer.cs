namespace Project5Barrientos
{
    partial class frmChoices
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblInstructions.AutoSize = false;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Size = new System.Drawing.Size(560, 50);
            this.lblInstructions.Text = "Enter a number in each text box. Click the button to show if the number in the middle text box is between the numbers in the left and right text boxes. The right number should be larger than the left number.";
            this.lblLeft.AutoSize = false;
            this.lblLeft.Location = new System.Drawing.Point(40, 70);
            this.lblLeft.Size = new System.Drawing.Size(120, 25);
            this.lblLeft.Text = "Left Number";
            this.lblMiddle.AutoSize = false;
            this.lblMiddle.Location = new System.Drawing.Point(230, 70);
            this.lblMiddle.Size = new System.Drawing.Size(160, 25);
            this.lblMiddle.Text = "Number to be Checked";
            this.lblRight.AutoSize = false;
            this.lblRight.Location = new System.Drawing.Point(440, 70);
            this.lblRight.Size = new System.Drawing.Size(120, 25);
            this.lblRight.Text = "Right Number";
            this.txtLeft.Location = new System.Drawing.Point(40, 100);
            this.txtLeft.Size = new System.Drawing.Size(120, 25);
            this.txtMiddle.Location = new System.Drawing.Point(250, 100);
            this.txtMiddle.Size = new System.Drawing.Size(120, 25);
            this.txtRight.Location = new System.Drawing.Point(440, 100);
            this.txtRight.Size = new System.Drawing.Size(120, 25);
            this.btnClear.Location = new System.Drawing.Point(100, 150);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnCheck.Location = new System.Drawing.Point(250, 150);
            this.btnCheck.Size = new System.Drawing.Size(100, 35);
            this.btnCheck.Text = "&Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnExit.Location = new System.Drawing.Point(400, 150);
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.lblMessage.AutoSize = false;
            this.lblMessage.BackColor = System.Drawing.Color.LightGray;
            this.lblMessage.Location = new System.Drawing.Point(12, 200);
            this.lblMessage.Size = new System.Drawing.Size(560, 40);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmChoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Barrientos Choices";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

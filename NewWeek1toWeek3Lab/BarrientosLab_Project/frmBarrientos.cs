using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarrientosLab_Project
{
    public class frmBarrientos : Form
    {
        private Label lblTheDominator;
        private Button btnRed, btnBlue, btnGreen, btnYellow, btnOrange, btnPurple, btnCyan, btnMagenta, btnBrown;
        private Button btnDigit1, btnDigit2, btnDigit3, btnDigit4, btnDigit5, btnDigit6, btnDigit7, btnDigit8, btnDigit9;
        private Button btnClear, btnExit;

        public frmBarrientos()
        {
            this.ClientSize = new Size(400, 800);
            this.Text = "Barrientos - Programming Lab";
            this.BackColor = Color.LightGray;

            lblTheDominator = new Label();
            lblTheDominator.Location = new Point(20, 300);
            lblTheDominator.Size = new Size(360, 150);
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.Text = " ";
            lblTheDominator.Font = new Font("Arial", 72F);
            lblTheDominator.TextAlign = ContentAlignment.MiddleCenter;
            lblTheDominator.AutoSize = false;
            lblTheDominator.TabStop = false;
            this.Controls.Add(lblTheDominator);

            btnRed = new Button();
            btnRed.Size = new Size(100, 60);
            btnRed.Location = new Point(20, 20);
            btnRed.BackColor = Color.Red;
            btnRed.Text = " ";
            btnRed.Click += btnRed_Click;
            this.Controls.Add(btnRed);

            btnBlue = new Button();
            btnBlue.Size = new Size(100, 60);
            btnBlue.Location = new Point(140, 20);
            btnBlue.BackColor = Color.Blue;
            btnBlue.Text = " ";
            btnBlue.Click += btnBlue_Click;
            this.Controls.Add(btnBlue);

            btnGreen = new Button();
            btnGreen.Size = new Size(100, 60);
            btnGreen.Location = new Point(260, 20);
            btnGreen.BackColor = Color.Green;
            btnGreen.Text = " ";
            btnGreen.Click += btnGreen_Click;
            this.Controls.Add(btnGreen);

            btnYellow = new Button();
            btnYellow.Size = new Size(100, 60);
            btnYellow.Location = new Point(20, 100);
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Text = " ";
            btnYellow.Click += btnYellow_Click;
            this.Controls.Add(btnYellow);

            btnOrange = new Button();
            btnOrange.Size = new Size(100, 60);
            btnOrange.Location = new Point(140, 100);
            btnOrange.BackColor = Color.Orange;
            btnOrange.Text = " ";
            btnOrange.Click += btnOrange_Click;
            this.Controls.Add(btnOrange);

            btnPurple = new Button();
            btnPurple.Size = new Size(100, 60);
            btnPurple.Location = new Point(260, 100);
            btnPurple.BackColor = Color.Purple;
            btnPurple.Text = " ";
            btnPurple.Click += btnPurple_Click;
            this.Controls.Add(btnPurple);

            btnCyan = new Button();
            btnCyan.Size = new Size(100, 60);
            btnCyan.Location = new Point(20, 180);
            btnCyan.BackColor = Color.Cyan;
            btnCyan.Text = " ";
            btnCyan.Click += btnCyan_Click;
            this.Controls.Add(btnCyan);

            btnMagenta = new Button();
            btnMagenta.Size = new Size(100, 60);
            btnMagenta.Location = new Point(140, 180);
            btnMagenta.BackColor = Color.Magenta;
            btnMagenta.Text = " ";
            btnMagenta.Click += btnMagenta_Click;
            this.Controls.Add(btnMagenta);

            btnBrown = new Button();
            btnBrown.Size = new Size(100, 60);
            btnBrown.Location = new Point(260, 180);
            btnBrown.BackColor = Color.Brown;
            btnBrown.Text = " ";
            btnBrown.Click += btnBrown_Click;
            this.Controls.Add(btnBrown);

            btnDigit1 = new Button();
            btnDigit1.Size = new Size(100, 60);
            btnDigit1.Location = new Point(20, 500);
            btnDigit1.Text = "1";
            btnDigit1.BackColor = Color.White;
            btnDigit1.Font = new Font("Arial", 24F);
            btnDigit1.Click += btnDigit1_Click;
            this.Controls.Add(btnDigit1);

            btnDigit2 = new Button();
            btnDigit2.Size = new Size(100, 60);
            btnDigit2.Location = new Point(140, 500);
            btnDigit2.Text = "2";
            btnDigit2.BackColor = Color.White;
            btnDigit2.Font = new Font("Arial", 24F);
            btnDigit2.Click += btnDigit2_Click;
            this.Controls.Add(btnDigit2);

            btnDigit3 = new Button();
            btnDigit3.Size = new Size(100, 60);
            btnDigit3.Location = new Point(260, 500);
            btnDigit3.Text = "3";
            btnDigit3.BackColor = Color.White;
            btnDigit3.Font = new Font("Arial", 24F);
            btnDigit3.Click += btnDigit3_Click;
            this.Controls.Add(btnDigit3);

            btnDigit4 = new Button();
            btnDigit4.Size = new Size(100, 60);
            btnDigit4.Location = new Point(20, 580);
            btnDigit4.Text = "4";
            btnDigit4.BackColor = Color.White;
            btnDigit4.Font = new Font("Arial", 24F);
            btnDigit4.Click += btnDigit4_Click;
            this.Controls.Add(btnDigit4);

            btnDigit5 = new Button();
            btnDigit5.Size = new Size(100, 60);
            btnDigit5.Location = new Point(140, 580);
            btnDigit5.Text = "5";
            btnDigit5.BackColor = Color.White;
            btnDigit5.Font = new Font("Arial", 24F);
            btnDigit5.Click += btnDigit5_Click;
            this.Controls.Add(btnDigit5);

            btnDigit6 = new Button();
            btnDigit6.Size = new Size(100, 60);
            btnDigit6.Location = new Point(260, 580);
            btnDigit6.Text = "6";
            btnDigit6.BackColor = Color.White;
            btnDigit6.Font = new Font("Arial", 24F);
            btnDigit6.Click += btnDigit6_Click;
            this.Controls.Add(btnDigit6);

            btnDigit7 = new Button();
            btnDigit7.Size = new Size(100, 60);
            btnDigit7.Location = new Point(20, 660);
            btnDigit7.Text = "7";
            btnDigit7.BackColor = Color.White;
            btnDigit7.Font = new Font("Arial", 24F);
            btnDigit7.Click += btnDigit7_Click;
            this.Controls.Add(btnDigit7);

            btnDigit8 = new Button();
            btnDigit8.Size = new Size(100, 60);
            btnDigit8.Location = new Point(140, 660);
            btnDigit8.Text = "8";
            btnDigit8.BackColor = Color.White;
            btnDigit8.Font = new Font("Arial", 24F);
            btnDigit8.Click += btnDigit8_Click;
            this.Controls.Add(btnDigit8);

            btnDigit9 = new Button();
            btnDigit9.Size = new Size(100, 60);
            btnDigit9.Location = new Point(260, 660);
            btnDigit9.Text = "9";
            btnDigit9.BackColor = Color.White;
            btnDigit9.Font = new Font("Arial", 24F);
            btnDigit9.Click += btnDigit9_Click;
            this.Controls.Add(btnDigit9);

            btnClear = new Button();
            btnClear.Size = new Size(160, 40);
            btnClear.Location = new Point(20, 740);
            btnClear.Text = "&C";
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Arial", 14F);
            btnClear.Click += btnClear_Click;
            this.Controls.Add(btnClear);

            btnExit = new Button();
            btnExit.Size = new Size(160, 40);
            btnExit.Location = new Point(220, 740);
            btnExit.Text = "E&X";
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Arial", 14F);
            btnExit.Click += btnExit_Click;
            this.Controls.Add(btnExit);

            this.CancelButton = btnExit;
        }

        private void btnRed_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Red; }
        private void btnBlue_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Blue; }
        private void btnGreen_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Green; }
        private void btnYellow_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Yellow; }
        private void btnOrange_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Orange; }
        private void btnPurple_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Purple; }
        private void btnCyan_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Cyan; }
        private void btnMagenta_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Magenta; }
        private void btnBrown_Click(object sender, EventArgs e) { lblTheDominator.BackColor = Color.Brown; }

        private void btnDigit1_Click(object sender, EventArgs e) { lblTheDominator.Text = "1"; }
        private void btnDigit2_Click(object sender, EventArgs e) { lblTheDominator.Text = "2"; }
        private void btnDigit3_Click(object sender, EventArgs e) { lblTheDominator.Text = "3"; }
        private void btnDigit4_Click(object sender, EventArgs e) { lblTheDominator.Text = "4"; }
        private void btnDigit5_Click(object sender, EventArgs e) { lblTheDominator.Text = "5"; }
        private void btnDigit6_Click(object sender, EventArgs e) { lblTheDominator.Text = "6"; }
        private void btnDigit7_Click(object sender, EventArgs e) { lblTheDominator.Text = "7"; }
        private void btnDigit8_Click(object sender, EventArgs e) { lblTheDominator.Text = "8"; }
        private void btnDigit9_Click(object sender, EventArgs e) { lblTheDominator.Text = "9"; }

        private void btnClear_Click(object sender, EventArgs e) { lblTheDominator.Text = " "; lblTheDominator.BackColor = Color.White; }
        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}

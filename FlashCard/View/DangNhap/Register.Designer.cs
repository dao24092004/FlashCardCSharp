namespace FlashCard.View.DangNhap
{
    partial class Register
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnRegister = new Panel();
            errRsPass = new Label();
            errRsUsername = new Label();
            errRsEmail = new Label();
            panel3 = new Panel();
            txtRsEmail = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            login = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtRsUsername = new TextBox();
            pictureBox3 = new PictureBox();
            SignUp = new Button();
            panel2 = new Panel();
            txtRsPass = new TextBox();
            pictureBox4 = new PictureBox();
            PnRegister.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PnRegister
            // 
            PnRegister.Controls.Add(errRsPass);
            PnRegister.Controls.Add(errRsUsername);
            PnRegister.Controls.Add(errRsEmail);
            PnRegister.Controls.Add(panel3);
            PnRegister.Controls.Add(pictureBox2);
            PnRegister.Controls.Add(login);
            PnRegister.Controls.Add(label1);
            PnRegister.Controls.Add(panel1);
            PnRegister.Controls.Add(SignUp);
            PnRegister.Controls.Add(panel2);
            PnRegister.Location = new Point(0, 0);
            PnRegister.Name = "PnRegister";
            PnRegister.Size = new Size(336, 419);
            PnRegister.TabIndex = 12;
            // 
            // errRsPass
            // 
            errRsPass.AutoSize = true;
            errRsPass.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errRsPass.ForeColor = Color.Red;
            errRsPass.Location = new Point(42, 280);
            errRsPass.Name = "errRsPass";
            errRsPass.Size = new Size(16, 12);
            errRsPass.TabIndex = 18;
            errRsPass.Text = "err";
            errRsPass.Visible = false;
            // 
            // errRsUsername
            // 
            errRsUsername.AutoSize = true;
            errRsUsername.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errRsUsername.ForeColor = Color.Red;
            errRsUsername.Location = new Point(42, 231);
            errRsUsername.Name = "errRsUsername";
            errRsUsername.Size = new Size(16, 12);
            errRsUsername.TabIndex = 19;
            errRsUsername.Text = "err";
            errRsUsername.Visible = false;
            // 
            // errRsEmail
            // 
            errRsEmail.AutoSize = true;
            errRsEmail.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errRsEmail.ForeColor = Color.Red;
            errRsEmail.Location = new Point(42, 177);
            errRsEmail.Name = "errRsEmail";
            errRsEmail.Size = new Size(16, 12);
            errRsEmail.TabIndex = 20;
            errRsEmail.Text = "err";
            errRsEmail.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtRsEmail);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 43);
            panel3.TabIndex = 11;
            // 
            // txtRsEmail
            // 
            txtRsEmail.Font = new Font("Segoe UI", 14.25F);
            txtRsEmail.Location = new Point(37, 8);
            txtRsEmail.Multiline = true;
            txtRsEmail.Name = "txtRsEmail";
            txtRsEmail.Size = new Size(287, 27);
            txtRsEmail.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mail__2_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(105, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.Location = new Point(105, 315);
            login.Name = "login";
            login.Size = new Size(122, 13);
            login.TabIndex = 10;
            login.Text = "Have a account? Login";
            login.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 96);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 2;
            label1.Text = "Create Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtRsUsername);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 46);
            panel1.TabIndex = 6;
            // 
            // txtRsUsername
            // 
            txtRsUsername.Font = new Font("Segoe UI", 14.25F);
            txtRsUsername.Location = new Point(40, 8);
            txtRsUsername.Multiline = true;
            txtRsUsername.Name = "txtRsUsername";
            txtRsUsername.Size = new Size(287, 30);
            txtRsUsername.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = FlashCard.View.DangNhap.Properties.Resources.person1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Magenta;
            SignUp.Cursor = Cursors.Hand;
            SignUp.Location = new Point(71, 340);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(193, 44);
            SignUp.TabIndex = 8;
            SignUp.Text = "SIGN UP";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SIGNIN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtRsPass);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 41);
            panel2.TabIndex = 7;
            // 
            // txtRsPass
            // 
            txtRsPass.Font = new Font("Segoe UI", 14.25F);
            txtRsPass.Location = new Point(40, 7);
            txtRsPass.Multiline = true;
            txtRsPass.Name = "txtRsPass";
            txtRsPass.Size = new Size(287, 27);
            txtRsPass.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LockPass;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnRegister);
            Name = "Register";
            Size = new Size(336, 419);
            PnRegister.ResumeLayout(false);
            PnRegister.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnRegister;
        private Panel panel3;
        private TextBox txtRsEmail;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label login;
        private Label label1;
        private Panel panel1;
        private TextBox txtRsUsername;
        private PictureBox pictureBox3;
        public Button SignUp;
        private Panel panel2;
        private TextBox txtRsPass;
        private PictureBox pictureBox4;
        private Label errRsPass;
        private Label errRsUsername;
        private Label errRsEmail;
    }
}

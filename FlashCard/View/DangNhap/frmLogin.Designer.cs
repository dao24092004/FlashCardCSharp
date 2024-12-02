namespace FlashCard.View.DangNhap
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            Exit = new Button();
            SIGNIN = new Button();
            ForgotPass = new Label();
            CreateAccount = new Label();
            PnLogin = new Panel();
            errLgPass = new Label();
            errLgEmail = new Label();
            panel3 = new Panel();
            txtLoginEmail = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txtLoginPass = new TextBox();
            pictureBox4 = new PictureBox();
            remember = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PnLogin.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_Photo;
            pictureBox1.Location = new Point(-1, -15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 631);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(120, 31);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 128);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 2;
            label1.Text = "Welcome User";
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(771, 3);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(34, 40);
            Exit.TabIndex = 5;
            Exit.Text = " X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // SIGNIN
            // 
            SIGNIN.BackColor = Color.Magenta;
            SIGNIN.Cursor = Cursors.Hand;
            SIGNIN.Location = new Point(95, 408);
            SIGNIN.Margin = new Padding(3, 4, 3, 4);
            SIGNIN.Name = "SIGNIN";
            SIGNIN.Size = new Size(221, 59);
            SIGNIN.TabIndex = 8;
            SIGNIN.Text = "SIGN IN";
            SIGNIN.UseVisualStyleBackColor = false;
            SIGNIN.Click += SIGNIN_Click;
            // 
            // ForgotPass
            // 
            ForgotPass.AutoSize = true;
            ForgotPass.Cursor = Cursors.Hand;
            ForgotPass.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPass.Location = new Point(144, 377);
            ForgotPass.Name = "ForgotPass";
            ForgotPass.Size = new Size(122, 19);
            ForgotPass.TabIndex = 9;
            ForgotPass.Text = "Forgot Password ?";
            ForgotPass.MouseClick += ForgotPass_Click;
            // 
            // CreateAccount
            // 
            CreateAccount.AutoSize = true;
            CreateAccount.Cursor = Cursors.Hand;
            CreateAccount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccount.Location = new Point(95, 481);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(232, 19);
            CreateAccount.TabIndex = 10;
            CreateAccount.Text = "Don't have account? Create Account";
            CreateAccount.Click += CreateAccount_Click;
            // 
            // PnLogin
            // 
            PnLogin.Controls.Add(errLgPass);
            PnLogin.Controls.Add(errLgEmail);
            PnLogin.Controls.Add(panel3);
            PnLogin.Controls.Add(panel2);
            PnLogin.Controls.Add(remember);
            PnLogin.Controls.Add(pictureBox2);
            PnLogin.Controls.Add(CreateAccount);
            PnLogin.Controls.Add(label1);
            PnLogin.Controls.Add(ForgotPass);
            PnLogin.Controls.Add(SIGNIN);
            PnLogin.Location = new Point(422, 41);
            PnLogin.Margin = new Padding(3, 4, 3, 4);
            PnLogin.Name = "PnLogin";
            PnLogin.Size = new Size(384, 559);
            PnLogin.TabIndex = 11;
            // 
            // errLgPass
            // 
            errLgPass.AutoSize = true;
            errLgPass.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errLgPass.ForeColor = Color.Red;
            errLgPass.Location = new Point(47, 309);
            errLgPass.Name = "errLgPass";
            errLgPass.Size = new Size(21, 15);
            errLgPass.TabIndex = 17;
            errLgPass.Text = "err";
            errLgPass.Visible = false;
            // 
            // errLgEmail
            // 
            errLgEmail.AutoSize = true;
            errLgEmail.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errLgEmail.ForeColor = Color.Red;
            errLgEmail.Location = new Point(47, 243);
            errLgEmail.Name = "errLgEmail";
            errLgEmail.Size = new Size(21, 15);
            errLgEmail.TabIndex = 16;
            errLgEmail.Text = "err";
            errLgEmail.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtLoginEmail);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(1, 189);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 57);
            panel3.TabIndex = 15;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Font = new Font("Segoe UI", 12.75F);
            txtLoginEmail.Location = new Point(42, 11);
            txtLoginEmail.Margin = new Padding(3, 4, 3, 4);
            txtLoginEmail.Multiline = true;
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(327, 41);
            txtLoginEmail.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mail__2_;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtLoginPass);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(0, 259);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 55);
            panel2.TabIndex = 14;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Font = new Font("Segoe UI", 12.75F);
            txtLoginPass.Location = new Point(46, 9);
            txtLoginPass.Margin = new Padding(3, 4, 3, 4);
            txtLoginPass.Multiline = true;
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(325, 40);
            txtLoginPass.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.LockPass;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 55);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // remember
            // 
            remember.AutoSize = true;
            remember.Cursor = Cursors.Hand;
            remember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remember.Location = new Point(49, 337);
            remember.Margin = new Padding(3, 4, 3, 4);
            remember.Name = "remember";
            remember.Size = new Size(133, 24);
            remember.TabIndex = 11;
            remember.TabStop = true;
            remember.Text = "Remember me";
            remember.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(807, 600);
            Controls.Add(PnLogin);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PnLogin.ResumeLayout(false);
            PnLogin.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button Exit;
        private Button SIGNIN;
        private Label ForgotPass;
        private Label CreateAccount;
        private Panel PnLogin;
        private RadioButton remember;
        private Label errLgPass;
        private Label errLgEmail;
        private Panel panel3;
        private TextBox txtLoginEmail;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox txtLoginPass;
        private PictureBox pictureBox4;
    }
}
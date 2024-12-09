namespace FlashCard.View.DangNhap
{
    partial class ForgotPass
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
            PnForgotPass = new Panel();
            errFgPass = new Label();
            errFgCode = new Label();
            errFgEmail = new Label();
            panel3 = new Panel();
            txtFgEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtFgCode = new TextBox();
            pictureBox3 = new PictureBox();
            SecurityCode = new Button();
            panel2 = new Panel();
            txtFgPass = new TextBox();
            pictureBox4 = new PictureBox();
            BackToLogin = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            SIGNIN = new Button();
            PnForgotPass.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PnForgotPass
            // 
            PnForgotPass.Controls.Add(errFgPass);
            PnForgotPass.Controls.Add(errFgCode);
            PnForgotPass.Controls.Add(errFgEmail);
            PnForgotPass.Controls.Add(panel3);
            PnForgotPass.Controls.Add(panel1);
            PnForgotPass.Controls.Add(panel2);
            PnForgotPass.Controls.Add(BackToLogin);
            PnForgotPass.Controls.Add(pictureBox2);
            PnForgotPass.Controls.Add(label1);
            PnForgotPass.Controls.Add(SIGNIN);
            PnForgotPass.Location = new Point(0, 0);
            PnForgotPass.Name = "PnForgotPass";
            PnForgotPass.Size = new Size(336, 419);
            PnForgotPass.TabIndex = 12;
            // 
            // errFgPass
            // 
            errFgPass.AutoSize = true;
            errFgPass.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errFgPass.ForeColor = Color.Red;
            errFgPass.Location = new Point(41, 273);
            errFgPass.Name = "errFgPass";
            errFgPass.Size = new Size(16, 12);
            errFgPass.TabIndex = 24;
            errFgPass.Text = "err";
            errFgPass.Visible = false;
            // 
            // errFgCode
            // 
            errFgCode.AutoSize = true;
            errFgCode.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errFgCode.ForeColor = Color.Red;
            errFgCode.Location = new Point(41, 224);
            errFgCode.Name = "errFgCode";
            errFgCode.Size = new Size(16, 12);
            errFgCode.TabIndex = 25;
            errFgCode.Text = "err";
            errFgCode.Visible = false;
            // 
            // errFgEmail
            // 
            errFgEmail.AutoSize = true;
            errFgEmail.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errFgEmail.ForeColor = Color.Red;
            errFgEmail.Location = new Point(41, 170);
            errFgEmail.Name = "errFgEmail";
            errFgEmail.Size = new Size(16, 12);
            errFgEmail.TabIndex = 26;
            errFgEmail.Text = "err";
            errFgEmail.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtFgEmail);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(2, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 43);
            panel3.TabIndex = 23;
            // 
            // txtFgEmail
            // 
            txtFgEmail.Font = new Font("Segoe UI", 14.25F);
            txtFgEmail.Location = new Point(37, 8);
            txtFgEmail.Multiline = true;
            txtFgEmail.Name = "txtFgEmail";
            txtFgEmail.Size = new Size(287, 27);
            txtFgEmail.TabIndex = 10;
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
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(txtFgCode);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(SecurityCode);
            panel1.Location = new Point(-1, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 46);
            panel1.TabIndex = 21;
            // 
            // txtFgCode
            // 
            txtFgCode.Enabled = false;
            txtFgCode.Font = new Font("Segoe UI", 14.25F);
            txtFgCode.Location = new Point(40, 8);
            txtFgCode.Multiline = true;
            txtFgCode.Name = "txtFgCode";
            txtFgCode.Size = new Size(135, 30);
            txtFgCode.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.maCode;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // SecurityCode
            // 
            SecurityCode.Cursor = Cursors.Hand;
            SecurityCode.Location = new Point(200, 8);
            SecurityCode.Name = "SecurityCode";
            SecurityCode.Size = new Size(104, 30);
            SecurityCode.TabIndex = 11;
            SecurityCode.Text = "Security Code";
            SecurityCode.UseVisualStyleBackColor = true;
            SecurityCode.Click += SecurityCode_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtFgPass);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(-1, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 41);
            panel2.TabIndex = 22;
            // 
            // txtFgPass
            // 
            txtFgPass.Font = new Font("Segoe UI", 14.25F);
            txtFgPass.Location = new Point(40, 7);
            txtFgPass.Multiline = true;
            txtFgPass.Name = "txtFgPass";
            txtFgPass.Size = new Size(287, 27);
            txtFgPass.TabIndex = 10;
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
            // BackToLogin
            // 
            BackToLogin.AutoSize = true;
            BackToLogin.Cursor = Cursors.Hand;
            BackToLogin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackToLogin.Location = new Point(128, 313);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(77, 13);
            BackToLogin.TabIndex = 12;
            BackToLogin.Text = "Back To Login";
            BackToLogin.Click += BackToLogin_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 95);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 2;
            label1.Text = "Forgot Pass";
            // 
            // SIGNIN
            // 
            SIGNIN.BackColor = Color.Magenta;
            SIGNIN.Cursor = Cursors.Hand;
            SIGNIN.Location = new Point(72, 338);
            SIGNIN.Name = "SIGNIN";
            SIGNIN.Size = new Size(193, 44);
            SIGNIN.TabIndex = 8;
            SIGNIN.Text = "SIGN IN";
            SIGNIN.UseVisualStyleBackColor = false;
            SIGNIN.Click += SIGNIN_Click;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnForgotPass);
            Name = "ForgotPass";
            Size = new Size(336, 419);
            PnForgotPass.ResumeLayout(false);
            PnForgotPass.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnForgotPass;
        private PictureBox pictureBox2;
        private Label label1;
        public Button SIGNIN;
        private Label BackToLogin;
        private Button SecurityCode;
        private Label errFgPass;
        private Label errFgCode;
        private Label errFgEmail;
        private Panel panel3;
        private TextBox txtFgEmail;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtFgCode;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox txtFgPass;
        private PictureBox pictureBox4;
    }
}

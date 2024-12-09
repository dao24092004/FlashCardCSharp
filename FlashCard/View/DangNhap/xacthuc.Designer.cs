namespace FlashCard.View.DangNhap
{
    partial class xacthuc
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 35);
            label1.TabIndex = 1;
            label1.Text = "Nhap vao ma xac thuc";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightYellow;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(70, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 39);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightYellow;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(156, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightYellow;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(250, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 39);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightYellow;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(342, 60);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 39);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightYellow;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(442, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(43, 39);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightYellow;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(536, 60);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(43, 39);
            textBox6.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(396, 130);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 8;
            button1.Text = "Tiếp tục ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(127, 130);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 9;
            button2.Text = "Gửi lại mã ";
            button2.UseVisualStyleBackColor = false;
            // 
            // xacthuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(641, 184);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "xacthuc";
            Text = "xacthuc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}
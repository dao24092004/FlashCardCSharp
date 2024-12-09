namespace FlashCard.View.TrangChu
{
    partial class ThongTinNguoiDung
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtMoTa = new TextBox();
            btnLuu = new Button();
            buttonChonAnh = new Button();
            label5 = new Label();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(385, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 181);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 223);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 269);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(229, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(576, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(229, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(576, 27);
            txtName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 385);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Mô tả ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(229, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(576, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(229, 385);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(576, 27);
            txtMoTa.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(421, 458);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 39);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu ";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnSave_Click;
            // 
            // buttonChonAnh
            // 
            
            buttonChonAnh.ImageAlign = ContentAlignment.MiddleRight;
            buttonChonAnh.Location = new Point(564, 135);
            buttonChonAnh.Name = "buttonChonAnh";
            buttonChonAnh.Size = new Size(104, 37);
            buttonChonAnh.TabIndex = 12;
            buttonChonAnh.Text = "Thêm ảnh";
            buttonChonAnh.TextAlign = ContentAlignment.MiddleLeft;
            buttonChonAnh.UseVisualStyleBackColor = true;
            buttonChonAnh.Click += btnChoosePicture_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 330);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 13;
            label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(229, 330);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(575, 27);
            txtDiaChi.TabIndex = 14;
            // 
            // ThongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(txtMoTa);
            Controls.Add(buttonChonAnh);
            Controls.Add(btnLuu);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ThongTinNguoiDung";
            Size = new Size(960, 602);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion






        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;

        private Label label3;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMoTa;
        private Button btnLuu;
        private Button buttonChonAnh;
        private Label label5;
        private TextBox txtDiaChi;
    }
}

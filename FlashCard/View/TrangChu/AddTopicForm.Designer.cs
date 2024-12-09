namespace FlashCard.View.TrangChu
{
    partial class AddTopicForm
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
            lbThemTu = new Label();
            label3 = new Label();
            txtTopicName = new TextBox();
            txtMoTa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lbVidu = new Label();
            label8 = new Label();
            lbCapNhapTu = new Label();
            SuspendLayout();
            // 
            // lbThemTu
            // 
            lbThemTu.AutoSize = true;
            lbThemTu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThemTu.Location = new Point(130, 10);
            lbThemTu.Name = "lbThemTu";
            lbThemTu.Size = new Size(265, 54);
            lbThemTu.TabIndex = 2;
            lbThemTu.Text = "Thêm chủ đề";
            lbThemTu.Click += lbThemTu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên chủ đề";
            label3.Click += label3_Click;
            // 
            // txtTopicName
            // 
            txtTopicName.Location = new Point(193, 99);
            txtTopicName.Name = "txtTopicName";
            txtTopicName.Size = new Size(243, 27);
            txtTopicName.TabIndex = 4;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(193, 167);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(243, 27);
            txtMoTa.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 163);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 7;
            label4.Text = "Mô tả";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 270);
            label5.Name = "label5";
            label5.Size = new Size(0, 28);
            label5.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(98, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(268, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbVidu
            // 
            lbVidu.AutoSize = true;
            lbVidu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVidu.Location = new Point(50, 217);
            lbVidu.Name = "lbVidu";
            lbVidu.Size = new Size(0, 28);
            lbVidu.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 323);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 15;
            // 
            // lbCapNhapTu
            // 
            lbCapNhapTu.AutoSize = true;
            lbCapNhapTu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCapNhapTu.Location = new Point(83, 10);
            lbCapNhapTu.Name = "lbCapNhapTu";
            lbCapNhapTu.Size = new Size(328, 54);
            lbCapNhapTu.TabIndex = 18;
            lbCapNhapTu.Text = "Cập nhật chủ đề";
            lbCapNhapTu.Visible = false;
            // 
            // AddTopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 303);
            Controls.Add(lbCapNhapTu);
            Controls.Add(label8);
            Controls.Add(lbVidu);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMoTa);
            Controls.Add(txtTopicName);
            Controls.Add(label3);
            Controls.Add(lbThemTu);
            Name = "AddTopicForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbThemTu;
        private Label label3;
        private TextBox txtTopicName;
        private TextBox txtMoTa;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private Label lbVidu;
        private Label label8;
        private Label lbCapNhapTu;


    }
}
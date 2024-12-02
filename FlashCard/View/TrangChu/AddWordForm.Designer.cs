namespace FlashCard.View.TrangChu
{
    partial class AddWordForm
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
            txtWord = new TextBox();
            txtMeaning = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            comboxTopic = new ComboBox();
            lbVidu = new Label();
            label8 = new Label();
            comboxDifficulty = new ComboBox();
            txtExample = new TextBox();
            lbCapNhapTu = new Label();
            SuspendLayout();
            // 
            // lbThemTu
            // 
            lbThemTu.AutoSize = true;
            lbThemTu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThemTu.Location = new Point(130, 10);
            lbThemTu.Name = "lbThemTu";
            lbThemTu.Size = new Size(212, 54);
            lbThemTu.TabIndex = 2;
            lbThemTu.Text = "THÊM TỪ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 3;
            label3.Text = "Từ vựng";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(193, 99);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(243, 27);
            txtWord.TabIndex = 4;
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(193, 167);
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(243, 27);
            txtMeaning.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 163);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 7;
            label4.Text = "Nghĩa của từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 270);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 8;
            label5.Text = "Chủ đề";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(102, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(297, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboxTopic
            // 
            comboxTopic.FormattingEnabled = true;
            comboxTopic.Location = new Point(193, 274);
            comboxTopic.Name = "comboxTopic";
            comboxTopic.Size = new Size(243, 28);
            comboxTopic.TabIndex = 11;
            // 
            // lbVidu
            // 
            lbVidu.AutoSize = true;
            lbVidu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVidu.Location = new Point(50, 217);
            lbVidu.Name = "lbVidu";
            lbVidu.Size = new Size(57, 28);
            lbVidu.TabIndex = 14;
            lbVidu.Text = "Ví dụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 323);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 15;
            label8.Text = "Độ khó";
            // 
            // comboxDifficulty
            // 
            comboxDifficulty.FormattingEnabled = true;
            comboxDifficulty.Location = new Point(193, 327);
            comboxDifficulty.Name = "comboxDifficulty";
            comboxDifficulty.Size = new Size(243, 28);
            comboxDifficulty.TabIndex = 16;
            // 
            // txtExample
            // 
            txtExample.Location = new Point(193, 221);
            txtExample.Multiline = true;
            txtExample.Name = "txtExample";
            txtExample.Size = new Size(243, 27);
            txtExample.TabIndex = 17;
            txtExample.TextChanged += txtExample_TextChanged;
            // 
            // lbCapNhapTu
            // 
            lbCapNhapTu.AutoSize = true;
            lbCapNhapTu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCapNhapTu.Location = new Point(64, 9);
            lbCapNhapTu.Name = "lbCapNhapTu";
            lbCapNhapTu.Size = new Size(355, 54);
            lbCapNhapTu.TabIndex = 18;
            lbCapNhapTu.Text = "Cập nhật từ vựng";
            // 
            // AddWordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 498);
            Controls.Add(lbCapNhapTu);
            Controls.Add(txtExample);
            Controls.Add(comboxDifficulty);
            Controls.Add(label8);
            Controls.Add(lbVidu);
            Controls.Add(comboxTopic);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMeaning);
            Controls.Add(txtWord);
            Controls.Add(label3);
            Controls.Add(lbThemTu);
            Name = "AddWordForm";
            ResumeLayout(false);
            PerformLayout();
            lbCapNhapTu.Visible = false; // Ẩn nhãn cập nhật từ
            lbThemTu.Visible = true;    // Hiển thị nhãn thêm từ

        }

        #endregion
        private Label lbThemTu;
        private Label label3;
        private TextBox txtWord;
        private TextBox txtMeaning;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox comboxTopic;
        private Label lbVidu;
        private Label label8;
        private ComboBox comboxDifficulty;
        private TextBox txtExample;
        private Label lbCapNhapTu;


    }
}
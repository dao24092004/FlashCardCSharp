namespace FlashCard.View.TrangChu
{
    partial class Kiemtra
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
            grpMode = new GroupBox();
            rdoMixed = new RadioButton();
            rdoFillInTheBlank = new RadioButton();
            rdoMultipleChoice = new RadioButton();
            lblQuestion = new Label();
            rdoAnswer1 = new RadioButton();
            rdoAnswer2 = new RadioButton();
            rdoAnswer3 = new RadioButton();
            btnCheck = new Button();
            btnNext = new Button();
            progressBar = new ProgressBar();
            lblResult = new Label();
            txtAnswer = new TextBox();
            clbTopics = new CheckedListBox();
            rdoAnswer4 = new RadioButton();
            grpMode.SuspendLayout();
            SuspendLayout();
            // 
            // grpMode
            // 
            grpMode.Controls.Add(rdoMixed);
            grpMode.Controls.Add(rdoFillInTheBlank);
            grpMode.Controls.Add(rdoMultipleChoice);
            grpMode.Location = new Point(12, 14);
            grpMode.Name = "grpMode";
            grpMode.Size = new Size(376, 65);
            grpMode.TabIndex = 0;
            grpMode.TabStop = false;
            grpMode.Text = "Chọn chế độ kiểm tra";
            grpMode.Enter += grpMode_Enter;
            // 
            // rdoMixed
            // 
            rdoMixed.AutoSize = true;
            rdoMixed.Location = new Point(256, 38);
            rdoMixed.Name = "rdoMixed";
            rdoMixed.Size = new Size(94, 24);
            rdoMixed.TabIndex = 2;
            rdoMixed.TabStop = true;
            rdoMixed.Text = "Tổng hợp";
            rdoMixed.UseVisualStyleBackColor = true;
            rdoMixed.CheckedChanged += rdoMixed_CheckedChanged;
            // 
            // rdoFillInTheBlank
            // 
            rdoFillInTheBlank.AutoSize = true;
            rdoFillInTheBlank.Location = new Point(147, 38);
            rdoFillInTheBlank.Name = "rdoFillInTheBlank";
            rdoFillInTheBlank.Size = new Size(79, 24);
            rdoFillInTheBlank.TabIndex = 1;
            rdoFillInTheBlank.TabStop = true;
            rdoFillInTheBlank.Text = "Điền từ";
            rdoFillInTheBlank.UseVisualStyleBackColor = true;
            rdoFillInTheBlank.CheckedChanged += rdoFillInTheBlank_CheckedChanged;
            // 
            // rdoMultipleChoice
            // 
            rdoMultipleChoice.AutoSize = true;
            rdoMultipleChoice.Location = new Point(8, 38);
            rdoMultipleChoice.Name = "rdoMultipleChoice";
            rdoMultipleChoice.Size = new Size(111, 24);
            rdoMultipleChoice.TabIndex = 0;
            rdoMultipleChoice.TabStop = true;
            rdoMultipleChoice.Text = "Trắc nghiệm";
            rdoMultipleChoice.UseVisualStyleBackColor = true;
            rdoMultipleChoice.CheckedChanged += rdoMultipleChoice_CheckedChanged;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(575, 124);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(59, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Câu hỏi";
            // 
            // rdoAnswer1
            // 
            rdoAnswer1.Location = new Point(745, 259);
            rdoAnswer1.Name = "rdoAnswer1";
            rdoAnswer1.Size = new Size(104, 24);
            rdoAnswer1.TabIndex = 16;
            // 
            // rdoAnswer2
            // 
            rdoAnswer2.Location = new Point(530, 259);
            rdoAnswer2.Name = "rdoAnswer2";
            rdoAnswer2.Size = new Size(104, 24);
            rdoAnswer2.TabIndex = 15;
            // 
            // rdoAnswer3
            // 
            rdoAnswer3.Location = new Point(745, 206);
            rdoAnswer3.Name = "rdoAnswer3";
            rdoAnswer3.Size = new Size(104, 24);
            rdoAnswer3.TabIndex = 14;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(530, 310);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(94, 29);
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(745, 310);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 29);
            btnNext.TabIndex = 8;
            btnNext.Text = "Câu tiếp theo";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 390);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(933, 29);
            progressBar.TabIndex = 9;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(712, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 10;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(649, 157);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(200, 27);
            txtAnswer.TabIndex = 12;
            // 
            // clbTopics
            // 
            clbTopics.FormattingEnabled = true;
            clbTopics.Location = new Point(12, 95);
            clbTopics.Name = "clbTopics";
            clbTopics.Size = new Size(376, 290);
            clbTopics.TabIndex = 17;
            // 
            // rdoAnswer4
            // 
            rdoAnswer4.Location = new Point(530, 206);
            rdoAnswer4.Name = "rdoAnswer4";
            rdoAnswer4.Size = new Size(104, 24);
            rdoAnswer4.TabIndex = 13;
            // 
            // Kiemtra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clbTopics);
            Controls.Add(lblResult);
            Controls.Add(progressBar);
            Controls.Add(btnNext);
            Controls.Add(btnCheck);
            Controls.Add(txtAnswer);
            Controls.Add(rdoAnswer4);
            Controls.Add(rdoAnswer3);
            Controls.Add(rdoAnswer2);
            Controls.Add(rdoAnswer1);
            Controls.Add(lblQuestion);
            Controls.Add(grpMode);
            Name = "Kiemtra";
            Size = new Size(948, 473);
            grpMode.ResumeLayout(false);
            grpMode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMode;
        private RadioButton rdoMixed;
        private RadioButton rdoFillInTheBlank;
        private RadioButton rdoMultipleChoice;
        private Label lblQuestion;
        private RadioButton rdoAnswer1;
        private RadioButton rdoAnswer2;
        private RadioButton rdoAnswer3;
        private Button btnCheck;
        private Button btnNext;
        private ProgressBar progressBar;
        private Label lblResult;
        private TextBox txtAnswer;  // Thêm TextBox để người dùng nhập đáp án
        private CheckedListBox clbTopics;
        private RadioButton rdoAnswer4;

        // Phương thức sự kiện cho các RadioButton và Button
        private void btnCheck_Click(object sender, EventArgs e)
        {
            var question = filteredQuestions[currentQuestionIndex];
            string selectedAnswer = null;

            if (question.IsFillInTheBlank)
            {
                selectedAnswer = txtAnswer.Text.Trim();
            }
            else
            {
                if (rdoAnswer1.Checked) selectedAnswer = rdoAnswer1.Text;
                if (rdoAnswer2.Checked) selectedAnswer = rdoAnswer2.Text;
                if (rdoAnswer3.Checked) selectedAnswer = rdoAnswer3.Text;
                if (rdoAnswer4.Checked) selectedAnswer = rdoAnswer4.Text;
            }

            // Kiểm tra nếu không có câu trả lời
            if (string.IsNullOrWhiteSpace(selectedAnswer))
            {
                lblResult.Text = "Vui lòng chọn một đáp án!";
                lblResult.ForeColor = System.Drawing.Color.Orange;
                return;
            }

            // Kiểm tra đáp án
            if (selectedAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblResult.Text = "Đúng!";
                lblResult.ForeColor = System.Drawing.Color.Green; // Hiển thị kết quả đúng
            }
            else
            {
                lblResult.Text = "Sai! Đáp án đúng là: " + question.CorrectAnswer;
                lblResult.ForeColor = System.Drawing.Color.Red; // Hiển thị kết quả sai và đáp án đúng
            }
        }



        private void rdoMixed_CheckedChanged(object sender, EventArgs e)
        {
            // Logic xử lý khi radio button 'Tổng hợp' thay đổi
            if (rdoMixed.Checked)
            {
                isMultipleChoiceSelected = true; // Chọn chế độ trắc nghiệm mặc định
                FilterQuestionsByTopics(); // Lọc câu hỏi khi chọn chế độ 'Tổng hợp'
            }
        }

        private void rdoFillInTheBlank_CheckedChanged(object sender, EventArgs e)
        {
            // Logic xử lý khi radio button 'Điền từ' thay đổi
            if (rdoFillInTheBlank.Checked)
            {
                isMultipleChoiceSelected = false; // Chọn chế độ điền từ
                FilterQuestionsByTopics(); // Lọc câu hỏi khi chọn chế độ 'Điền từ'
            }
        }

        private void rdoMultipleChoice_CheckedChanged(object sender, EventArgs e)
        {
            // Logic xử lý khi radio button 'Trắc nghiệm' thay đổi
            if (rdoMultipleChoice.Checked)
            {
                isMultipleChoiceSelected = true; // Chọn chế độ trắc nghiệm
                FilterQuestionsByTopics(); // Lọc câu hỏi khi chọn chế độ 'Trắc nghiệm'
            }
        }

    }
}

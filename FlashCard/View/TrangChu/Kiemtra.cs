using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class Kiemtra : UserControl
    {
        private List<Question> allQuestions; // Danh sách toàn bộ câu hỏi
        private List<Question> filteredQuestions; // Danh sách câu hỏi đã lọc
        private List<string> topics; // Danh sách chủ đề
        private int currentQuestionIndex = 0;
        private bool isMultipleChoiceSelected = true; // Trạng thái kiểm tra loại câu hỏi
        private int correctAnswersCount = 0; // Số câu trả lời đúng
        private int wrongAnswersCount = 0; // Số câu trả lời sai

        public Kiemtra()
        {
            InitializeComponent();
            allQuestions = new List<Question>();
            filteredQuestions = new List<Question>();
            topics = new List<string>();
            LoadTopics(); // Tải chủ đề mẫu
            LoadQuestions(); // Tải câu hỏi
        }

        // Hàm để tải chủ đề
        private void LoadTopics()
        {
            topics.Add("Nature");
            topics.Add("Science");
            topics.Add("History");
            topics.Add("Technology");

            foreach (var topic in topics)
            {
                clbTopics.Items.Add(topic);
            }

            // Sự kiện khi chọn thay đổi trong CheckedListBox
            clbTopics.ItemCheck += (s, e) =>
            {
                // Lọc câu hỏi sau khi người dùng thay đổi lựa chọn
                BeginInvoke(new Action(FilterQuestionsByTopics));
            };
        }

        // Hàm để tải câu hỏi
        private void LoadQuestions()
        {
            // Chủ đề Nature
            allQuestions.Add(new Question
            {
                Text = "What is the ocean?",
                AnswerChoices = new List<string>
                {
                    "A vast body of salt water that covers most of the earth.",
                    "A desert landscape.",
                    "A form of weather.",
                    "A mountain peak."
                },
                CorrectAnswer = "A vast body of salt water that covers most of the earth.",
                Topic = "Nature",
                IsFillInTheBlank = false // Câu hỏi trắc nghiệm
            });

            allQuestions.Add(new Question
            {
                Text = "What is the largest animal in the ocean?",
                AnswerChoices = new List<string>
                {
                    "Blue whale",
                    "Shark",
                    "Dolphin",
                    "Octopus"
                },
                CorrectAnswer = "Blue whale",
                Topic = "Nature",
                IsFillInTheBlank = false // Câu hỏi trắc nghiệm
            });

            // Chủ đề Science
            allQuestions.Add(new Question
            {
                Text = "The sun is the center of our _________.",
                AnswerChoices = new List<string>(), // Không có lựa chọn trắc nghiệm
                CorrectAnswer = "solar system", // Đáp án điền từ
                Topic = "Science",
                IsFillInTheBlank = true // Câu hỏi điền từ
            });

            allQuestions.Add(new Question
            {
                Text = "What is the chemical symbol for water?",
                AnswerChoices = new List<string>
                {
                    "H2O",
                    "CO2",
                    "O2",
                    "N2"
                },
                CorrectAnswer = "H2O",
                Topic = "Science",
                IsFillInTheBlank = false // Câu hỏi trắc nghiệm
            });

            // Chủ đề History
            allQuestions.Add(new Question
            {
                Text = "Who was the first president of the USA?",
                AnswerChoices = new List<string>
                {
                    "George Washington.",
                    "Abraham Lincoln.",
                    "Thomas Jefferson.",
                    "John Adams."
                },
                CorrectAnswer = "George Washington.",
                Topic = "History",
                IsFillInTheBlank = false
            });

            allQuestions.Add(new Question
            {
                Text = "In which year did World War II end?",
                AnswerChoices = new List<string>
                {
                    "1945",
                    "1939",
                    "1965",
                    "1918"
                },
                CorrectAnswer = "1945",
                Topic = "History",
                IsFillInTheBlank = false
            });

            // Chủ đề Technology
            allQuestions.Add(new Question
            {
                Text = "What is a smartphone?",
                AnswerChoices = new List<string>
                {
                    "A mobile phone with advanced features like internet access.",
                    "A type of computer.",
                    "A new programming language.",
                    "A type of operating system."
                },
                CorrectAnswer = "A mobile phone with advanced features like internet access.",
                Topic = "Technology",
                IsFillInTheBlank = false
            });

            allQuestions.Add(new Question
            {
                Text = "Who developed the first computer mouse?",
                AnswerChoices = new List<string>
                {
                    "Douglas Engelbart",
                    "Bill Gates",
                    "Steve Jobs",
                    "Mark Zuckerberg"
                },
                CorrectAnswer = "Douglas Engelbart",
                Topic = "Technology",
                IsFillInTheBlank = false
            });

            // Lọc câu hỏi mặc định (hiển thị tất cả)
            filteredQuestions = allQuestions;
            LoadQuestion();
        }

        // Lọc câu hỏi theo chủ đề và loại kiểm tra
        private void FilterQuestionsByTopics()
        {
            var selectedTopics = clbTopics.CheckedItems.Cast<string>().ToList();

            if (!selectedTopics.Any())
            {
                MessageBox.Show("Bạn cần chọn ít nhất một chủ đề để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc câu hỏi theo chủ đề và loại câu hỏi
            filteredQuestions = allQuestions
                .Where(q => selectedTopics.Contains(q.Topic) &&
                            (q.IsFillInTheBlank == !isMultipleChoiceSelected || q.IsFillInTheBlank == isMultipleChoiceSelected))
                .ToList();

            if (filteredQuestions.Any())
            {
                currentQuestionIndex = 0;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("No questions match the selected topics and type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hiển thị câu hỏi hiện tại
        private void LoadQuestion()
        {
            if (filteredQuestions.Count == 0) return;

            var question = filteredQuestions[currentQuestionIndex];
            lblQuestion.Text = $"{currentQuestionIndex + 1}/{filteredQuestions.Count} - {question.Text}"; // Hiển thị số câu hỏi

            if (question.IsFillInTheBlank)
            {
                // Hiển thị câu hỏi điền từ
                rdoAnswer1.Visible = rdoAnswer2.Visible = rdoAnswer3.Visible = rdoAnswer4.Visible = false;
                txtAnswer.Visible = true; // Hiển thị TextBox để người dùng điền đáp án
            }
            else
            {
                // Hiển thị câu hỏi trắc nghiệm
                rdoAnswer1.Text = question.AnswerChoices[0];
                rdoAnswer2.Text = question.AnswerChoices[1];
                rdoAnswer3.Text = question.AnswerChoices[2];
                rdoAnswer4.Text = question.AnswerChoices[3];

                rdoAnswer1.Visible = rdoAnswer2.Visible = rdoAnswer3.Visible = rdoAnswer4.Visible = true;
                txtAnswer.Visible = false;
            }

            lblResult.Text = ""; // Xóa kết quả trước khi hiển thị câu hỏi mới

            // Xóa lựa chọn cũ
            rdoAnswer1.Checked = rdoAnswer2.Checked = rdoAnswer3.Checked = rdoAnswer4.Checked = false;
            txtAnswer.Text = ""; // Xóa văn bản trong TextBox
        }

        // Kiểm tra câu trả lời sau khi người dùng chọn
        private void CheckAnswer()
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
                correctAnswersCount++;
            }
            else
            {
                lblResult.Text = "Sai! Đáp án đúng là: " + question.CorrectAnswer;
                lblResult.ForeColor = System.Drawing.Color.Red; // Hiển thị kết quả sai và đáp án đúng
                wrongAnswersCount++;
            }
        }

        // Lắng nghe sự kiện khi người dùng chọn một đáp án
        private void rdoAnswer_CheckedChanged(object sender, EventArgs e)
        {
            CheckAnswer(); // Kiểm tra đáp án khi người dùng chọn
        }

        // Lắng nghe sự kiện khi người dùng điền câu trả lời
        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            CheckAnswer(); // Kiểm tra đáp án khi người dùng điền
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn đáp án chưa
            if (!rdoAnswer1.Checked && !rdoAnswer2.Checked && !rdoAnswer3.Checked && !rdoAnswer4.Checked && string.IsNullOrEmpty(txtAnswer.Text.Trim()))
            {
                MessageBox.Show("Bạn cần chọn một đáp án hoặc điền câu trả lời trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không chuyển sang câu hỏi tiếp theo nếu chưa chọn đáp án
            }

            currentQuestionIndex++;
            if (currentQuestionIndex < filteredQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show($"Bài kiểm tra đã hoàn thành! Bạn đã trả lời đúng {correctAnswersCount} câu và sai {wrongAnswersCount} câu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correctAnswersCount = 0;
                wrongAnswersCount = 0;
                currentQuestionIndex = 0;
                LoadQuestion();
            }
        }

        // Sự kiện khi chọn kiểu câu hỏi
        private void grpMode_Enter(object sender, EventArgs e)
        {
            if (rdoMultipleChoice.Checked)
            {
                isMultipleChoiceSelected = true;
            }
            else if (rdoFillInTheBlank.Checked)
            {
                isMultipleChoiceSelected = false;
            }

            FilterQuestionsByTopics(); // Lọc câu hỏi khi thay đổi kiểu câu hỏi
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> AnswerChoices { get; set; }
        public string CorrectAnswer { get; set; }
        public string Topic { get; set; }
        public bool IsFillInTheBlank { get; set; } // Thêm thuộc tính kiểm tra loại câu hỏi
    }
}

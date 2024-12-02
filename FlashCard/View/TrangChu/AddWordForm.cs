using FlashCard.Entity;
using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class AddWordForm : Form
    {
        // Các thuộc tính để trả dữ liệu về Form chính
        public string Word { get; private set; }
        public string Meaning { get; private set; }
        public string Topic { get; private set; }

        public string Example { get; private set; }
        public string Difficulty { get; private set; }

        private List<Topic> lstTopic;
        private readonly int userId;
        private int topicId,vocaId;
        private readonly VocabularyDao vocabularyDao;

        public AddWordForm(int userId,int vocaId)
        {
            InitializeComponent();
            this.userId = userId;
            this.vocaId = vocaId;   
            this.vocabularyDao = new ImplVocabularyDao();

            InitializeValues();

            if (vocaId == 0)
            {
                lbCapNhapTu.Visible = false;
                lbThemTu.Visible = true;
            }
            else
            {
                lbCapNhapTu.Visible = true;
                lbThemTu.Visible = false;
            }


            // Gỡ bỏ sự kiện trước khi gán
            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }


        // Khởi tạo giá trị ban đầu
        private void InitializeValues()
        {

            // Lấy danh sách chủ đề từ cơ sở dữ liệu
            this.lstTopic = vocabularyDao.GetTopicByUserId(userId);
            if (lstTopic != null)
            {
                // Thiết lập giá trị cho combobox Topic
                comboxTopic.Items.Clear();
                foreach (Topic topic in lstTopic)
                {
                    comboxTopic.Items.Add(topic.TopicName);
                }

                if (comboxTopic.Items.Count > 0)
                {
                    comboxTopic.SelectedIndex = 0; // Chọn giá trị đầu tiên nếu danh sách không rỗng
                }


                // Thiết lập giá trị cho combobox Difficulty
                comboxDifficulty.Items.Clear();
                comboxDifficulty.Items.AddRange(new string[] { "easy", "medium", "hard" });

                // Đặt giá trị mặc định cho combobox
                comboxDifficulty.SelectedIndex = comboxDifficulty.Items.Count > 0 ? 0 : -1;
                comboxTopic.SelectedIndex = comboxTopic.Items.Count > 0 ? 0 : -1;
            }
            else
                throw NullReferenceException("khoog cos duw lieu tu topic tra ve");
            if (vocaId != 0)
            {
                lstTopic = vocabularyDao.GetTopicByUserId(userId);
                Vocabulary voca =   vocabularyDao.FindById(vocaId);
                txtExample.Text = voca.Example;
                txtMeaning.Text = voca.Meaning;
                txtWord.Text = voca.Word;
                comboxDifficulty.Text = voca.Difficulty;
                int topicid = voca.Topic_id;
                foreach(Topic topic in lstTopic)
                {
                    if (topicid == topic.Topic_id)
                    {
                        comboxTopic.Text = topic.TopicName;
                    }

                }

            }
            
                
            
           
        }

        private Exception NullReferenceException(string v)
        {
            throw new NotImplementedException();
        }


        // Xử lý khi nhấn nút Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường bắt buộc đã được điền chưa
            if (!string.IsNullOrWhiteSpace(txtWord.Text) &&
                !string.IsNullOrWhiteSpace(txtMeaning.Text) &&
                !string.IsNullOrWhiteSpace(comboxTopic.Text) &&
                !string.IsNullOrWhiteSpace(comboxDifficulty.Text))
            {
                // Gán giá trị từ các điều khiển giao diện vào biến
                Word = txtWord.Text.Trim();
                Meaning = txtMeaning.Text.Trim();
                Example = txtExample.Text.Trim();
                Topic = comboxTopic.Text.Trim();
                Difficulty = comboxDifficulty.Text.Trim();

                // Lấy topicId từ danh sách các chủ đề
                foreach (Topic topic in lstTopic)
                {
                    if (Topic == topic.TopicName)
                    {
                        topicId = topic.Topic_id;
                        break;
                    }
                }

                // Tạo đối tượng Vocabulary
                var vocab = new Vocabulary(vocaId, userId, Word, Meaning, Example, topicId, Difficulty);

                try
                {
                    if (vocaId == 0)
                    {
                        // Chế độ thêm mới
                        vocabularyDao.InsertVocab(vocab);

                        MessageBox.Show("Thêm từ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Chế độ cập nhật
                        vocab.VocabId = vocaId;
                        vocabularyDao.Update(vocab);

                        MessageBox.Show("Cập nhật từ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    DialogResult = DialogResult.OK; // Đóng form và trả kết quả
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị cảnh báo nếu thiếu thông tin
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Xử lý khi nhấn nút Hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Đóng form mà không lưu
        }

        private void txtExample_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

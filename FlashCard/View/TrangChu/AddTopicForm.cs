using FlashCard.Entity;
using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class AddTopicForm : Form
    {
        // Các thuộc tính để trả dữ liệu về Form chính
        public string TenTopic { get; private set; }
        public string Mota { get; private set; }


        private List<Topic> lstTopic;
        private readonly int userId;
        private int topicId;
        private readonly IServiceTopic  serviceTopic;

        public AddTopicForm(int userId, int topicId)
        {
            InitializeComponent();
            this.userId = userId;
            this.topicId = topicId;
            this.serviceTopic = new TopicService();

            InitializeValues();

            if (topicId == 0)
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

            
            if (topicId != 0)
            {
                Topic topic = serviceTopic.FindById(topicId);
               
                txtTopicName.Text = topic.TopicName;
                txtMoTa.Text =  topic.Description;

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
            if (!string.IsNullOrWhiteSpace(txtMoTa.Text) &&
                !string.IsNullOrWhiteSpace(txtTopicName.Text) 
                )
            {
                // Gán giá trị từ các điều khiển giao diện vào biến
                TenTopic = txtTopicName.Text.Trim();
                Mota = txtMoTa.Text.Trim();
               

                // Lấy topicId từ danh sách các chủ đề
             
                // Tạo đối tượng Vocabulary
                var topic = new Topic(TenTopic, Mota);

                try
                {
                    if (topicId == 0)
                    {
                        // Chế độ thêm mới
                        serviceTopic.InsertTopic(topic);

                        MessageBox.Show("Thêm từ mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Chế độ cập nhật
                        topic.Topic_id = topicId;
                        serviceTopic.UpdateTopic(topic);

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbThemTu_Click(object sender, EventArgs e)
        {

        }
    }
}

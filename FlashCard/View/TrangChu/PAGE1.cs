using FlashCard.Entity;
using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class PAGE1 : UserControl
    {
        private VocabularyDao vocabularyDao;
        private User user;
        public PAGE1(User UserLogin)
        {
          
            InitializeComponent();
            this.user = UserLogin;
            vocabularyDao = new ImplVocabularyDao();
            InitializeGridView(); // Cấu hình DataGridView
           

            LoadData();   // Nạp dữ liệu mẫu
        }

        // Cấu hình DataGridView
        private void InitializeGridView()
        {
            // Đặt thuộc tính cho DataGridView
            dataGridView1.ColumnCount = 4; // Số lượng cột chính (không tính icon)
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Word";
            dataGridView1.Columns[2].Name = "Meaning";
            dataGridView1.Columns[3].Name = "Topic";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = Color.LightBlue; // Màu nền của DataGridView
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12); // Thay đổi phông chữ

            dataGridView1.RowHeadersVisible = false; // Ẩn viền hàng bên trái
            dataGridView1.BorderStyle = BorderStyle.None; // Loại bỏ đường viền ngoài cùng

            // Thêm cột icon "Sửa"
            DataGridViewImageColumn editIconColumn = new DataGridViewImageColumn
            {
                Name = "EditIcon",
                HeaderText = "Sửa",
                Image = ConvertByteArrayToImage(FlashCard.View.TrangChu.Properties.Resources.EditIcon), // Chuyển byte[] thành Image
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };
            dataGridView1.Columns.Add(editIconColumn);

            // Thêm cột icon "Xóa"
            DataGridViewImageColumn deleteIconColumn = new DataGridViewImageColumn
            {
                Name = "DeleteIcon",
                HeaderText = "Xóa",
                Image = ConvertByteArrayToImage(Properties.Resources.DeleteIcon), // Chuyển byte[] thành Image
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 50
            };
            dataGridView1.Columns.Add(deleteIconColumn);

            // Gắn sự kiện xử lý nút
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Gắn sự kiện mouse hover
            dataGridView1.CellMouseEnter += DataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += DataGridView1_CellMouseLeave;
        }

        // Sự kiện khi di chuột vào ô chứa icon
        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không di chuột vào header
            {
                // Kiểm tra xem người dùng có đang di chuột vào cột icon không
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditIcon" || dataGridView1.Columns[e.ColumnIndex].Name == "DeleteIcon")
                {
                    dataGridView1.Cursor = Cursors.Hand; // Chuyển con trỏ thành hình tay
                }
            }
        }

        // Sự kiện khi di chuột ra khỏi ô chứa icon
        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Default; // Trả lại con trỏ về trạng thái mặc định
        }


        // load lai du lieu
        private void LoadData()
        {
            try
            {
                // Kiểm tra các đối tượng cần thiết đã được khởi tạo
                if (vocabularyDao == null)
                    throw new NullReferenceException("Đối tượng 'vocabularyDao' chưa được khởi tạo.");

                if (user == null || user.UserID == 0)
                    throw new NullReferenceException("Thông tin người dùng 'user' hoặc 'UserID' chưa hợp lệ.");

                // Xóa dữ liệu cũ trên DataGridView
                dataGridView1.Rows.Clear();

                // Lấy dữ liệu từ cơ sở dữ liệu
                List<object[]> list = vocabularyDao.LoadVocabularyData(user.UserID, "ASC", null, null);

                if (list == null || list.Count == 0)
                {
                    // Hiển thị thông báo nếu không có dữ liệu
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Thêm dữ liệu vào DataGridView
                foreach (var item in list)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2], item[3]); // vocab_id, word, meaning, topic_name.
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Lỗi tham chiếu null: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Xử lý sự kiện nhấn vào icon
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không nhấn vào header
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditIcon")
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    // Tạo instance của AddWordForm
                    using (AddWordForm addForm = new AddWordForm(user.UserID, id))//0 o day la turong hop add
                    {
                        // Hiển thị AddWordForm dưới dạng hộp thoại
                        if (addForm.ShowDialog() == DialogResult.OK)
                        {
                            // Lấy dữ liệu từ AddWordForm và thêm vào DataGridView
                            LoadData();
                        }
                    }
                    // Thêm logic sửa tại đây
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteIcon")
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    Vocabulary voca =vocabularyDao.FindById(id);
                    var confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa từ  {voca.Word}?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        vocabularyDao.DeleteById(id);
                        LoadData(); 
                    }
                }
            }
        }

        // Hàm chuyển byte[] thành Image
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

       

        // Xử lý sự kiện nhấn nút "ADD" để thêm từ mới
        private void ADD_Click(object sender, EventArgs e)
        {
            // Tạo instance của AddWordForm
            using (AddWordForm addForm = new AddWordForm(user.UserID,0))//0 o day la turong hop add
            {
                // Hiển thị AddWordForm dưới dạng hộp thoại
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ AddWordForm và thêm vào DataGridView
                    LoadData();              
                        }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    //// Lớp hỗ trợ hiển thị hộp thoại nhập liệu
    //public static class Prompt
    //{
    //    public static string ShowDialog(string text, string caption)
    //    {
    //        Form prompt = new Form()
    //        {
    //            Width = 300,
    //            Height = 150,
    //            FormBorderStyle = FormBorderStyle.FixedDialog,
    //            Text = caption,
    //            StartPosition = FormStartPosition.CenterScreen
    //        };
    //        Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 240 };
    //        TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 };
    //        Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };

    //        prompt.Controls.Add(textLabel);
    //        prompt.Controls.Add(textBox);
    //        prompt.Controls.Add(confirmation);
    //        prompt.AcceptButton = confirmation;

    //        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class QuanLyNguoiDung : UserControl
    {
        public QuanLyNguoiDung()
        {
            InitializeComponent();
            InitializeGridView(); // Cấu hình DataGridView
            LoadData();           // Nạp dữ liệu mẫu
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

        // Nạp dữ liệu mẫu vào DataGridView
        private void LoadData()
        {
            var data = new List<Vocabulary>
            {
                new Vocabulary { ID = "1", Word = "Apple", Meaning = "Quả táo", Topic = "Fruits" },
                new Vocabulary { ID = "2", Word = "Car", Meaning = "Xe hơi", Topic = "Vehicles" },
                new Vocabulary { ID = "3", Word = "House", Meaning = "Ngôi nhà", Topic = "Architecture" },
                new Vocabulary { ID = "4", Word = "Sun", Meaning = "Mặt trời", Topic = "Nature" }
            };

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.ID, item.Word, item.Meaning, item.Topic);
            }
        }

        // Xử lý sự kiện nhấn vào icon
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không nhấn vào header
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditIcon")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    MessageBox.Show($"Chỉnh sửa hàng với ID: {id}", "Thông báo");
                    // Thêm logic sửa tại đây
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteIcon")
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    var confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa ID {id}?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex); // Xóa hàng
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

        // Lớp dữ liệu mẫu
        private class Vocabulary
        {
            public string ID { get; set; }
            public string Word { get; set; }
            public string Meaning { get; set; }
            public string Topic { get; set; }
        }

        // Xử lý sự kiện nhấn nút "ADD" để thêm từ mới
        private void ADD_Click(object sender, EventArgs e)
        {
            // Tạo instance của AddWordForm
            using (AddWordForm addForm = new AddWordForm(21,0 ))
            {
                // Hiển thị AddWordForm dưới dạng hộp thoại
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ AddWordForm và thêm vào DataGridView
                  
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

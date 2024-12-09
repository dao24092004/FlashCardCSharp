using FlashCard.Entity;
using FlashCard.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class PAGE2 : UserControl
    {
        private List<UserControl> panels; // Danh sách các panel
        private int currentIndex;         // Chỉ số panel hiện tại
        private VocabularyDao vocabularyDao;
        private int userId = Form1.LoggedInUser.UserID;
        public PAGE2()
        {
            vocabularyDao = new ImplVocabularyDao();
            InitializeComponent();
            InitializeListPanel();
            LoadData();
            
        }
        private void InitializeListPanel()
        {
            panels = new List<UserControl>
            {
                new pnHinhAnh(),  // Panel hình ảnh
                new pnTuVung(),   // Panel từ vựng
                new pnNghiaTu()   // Panel nghĩa của từ
            };

            foreach (var panel in panels)
            {
                panel.Dock = DockStyle.Fill;
                panel.Visible = false; // Tất cả panel ban đầu ẩn
                panel.Click += Panel_Click; // Thêm sự kiện click
                panel.BackColor = Color.AliceBlue;
                this.Controls.Add(panel);
            }

            currentIndex = 0; // Hiển thị panel đầu tiên
            panels[currentIndex].Visible = true;
            dataGridView1.RowHeadersVisible = false; // Ẩn viền hàng bên trái
            dataGridView1.BorderStyle = BorderStyle.None; // Loại bỏ đường viền ngoài cùng

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

          
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            ShowNextPanel();
        }

        private void ShowNextPanel()
        {
            panels[currentIndex].Visible = false; // Ẩn panel hiện tại
            currentIndex = (currentIndex + 1) % panels.Count; // Chuyển sang panel tiếp theo
            panels[currentIndex].Visible = true;  // Hiển thị panel tiếp theo
        }




        private void LoadData()
        {
            try
            {
                // Kiểm tra các đối tượng cần thiết đã được khởi tạo
                if (vocabularyDao == null)
                    throw new NullReferenceException("Đối tượng 'vocabularyDao' chưa được khởi tạo.");

                if ( userId == 0)
                    throw new NullReferenceException("Thông tin người dùng 'user' hoặc 'UserID' chưa hợp lệ.");

                // Xóa dữ liệu cũ trên DataGridView
                dataGridView1.Rows.Clear();

                // Lấy dữ liệu từ cơ sở dữ liệu
                List<object[]> list = vocabularyDao.LoadVocabularyData(userId, "ASC", null, null);

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1_CellClick(sender, e, vocabularyDao);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e, VocabularyDao vocabularyDao)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count) // Đảm bảo hàng hợp lệ
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Kiểm tra xem hàng có dữ liệu hay không
                bool isRowEmpty = selectedRow.Cells.Cast<DataGridViewCell>()
                    .All(cell => cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()));

                if (isRowEmpty)
                {
                    // Hiển thị giá trị mặc định nếu hàng trống
                    //(panels[0] as pnHinhAnh)?.SetData("Chủ đề");
                    (panels[1] as pnTuVung)?.SetData("Từ vựng");
                    (panels[2] as pnNghiaTu)?.SetData("Nghĩa từ");
                }
                else
                {
                    // Lấy dữ liệu từ các ô, kiểm tra giá trị null hoặc rỗng
                    //string topic = selectedRow.Cells["Topic"]?.Value?.ToString() ?? "Chủ đề";
                    string word = selectedRow.Cells["Word"]?.Value?.ToString() ?? "Từ vựng";
                    string meaning = selectedRow.Cells["Meaning"]?.Value?.ToString() ?? "Nghĩa từ";

                    // Truyền dữ liệu đến các panel
                    //(panels[0] as pnHinhAnh)?.SetData(topic);
                    (panels[1] as pnTuVung)?.SetData(word);
                    (panels[2] as pnNghiaTu)?.SetData(meaning);
                }

                // Hiển thị panel đầu tiên sau khi dữ liệu được cập nhật
                ShowPanel(0);
            }

            if (e.RowIndex >= 0) // Đảm bảo không nhấn vào header
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditIcon")
                {
                    int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    // Tạo instance của AddWordForm
                    using (AddWordForm addForm = new AddWordForm(userId, id))//0 o day la turong hop add
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
                    Vocabulary voca = vocabularyDao.FindById(id);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ShowPanel(int index)
        {
            // Ẩn tất cả các panel
            foreach (var panel in panels)
            {
                panel.Visible = false;
            }

            // Hiển thị panel chỉ định
            if (index >= 0 && index < panels.Count)
            {
                panels[index].Visible = true;
                currentIndex = index;
            }
        }
    }
}

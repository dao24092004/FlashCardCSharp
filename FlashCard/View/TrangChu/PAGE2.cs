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
        public PAGE2()
        {
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

        // Lớp dữ liệu mẫu
        private class Vocabulary
        {
            public string ID { get; set; }
            public string Word { get; set; }
            public string Meaning { get; set; }
            public string Topic { get; set; }
        }

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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

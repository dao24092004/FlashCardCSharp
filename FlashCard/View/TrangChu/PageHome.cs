using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlashCard.View.TrangChu
{
    public partial class PageHome : UserControl
    {
        public PageHome()
        {
            InitializeComponent();
            InitializeGridView(); // Khởi tạo DataGridView
            LoadData();           // Nạp dữ liệu vào DataGridView
        }

        // Cấu hình DataGridView
        private void InitializeGridView()
        {
            // Đặt thuộc tính cho DataGridView
            dataGridView1.ColumnCount = 5; // Số lượng cột
            dataGridView1.Columns[0].Name = "ID";           // Tên cột
            dataGridView1.Columns[1].Name = "Từ Vựng";
            dataGridView1.Columns[2].Name = "Nghĩa của từ";
            dataGridView1.Columns[3].Name = "Chủ đề";
            dataGridView1.Columns[4].Name = "Thao tác";

            // Tuỳ chỉnh giao diện bảng
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false; // Không cho phép thêm hàng trực tiếp
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả hàng
        }

        // Nạp dữ liệu mẫu vào DataGridView
        private void LoadData()
        {
            // Tạo danh sách dữ liệu mẫu
            List<Vocabulary> vocabularies = new List<Vocabulary>
            {
                new Vocabulary { ID = "1", Word = "Apple", Meaning = "Quả táo", Topic = "Trái cây" },
                new Vocabulary { ID = "2", Word = "Car", Meaning = "Xe hơi", Topic = "Phương tiện" },
                new Vocabulary { ID = "3", Word = "House", Meaning = "Ngôi nhà", Topic = "Kiến trúc" },
                new Vocabulary { ID = "4", Word = "Sun", Meaning = "Mặt trời", Topic = "Thiên nhiên" }
            };

            // Thêm dữ liệu vào DataGridView
            foreach (var vocab in vocabularies)
            {
                dataGridView1.Rows.Add(vocab.ID, vocab.Word, vocab.Meaning, vocab.Topic, "Edit/Delete");
            }
        }

        // Lớp dữ liệu mẫu
        private class Vocabulary
        {
            public string ID { get; set; }
            public string Word { get; set; }      // Từ vựng
            public string Meaning { get; set; }  // Nghĩa của từ
            public string Topic { get; set; }    // Chủ đề
        }
    }
}

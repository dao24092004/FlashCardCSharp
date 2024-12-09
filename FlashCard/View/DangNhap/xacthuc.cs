using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlashCard.View.DangNhap
{
    public partial class xacthuc : Form
    {
        private string generatedCode = "123456"; // Mã mẫu ban đầu (có thể thay bằng mã động)

        public xacthuc()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
          

            // Gán sự kiện cho các ô TextBox
            AttachTextBoxEvents();
        }

        // Gắn sự kiện phóng to và thu nhỏ cho các TextBox
        private void AttachTextBoxEvents()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enter += TextBox_Enter;
                    textBox.Leave += TextBox_Leave;
                }
            }
        }

        // Hiệu ứng khi ô được chọn
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Font = new Font("Arial", 20, FontStyle.Bold); // Phóng to font chữ
            textBox.BackColor = Color.LightYellow; // Đổi màu nền
            textBox.Size = new Size(textBox.Width, 40); // Tăng chiều cao
        }

        // Hiệu ứng khi rời ô
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Font = new Font("Arial", 16, FontStyle.Bold); // Thu nhỏ font chữ
            textBox.BackColor = Color.White; // Khôi phục màu nền
            textBox.Size = new Size(textBox.Width, 30); // Giảm chiều cao
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredCode = $"{textBox1.Text}{textBox2.Text}{textBox3.Text}{textBox4.Text}{textBox5.Text}{textBox6.Text}";

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã xác thực.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredCode == generatedCode)
            {
                MessageBox.Show("Xác thực thành công! Chuyển đến trang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin dangNhap = new frmLogin();
                dangNhap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã xác thực không chính xác. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

                textBox1.Focus();
            }
        }

        private void btnGuiLaiMa_Click(object sender, EventArgs e)
        {
            generatedCode = GenerateNewCode();
            MessageBox.Show($"Mã xác thực mới đã được gửi: {generatedCode}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SendCodeToUser(generatedCode);
        }

        private string GenerateNewCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendCodeToUser(string code)
        {
            Console.WriteLine($"Mã xác thực đã gửi: {code}");
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

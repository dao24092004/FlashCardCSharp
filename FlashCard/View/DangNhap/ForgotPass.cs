using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard.View.DangNhap
{
    public partial class ForgotPass : UserControl
    {
        public event Action OnBackToLogin;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void setNull()
        {
            txtFgEmail.Text = null;
            txtFgPass.Text = null;
            txtFgCode.Text = null;
            errFgEmail.Visible = false;
            errFgPass.Visible = false;
            errFgCode.Visible = false;
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            OnBackToLogin?.Invoke();
            this.Dispose();
        }

        private void SecurityCode_Click(object sender, EventArgs e)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Các ký tự có thể
            Random random = new Random(); // Khởi tạo đối tượng Random
            string randomString = ""; // Chuỗi ngẫu nhiên

            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(characters.Length); // Chọn ngẫu nhiên một chỉ số trong dãy characters
                randomString += characters[index]; // Thêm ký tự vào chuỗi
            }

            txtFgCode.Text = randomString; // Gán chuỗi ngẫu nhiên vào TextBox
        }
        public static bool checkEmail(string email)
        {
            // Biểu thức chính quy cho định dạng email
            string emailRegex = @"^[a-zA-Z][a-zA-Z0-9._]*@gmail\.com$";

            // Kiểm tra email với biểu thức chính quy
            return Regex.IsMatch(email, emailRegex);
        }

        private void SIGNIN_Click(object sender, EventArgs e)
        {
            string email = txtFgEmail.Text;
            string pass = txtFgPass.Text;
            string user = txtFgCode.Text;
            bool error = false;
            if (string.IsNullOrEmpty(email))
            {
                errFgEmail.Visible = true;
                errFgEmail.Text = "Vui lòng nhập email";
                error = true;
            }
            else if (!checkEmail(email))
            {
                errFgEmail.Visible = true;
                errFgEmail.Text = "Email sai định dạng";
                error = true;
            }
            else
            {
                errFgEmail.Visible = false;
            }
            if (string.IsNullOrEmpty(user))
            {
                errFgCode.Visible = true;
                errFgCode.Text = "Vui lòng nhập Security Code";
                error = true;
            }
            else
            {
                errFgCode.Visible = false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                errFgPass.Visible = true;
                errFgPass.Text = "Vui lòng nhập password";
                error = true;
            }
            else
            {
                errFgPass.Visible = false;
            }
            if (error) { return; }
        }
    }
}

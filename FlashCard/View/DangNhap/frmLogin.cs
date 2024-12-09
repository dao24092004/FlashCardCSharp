using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Text.RegularExpressions;
using FlashCard.Controller;
using FlashCard.Entity;

namespace FlashCard.View.DangNhap
{
    public partial class frmLogin : Form
    {
        private readonly LoginController _loginController;
        public User user;

       



        public frmLogin()
        {
            InitializeComponent();
            _loginController = new LoginController();
            PnLogin.BringToFront();
        }

        private void setNull()
        {
            txtLoginEmail.Text = null;
            txtLoginPass.Text = null;
            remember.Checked = false;
            errLgEmail.Visible = false;
            errLgPass.Visible = false;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public User getUser() 
            {
                
                return this.user;
            }

        private void SIGNIN_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPass.Text.Trim();


            

            // Kiểm tra trường email có trống hay không
            if (string.IsNullOrEmpty(email))
            {
                errLgEmail.Text = "Vui lòng nhập email!";
                errLgEmail.Visible = true;
                txtLoginEmail.Focus();
                return;
            }
            else
            {
                errLgEmail.Visible = false;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                errLgEmail.Text = "Email không hợp lệ!";
                errLgEmail.Visible = true;
                txtLoginEmail.Focus();
                return;
            }
            else
            {
                errLgEmail.Visible = false;
            }

            // Kiểm tra trường mật khẩu có trống hay không
            if (string.IsNullOrEmpty(password))
            {
                errLgPass.Text = "Vui lòng nhập mật khẩu!";
                errLgPass.Visible = true;
                txtLoginPass.Focus();
                return;
            }
            else
            {
                errLgPass.Visible = false;
            }

            // Gửi thông tin đến LoginController
            User user = new User(email, password);

            // Sử dụng kết quả trả về từ LoginController
            User loggedInUser = _loginController.Login(user);
            if (loggedInUser != null)
            {
                this.user = loggedInUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errLgPass.Text = "Đăng nhập thất bại. Sai email hoặc mật khẩu.";
                errLgPass.Visible = true;
            }
        }





        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Register registerControl = new Register();
            registerControl.Location = PnLogin.Location;
            registerControl.OnBackToLogin += () =>
            {
                PnLogin.BringToFront();
            };

            this.Controls.Add(registerControl);
            registerControl.BringToFront();
            setNull();
        }

        private void ForgotPass_Click(object sender, MouseEventArgs e)
        {
            ForgotPass forgotPassControl = new ForgotPass();
            forgotPassControl.Location = PnLogin.Location;
            forgotPassControl.OnBackToLogin += () =>
            {
                PnLogin.BringToFront();
            };

            this.Controls.Add(forgotPassControl);
            forgotPassControl.BringToFront();
            setNull();
        }
    }
}
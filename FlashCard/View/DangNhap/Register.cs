using FlashCard.Controller;
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
using FlashCard.Controller;

namespace FlashCard.View.DangNhap
{
    public partial class Register : UserControl
    {
        public event Action OnBackToLogin;
        private RegisterController _registerController;

        public Register()
        {
            InitializeComponent();
            _registerController = new RegisterController(); // Initialize the controller
        }

        private void setNull()
        {
            txtRsEmail.Text = null;
            txtRsPass.Text = null;
            txtRsUsername.Text = null;
            errRsEmail.Visible = false;
            errRsPass.Visible = false;
            errRsUsername.Visible = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
            setNull();
            OnBackToLogin?.Invoke();
            this.Dispose();
        }

        public static bool checkEmail(string email)
        {
            // Regular expression for email validation
            string emailRegex = @"^[a-zA-Z][a-zA-Z0-9._]*@gmail\.com$";
            return Regex.IsMatch(email, emailRegex);
        }

        private void SIGNIN_Click(object sender, EventArgs e)
        {
            string email = txtRsEmail.Text.Trim();
            string pass = txtRsPass.Text.Trim();
            string userName = txtRsUsername.Text.Trim();
            bool error = false;

            // Validate inputs
            if (string.IsNullOrEmpty(email))
            {
                errRsEmail.Visible = true;
                errRsEmail.Text = "Vui lòng nhập email";
                error = true;
            }
            else if (!checkEmail(email))
            {
                errRsEmail.Visible = true;
                errRsEmail.Text = "Email sai định dạng";
                error = true;
            }
            else
            {
                errRsEmail.Visible = false;
            }

            if (string.IsNullOrEmpty(userName))
            {
                errRsUsername.Visible = true;
                errRsUsername.Text = "Vui lòng nhập Username";
                error = true;
            }
            else
            {
                errRsUsername.Visible = false;
            }

            if (string.IsNullOrEmpty(pass))
            {
                errRsPass.Visible = true;
                errRsPass.Text = "Vui lòng nhập password";
                error = true;
            }
            else
            {
                errRsPass.Visible = false;
            }

            if (error) return;

            // Call the controller to handle registration
            string errorMessage;
            if (_registerController.RegisterUser(userName, email, pass, out errorMessage))
            {
                MessageBox.Show("Đăng ký thành công! Vui lòng kiểm tra email để xác minh tài khoản.");
                setNull();
                OnBackToLogin?.Invoke();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCard.Model;
using FlashCard.Entity;

namespace FlashCard.Controller
{
    internal class RegisterController
    {
        private readonly ImpUserDao _userDao;
        private User Register_User;

        public RegisterController()
        {
            _userDao = new ImpUserDao();
        }

        public bool RegisterUser(string username, string email, string password, out string errorMessage)
        {
            errorMessage = string.Empty;
            this.Register_User = new User();
            // Kiểm tra dữ liệu đầu vào
            if (_userDao.CheckDuplicateEmail(email))
            {
                errorMessage = "Email đã tồn tại trong hệ thống.";
                return false;
            }

            if (_userDao.CheckDuplicateUser(username))
            {
                errorMessage = "Username đã tồn tại trong hệ thống.";
                return false;
            }

            try
            {

                this.Register_User.UserName = username;
                this.Register_User.Email = email;
                this.Register_User.Password = password;
                this.Register_User.VerifyCode = "123332";
                

                _userDao.InsertUser(Register_User);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Đã xảy ra lỗi khi đăng ký: {ex.Message}";
                return false;
            }
        }
    }
}

using FlashCard.Entity;
using FlashCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Controller
{
    internal class LoginController
    {
        private User user;
        private UserDao userDao;
        

        public LoginController()
        {
            this.userDao  = new ImpUserDao();
        }

        public User Login(User checkUser)
        {

            this.user = userDao.Login(checkUser);

            return user;
        }

    }
}

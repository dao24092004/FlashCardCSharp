using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Entity
{
    public class User
    {
        private int userID;
        private String userName;
        private String email;
        private String password;
        private String verifyCode;
        private String role;

        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string VerifyCode { get => verifyCode; set => verifyCode = value; }
        public string Role { get => role; set => role = value; }

        public User(int userID, string userName, string email, string password, string verifyCode, string role)
        {
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.verifyCode = verifyCode;
            this.role = role;
        }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public User()
        {
        }




    }

}

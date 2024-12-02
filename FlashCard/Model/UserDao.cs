using FlashCard.Entity;
using System.Collections.Generic;

namespace FlashCard.Model
{
    internal interface UserDao
    {
        User Login(User login);
        void InsertUser(User user);
        bool CheckDuplicateUser(string username);
        bool CheckDuplicateEmail(string email);
        bool VerifyCodeWithUser(int userID, string code);
        void DoneVerify(int userID);
        List<User> GetAllUsers(); // Tùy chọn
    }
}

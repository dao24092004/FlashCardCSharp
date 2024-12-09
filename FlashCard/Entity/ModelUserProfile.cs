using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Entity
{
    internal class ModelUserProfile
    {
        public string FullName { get; set; } // Tên đầy đủ của người dùng
        public string Phone { get; set; }    // Số điện thoại của người dùng
        public string Address { get; set; } // Địa chỉ của người dùng
        public string Bio { get; set; }     // Mô tả cá nhân của người dùng
        public string ProfilePicture { get; set; } // Ảnh đại diện của người dùng
        public DateTime DOB { get; set; }
        // Phương thức khởi tạo không tham số (mặc định)
        public ModelUserProfile()
        {
        }

        // Phương thức khởi tạo có tham số để tiện khởi tạo giá trị
        public ModelUserProfile(string fullName, string phone, string address, string bio, string profilePicture)
        {
            FullName = fullName;
            Phone = phone;
            Address = address;
            Bio = bio;
            ProfilePicture = profilePicture;
        }

        public ModelUserProfile(string fullName, string phone, string address, string bio, string profilePicture, DateTime dOB)
        {
            FullName = fullName;
            Phone = phone;
            Address = address;
            Bio = bio;
            ProfilePicture = profilePicture;
            DOB = dOB;
        }
        // Phương thức để hiển thị thông tin của người dùng (tuỳ chọn)
        public override string ToString()
        {
            return $"FullName: {FullName}, Phone: {Phone}, Address: {Address}, Bio: {Bio}, ProfilePicture: {ProfilePicture}";
        }
    }

}

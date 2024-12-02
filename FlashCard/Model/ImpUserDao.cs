using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using FlashCard.Connection;
using FlashCard.Entity;
using Oracle.ManagedDataAccess.Client;
using SHA3.Net;



namespace FlashCard.Model
{
    internal class ImpUserDao : UserDao
    {
        private readonly OracleConnection _connection;

        public ImpUserDao()
        {
            _connection = DatabaseConnection.GetInstance().GetConnection();
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Database connection established successfully.");
            }
            else
            {
                Console.WriteLine("Failed to establish database connection.");
            }
        }

        // Hàm băm SHA3-256
        private static string GenerateSHA3Hash(string input)
        {
            var hashBytes = Sha3.Sha3256().ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }

        // Đăng nhập
        public User Login(User login)
        {
            User data = null;
            string email = login.Email.Trim();
            string password = login.Password.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Email và mật khẩu không được để trống.");
                return null;
            }

            Console.WriteLine($"Đang thực hiện đăng nhập với Email: {email}");

            string sql = "SELECT USER_ID, USERNAME, EMAIL, ROLE, VERIFYCODE FROM tbl_user WHERE EMAIL = :email AND PASSWORD = :password";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":email", email);
                    command.Parameters.Add(":password", GenerateSHA3Hash(password));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("USER_ID"));
                            string userName = reader.GetString(reader.GetOrdinal("USERNAME"));
                            string role = reader.GetString(reader.GetOrdinal("ROLE"));
                            string verifyCode = reader.GetString(reader.GetOrdinal("VERIFYCODE"));

                            data = new User(userID, userName, email, password, verifyCode, role);
                            Console.WriteLine($"Đã tìm thấy người dùng: {email}, Vai trò: {role}");

                            Console.WriteLine(role.Equals("admin", StringComparison.OrdinalIgnoreCase)
                                ? "Đăng nhập với vai trò admin."
                                : "Đăng nhập với vai trò người dùng.");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy người dùng với thông tin đăng nhập đã cung cấp.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi SQL trong quá trình đăng nhập: {ex.Message}");
            }

            return data;
        }

        // Thêm người dùng
        public void InsertUser(User user)
        {
            string sql = "INSERT INTO tbl_user (USERNAME, EMAIL, PASSWORD, VERIFYCODE) VALUES (:username, :email, :password, :verifyCode)";
            string verifyCode = GenerateVerifyCode();

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":username", user.UserName);
                    command.Parameters.Add(":email", user.Email);
                    command.Parameters.Add(":password", GenerateSHA3Hash(user.Password));
                    command.Parameters.Add(":verifyCode", verifyCode);

                    command.ExecuteNonQuery();
                    user.VerifyCode = verifyCode;

                    Console.WriteLine($"Thêm người dùng thành công: {user.UserName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm người dùng: {ex.Message}");
            }
        }

        // Tạo mã xác minh
        private string GenerateVerifyCode()
        {
            var random = new Random();
            string code;

            do
            {
                code = random.Next(0, 1000000).ToString("D6");
            } while (CheckDuplicateCode(code));

            return code;
        }

        // Kiểm tra mã xác minh trùng lặp
        private bool CheckDuplicateCode(string code)
        {
            string sql = "SELECT USER_ID FROM tbl_user WHERE VERIFYCODE = :code";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":code", code);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra mã trùng lặp: {ex.Message}");
                return true;
            }
        }

        // Kiểm tra trùng lặp tên người dùng
        public bool CheckDuplicateUser(string username)
        {
            string sql = "SELECT USER_ID FROM tbl_user WHERE USERNAME = :username AND STATUS = 'active'";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra trùng lặp tên người dùng: {ex.Message}");
                return true;
            }
        }

        // Kiểm tra trùng lặp email
        public bool CheckDuplicateEmail(string email)
        {
            string sql = "SELECT USER_ID FROM tbl_user WHERE EMAIL = :email AND STATUS = 'active'";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":email", email);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra email trùng lặp: {ex.Message}");
                return true;
            }
        }

        // Xác minh mã
        public bool VerifyCodeWithUser(int userID, string code)
        {
            string sql = "SELECT USER_ID FROM tbl_user WHERE USER_ID = :userID AND VERIFYCODE = :code";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":userID", userID);
                    command.Parameters.Add(":code", code);

                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xác minh mã: {ex.Message}");
                return false;
            }
        }

        // Hoàn tất xác minh
        public void DoneVerify(int userID)
        {
            string sql = "UPDATE tbl_user SET VERIFYCODE = '', STATUS = 'active' WHERE USER_ID = :userID";

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                {
                    command.Parameters.Add(":userID", userID);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"Xác minh hoàn tất cho UserID: {userID}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hoàn tất xác minh: {ex.Message}");
            }
        }

        // Lấy danh sách tất cả người dùng (tuỳ chọn)
        public List<User> GetAllUsers()
        {
            string sql = "SELECT USER_ID, USERNAME, EMAIL, ROLE FROM tbl_user";
            var users = new List<User>();

            try
            {
                using (var command = new OracleCommand(sql, _connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User(
                            reader.GetInt32(reader.GetOrdinal("USER_ID")),
                            reader.GetString(reader.GetOrdinal("USERNAME")),
                            reader.GetString(reader.GetOrdinal("EMAIL")),
                            string.Empty,
                            string.Empty,
                            reader.GetString(reader.GetOrdinal("ROLE"))
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách người dùng: {ex.Message}");
            }

            return users;
        }

    }
}

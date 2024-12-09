using System;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace FlashCard.Connection
{
    internal class DatabaseConnection
    {
        // Thông tin kết nối Oracle
        private static readonly string Host = "localhost";    // Địa chỉ máy chủ
        private static readonly string Port = "1521";         // Cổng mặc định của Oracle
        private static readonly string ServiceName = "flashcard";  // Oracle Service Name hoặc SID
        private static readonly string Username = "system";   // Tài khoản Oracle
        private static readonly string Password = "1234$"; // Mật khẩu Oracle

        private static readonly string ConnectionString =
            $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={Host})(PORT={Port})))" +
            $"(CONNECT_DATA=(SERVICE_NAME={ServiceName})));User Id={Username};Password={Password};";

        // Singleton instance
        private static DatabaseConnection _instance;
        private OracleConnection _connection;

        // Constructor riêng để ngăn tạo trực tiếp
        private DatabaseConnection()
        {
            _connection = new OracleConnection(ConnectionString);
        }

        // Lấy instance của lớp (Singleton)
        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseConnection();
            }
            return _instance;
        }

        // Kết nối đến cơ sở dữ liệu
        public OracleConnection GetConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
                {
                    _connection.Open();
                    Console.WriteLine("Kết nối Oracle thành công.");
                }
            }
            catch (OracleException ex)
            {
                string errorMessage = $"Lỗi khi kết nối Oracle: {ex.Message} \nStackTrace: {ex.StackTrace}";
                Console.WriteLine(errorMessage);

                // Ghi lại lỗi vào file log để dễ dàng kiểm tra
                File.WriteAllText("OracleConnectionError.log", errorMessage);
                throw new InvalidOperationException("Không thể kết nối đến cơ sở dữ liệu Oracle.", ex);
            }

            return _connection;
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                    Console.WriteLine("Kết nối Oracle đã được đóng.");
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }
    }
}

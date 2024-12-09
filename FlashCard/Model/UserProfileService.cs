using System;
using System.Data;
using FlashCard.Connection;
using FlashCard.Entity;
using Oracle.ManagedDataAccess.Client;

namespace FlashCard.Model
{
    internal class UserProfileService : IUserProfileService
    {
        private readonly OracleConnection _connection;

        public UserProfileService()
        {
            _connection = DatabaseConnection.GetInstance().GetConnection();

            if (_connection == null)
            {
                throw new InvalidOperationException("Failed to create a database connection.");
            }

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            Console.WriteLine("Database connection established successfully.");
        }

        public ModelUserProfile GetAllById(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("Invalid user ID.", nameof(userId));
            }

            ModelUserProfile data = null;
            const string sql = "SELECT * FROM tbl_user_profile WHERE user_id = :UserId";

            try
            {
                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(new OracleParameter(":UserId", OracleDbType.Int32) { Value = userId });

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data = new ModelUserProfile
                    {
                        FullName = reader["full_name"]?.ToString(),
                        Phone = reader["phone"]?.ToString(),
                        Address = reader["address"]?.ToString(),
                        Bio = reader["bio"]?.ToString(),
                        ProfilePicture = reader["profile_picture"]?.ToString()
                    };
                }
            }
            catch (OracleException oracleEx)
            {
                Console.WriteLine($"Oracle Error retrieving user profile: Code {oracleEx.Number}, Message: {oracleEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error retrieving user profile: {ex.Message}");
            }

            return data;
        }

        public bool SaveProfile(ModelUserProfile modelUserProfile, int userId)
        {
            if (modelUserProfile == null)
            {
                throw new ArgumentNullException(nameof(modelUserProfile), "Profile data cannot be null.");
            }

            const string sql = @"
UPDATE tbl_user_profile 
SET full_name = :FullName, 
    phone = :Phone, 
    address = :Address, 
    bio = :Bio, 
    profile_picture = :ProfilePicture 
WHERE user_id = :UserId";

            try
            {
                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(new OracleParameter(":FullName", OracleDbType.NVarchar2)
                {
                    Value = string.IsNullOrEmpty(modelUserProfile.FullName) ? DBNull.Value : modelUserProfile.FullName
                });

                cmd.Parameters.Add(new OracleParameter(":Phone", OracleDbType.Varchar2) { Value = modelUserProfile.Phone ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":Address", OracleDbType.NVarchar2) { Value = modelUserProfile.Address ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":Bio", OracleDbType.NVarchar2) { Value = modelUserProfile.Bio ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":ProfilePicture", OracleDbType.Varchar2) { Value = modelUserProfile.ProfilePicture ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":UserId", OracleDbType.Int32) { Value = userId });

                Console.WriteLine("Executing query to save profile...");
                Console.WriteLine($"FullName={modelUserProfile.FullName}, Phone={modelUserProfile.Phone}, Address={modelUserProfile.Address}, Bio={modelUserProfile.Bio}, ProfilePicture={modelUserProfile.ProfilePicture}");
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Profile updated successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("No profile was updated. Check the user ID.");
                    return false;
                }
            }
            catch (OracleException oracleEx)
            {
                Console.WriteLine($"Oracle Error: {oracleEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false; // Luôn trả về false nếu có ngoại lệ xảy ra
        }

    }
}

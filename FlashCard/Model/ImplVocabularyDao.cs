using FlashCard.Connection;
using FlashCard.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Model
{
    
    public class ImplVocabularyDao : VocabularyDao
    {
        private readonly OracleConnection _connection;

        public ImplVocabularyDao()
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

        public List<object[]> LoadVocabularyData(int userId, string sortByWord, string topicName, string difficulty)
        {
            var data = new List<object[]>();
            var whereClause = "WHERE v.user_id = :UserId ";

            if (!string.IsNullOrEmpty(topicName))
            {
                whereClause += "AND t.topic_name = :TopicName ";
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                whereClause += "AND v.difficulty = :Difficulty ";
            }

            var orderByClause = !string.IsNullOrEmpty(sortByWord)
                ? $"ORDER BY v.word {sortByWord}"
                : "ORDER BY v.word ASC";

            var sql = $@"
    SELECT v.vocab_id, v.word, v.meaning, v.topic_id, t.topic_name, v.difficulty
    FROM tbl_Vocabulary v
    INNER JOIN tbl_Topic t ON v.topic_id = t.topic_id
    {whereClause}
    {orderByClause}";

            try
            {
                // Kiểm tra trạng thái kết nối
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(":UserId", OracleDbType.Int32).Value = userId;

                if (!string.IsNullOrEmpty(topicName))
                {
                    cmd.Parameters.Add(":TopicName", OracleDbType.Varchar2).Value = topicName;
                }

                if (!string.IsNullOrEmpty(difficulty))
                {
                    cmd.Parameters.Add(":Difficulty", OracleDbType.Varchar2).Value = difficulty;
                }

                // Debug thông tin truy vấn và tham số
                Console.WriteLine("Generated SQL Query:");
                Console.WriteLine(sql);
                foreach (OracleParameter param in cmd.Parameters)
                {
                    Console.WriteLine($"Param Name: {param.ParameterName}, Value: {param.Value}");
                }

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new object[]
                    {
                reader.GetInt32(0), // vocab_id
                reader.GetString(1), // word
                reader.GetString(2), // meaning
                reader.GetInt32(3), // topic_id
                reader.GetString(4), // topic_name
                reader.GetString(5)  // difficulty
                    });
                }
            }
            catch (OracleException ex)
            {
                // Log chi tiết lỗi từ Oracle
                Console.Error.WriteLine($"Oracle Error: {ex.Message}");
                Console.Error.WriteLine($"SQL State: {ex.Data}");
                throw new Exception("Lỗi khi thực thi truy vấn LoadVocabularyData", ex);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"General Error: {ex.Message}");
                Console.Error.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }
            finally
            {
                // Đóng kết nối chỉ khi cần thiết
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return data;
        }

        void VocabularyDao.InsertVocab(Vocabulary modelVocabulary)
        {
            const string sql = @"
        INSERT INTO tbl_Vocabulary (USER_ID, WORD, meaning, example, topic_id, difficulty)
        VALUES (:UserId, :Word, :Meaning, :Example, :TopicId, :Difficulty)";

            try
            {
                // Đảm bảo mở và đóng kết nối tự động
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using var cmd = new OracleCommand(sql, _connection);

                // Thêm tham số
                cmd.Parameters.Add(new OracleParameter(":UserId", OracleDbType.Int32) { Value = modelVocabulary.UserId });
                cmd.Parameters.Add(new OracleParameter(":Word", OracleDbType.Varchar2) { Value = modelVocabulary.Word });
                cmd.Parameters.Add(new OracleParameter(":Meaning", OracleDbType.Varchar2) { Value = modelVocabulary.Meaning });
                cmd.Parameters.Add(new OracleParameter(":Example", OracleDbType.Varchar2) { Value = modelVocabulary.Example ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":TopicId", OracleDbType.Int32) { Value = modelVocabulary.Topic_id });
                cmd.Parameters.Add(new OracleParameter(":Difficulty", OracleDbType.Varchar2) { Value = modelVocabulary.Difficulty });

                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.Error.WriteLine($"Oracle Error: {ex.Message}");
                throw new Exception("Error inserting vocabulary", ex);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"General Error: {ex.Message}");
                throw;
            }
            finally
            {
                // Đảm bảo luôn đóng kết nối
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }




        public bool DeleteById(int vocabularyId)
        {
            const string sql = "DELETE FROM tbl_Vocabulary WHERE vocab_id = :VocabId";

            try
            {
                // Kiểm tra và mở kết nối nếu cần
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(new OracleParameter(":VocabId", OracleDbType.Int32) { Value = vocabularyId });

                // Thực thi câu lệnh và kiểm tra số dòng bị ảnh hưởng
                int rowsAffected = cmd.ExecuteNonQuery();

                // Trả về true nếu có ít nhất một dòng bị ảnh hưởng
                return rowsAffected > 0;
            }
            catch (OracleException ex)
            {
                // Ghi log lỗi Oracle
                Console.Error.WriteLine($"Oracle Error: {ex.Message}");
                throw new Exception("Error deleting vocabulary from the database.", ex);
            }
            catch (Exception ex)
            {
                // Ghi log lỗi chung
                Console.Error.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }


        void VocabularyDao.Update(Vocabulary modelVocabulary)
        {
            const string sql = @"
        UPDATE tbl_Vocabulary
        SET user_id = :UserId, word = :Word, meaning = :Meaning, example = :Example,
            topic_id = :TopicId, difficulty = :Difficulty
        WHERE vocab_id = :VocabId";

            try
            {
                // Kiểm tra và mở kết nối nếu cần
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using var cmd = new OracleCommand(sql, _connection);

                // Thêm tham số với tên rõ ràng
                cmd.Parameters.Add(new OracleParameter(":UserId", OracleDbType.Int32) { Value = modelVocabulary.UserId });
                cmd.Parameters.Add(new OracleParameter(":Word", OracleDbType.Varchar2) { Value = modelVocabulary.Word });
                cmd.Parameters.Add(new OracleParameter(":Meaning", OracleDbType.Varchar2) { Value = modelVocabulary.Meaning });
                cmd.Parameters.Add(new OracleParameter(":Example", OracleDbType.Varchar2) { Value = modelVocabulary.Example ?? (object)DBNull.Value });
                cmd.Parameters.Add(new OracleParameter(":TopicId", OracleDbType.Int32) { Value = modelVocabulary.Topic_id });
                cmd.Parameters.Add(new OracleParameter(":Difficulty", OracleDbType.Varchar2) { Value = modelVocabulary.Difficulty });
                cmd.Parameters.Add(new OracleParameter(":VocabId", OracleDbType.Int32) { Value = modelVocabulary.VocabId });

                // Thực thi câu lệnh
                int rowsAffected = cmd.ExecuteNonQuery();

                // Kiểm tra kết quả
                if (rowsAffected == 0)
                {
                    Console.WriteLine("No vocabulary was updated. Please check the vocab_id.");
                }
            }
            catch (OracleException ex)
            {
                Console.Error.WriteLine($"Oracle Error: {ex.Message}");
                throw new Exception("Error updating vocabulary in the database.", ex);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        Vocabulary VocabularyDao.FindById(int vocabId)
        {
            Vocabulary vocab = null;
            const string sql = @"
        SELECT vocab_id, user_id, word, meaning, example, topic_id, difficulty
        FROM tbl_Vocabulary
        WHERE vocab_id = :VocabId";

            try
            {
                // Kiểm tra trạng thái kết nối trước khi sử dụng
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(new OracleParameter(":VocabId", OracleDbType.Int32) { Value = vocabId });

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    vocab = new Vocabulary
                    {
                        VocabId = reader.GetInt32(reader.GetOrdinal("vocab_id")),
                        UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                        Word = reader.GetString(reader.GetOrdinal("word")),
                        Meaning = reader.GetString(reader.GetOrdinal("meaning")),
                        Example = reader.IsDBNull(reader.GetOrdinal("example")) ? null : reader.GetString(reader.GetOrdinal("example")),
                        Topic_id = reader.GetInt32(reader.GetOrdinal("topic_id")),
                        Difficulty = reader.IsDBNull(reader.GetOrdinal("difficulty")) ? null : reader.GetString(reader.GetOrdinal("difficulty"))
                    };
                }
            }
            catch (OracleException ex)
            {
                Console.Error.WriteLine($"Oracle error in FindById: {ex.Message}");
                throw new Exception("Database error occurred while finding vocabulary by ID", ex);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Unexpected error in FindById: {ex.Message}");
                throw;
            }
            finally
            {
                // Đảm bảo đóng kết nối chỉ khi cần thiết
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return vocab;
        }




        List<Topic> VocabularyDao.GetTopicByUserId(int userId)
        {
            HashSet<int> uniqueTopicIds = new HashSet<int>();
            List<Topic> data = new List<Topic>();
            string sql = @"
SELECT t.topic_name, t.topic_id, t.description
FROM tbl_Topic t
LEFT JOIN tbl_Vocabulary v
ON t.topic_id = v.topic_id AND v.user_id = :UserId
WHERE t.user_id = :UserId";

            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }

                using (OracleCommand cmd = new OracleCommand(sql, _connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":UserId", userId));

                    Console.WriteLine("Executing Query: " + sql);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int topicId = reader.GetInt32(reader.GetOrdinal("topic_id"));

                            // Chỉ thêm nếu topic_id chưa tồn tại
                            if (!uniqueTopicIds.Contains(topicId))
                            {
                                uniqueTopicIds.Add(topicId);

                                Topic topic = new Topic
                                {
                                    Topic_id = topicId,
                                    TopicName = reader.GetString(reader.GetOrdinal("topic_name")),
                                    Description = reader.IsDBNull(reader.GetOrdinal("description"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("description"))
                                };

                                data.Add(topic);
                                Console.WriteLine("Loaded Topic: " + topic.TopicName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

            return data;
        }




        public List<object[]> FindVocabularyByKey(int userId, string name)
        {
            var data = new List<object[]>();
            var sql = @"
            SELECT v.vocab_id, v.word, v.meaning, t.topic_name
            FROM tbl_Vocabulary v
            INNER JOIN tbl_Topic t ON v.topic_id = t.topic_id
            WHERE v.user_id = @UserId AND v.word LIKE @Name";

            try
            {
                _connection.Open();
                using var cmd = new OracleCommand(sql, _connection);
                cmd.Parameters.Add(":UserId", userId);
                cmd.Parameters.Add(":Name", $"%{name}%");

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new object[]
                    {
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error finding vocabulary by key: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }

            return data;
        }

       
    }
}

using FlashCard.Connection;
using FlashCard.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace FlashCard.Model
{
    public class TopicService : IServiceTopic, IDisposable
    {
        private readonly OracleConnection _connection;

        public TopicService()
        {
            _connection = DatabaseConnection.GetInstance().GetConnection();

            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                Console.WriteLine("Failed to establish database connection.");
            }
            else
            {
                Console.WriteLine("Database connection established successfully.");
            }
        }

        public HashSet<object[]> GetAll(int userId)
        {
            var data = new HashSet<object[]>();
            string sql = @"
            SELECT t.topic_id, t.topic_name, COUNT(v.vocab_id) AS word_count
            FROM tbl_Topic t
            LEFT JOIN tbl_Vocabulary v ON v.topic_id = t.topic_id AND v.user_id = :UserId
            WHERE t.user_id = :UserId
            GROUP BY t.topic_id, t.topic_name";

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":UserId", userId));
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(new object[]
                        {
                            reader.GetInt32(0), // topic_id
                            reader.GetString(1), // topic_name
                            reader.GetInt32(2)  // word_count
                        });
                    }
                }
            }

            return data;
        }

        public void InsertTopic(Topic modelTopic)
        {
            string sql = "INSERT INTO tbl_Topic(topic_name, description, user_id) VALUES(:TopicName, :Description, :UserId)";
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":TopicName", modelTopic.TopicName));
                cmd.Parameters.Add(new OracleParameter(":Description", modelTopic.Description));
                cmd.Parameters.Add(new OracleParameter(":UserId", modelTopic.User_id));
                cmd.ExecuteNonQuery();
            }
        }

        public Topic FindById(int topicId)
        {
            Topic data = null;
            string sql = "SELECT topic_id, topic_name, description FROM tbl_Topic WHERE topic_id = :TopicId";

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":TopicId", topicId));
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        data = new Topic(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        );
                    }
                }
            }

            return data;
        }

        public void UpdateTopic(Topic modelTopic)
        {
            string sql = "UPDATE tbl_Topic SET topic_name = :TopicName, description = :Description WHERE topic_id = :TopicId";

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":TopicName", modelTopic.TopicName));
                cmd.Parameters.Add(new OracleParameter(":Description", modelTopic.Description));
                cmd.Parameters.Add(new OracleParameter(":TopicId", modelTopic.Topic_id));
                cmd.ExecuteNonQuery();
            }
        }

        public int GetTopicIdByName(string topicName, int userId)
        {
            int topicId = -1;
            string sql = "SELECT topic_id FROM tbl_Topic WHERE topic_name = :TopicName AND user_id = :UserId";

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":TopicName", topicName));
                cmd.Parameters.Add(new OracleParameter(":UserId", userId));
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        topicId = reader.GetInt32(0);
                    }
                }
            }

            return topicId;
        }

        public bool DeleteById(int topicId)
        {
            string sql = "DELETE FROM tbl_Topic WHERE topic_id = :TopicId";

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            using (var cmd = new OracleCommand(sql, _connection))
            {
                cmd.Parameters.Add(new OracleParameter(":TopicId", topicId));
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
    }
}

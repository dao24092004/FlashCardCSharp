using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Entity
{
    internal class Topic
    {
        private int topic_id;
        private int user_id;
        private String topicName;
        private String description;

        public int Topic_id { get => topic_id; set => topic_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string TopicName { get => topicName; set => topicName = value; }
        public string Description { get => description; set => description = value; }

        public Topic(int topic_id, int user_id, string topicName, string description)
        {
            this.topic_id = topic_id;
            this.user_id = user_id;
            this.topicName = topicName;
            this.description = description;
        }

        public Topic()
        {
        }
        public override string ToString()
        {
            return TopicName; // Hiển thị tên chủ đề trong ComboBox
        }
    }
}

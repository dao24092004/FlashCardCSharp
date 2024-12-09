using FlashCard.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.Model
{
    internal interface IServiceTopic
    {
        public HashSet<object[]> GetAll(int userId);
        public void InsertTopic(Topic modelTopic);
        public Topic FindById(int topicId);
        public void UpdateTopic(Topic modelTopic);
        public int GetTopicIdByName(string topicName, int userId);
        public bool DeleteById(int topicId);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlashCard.Entity
{
    internal class Vocabulary
    {
        private int vocabId;
        private int userId;
        private String word;
        private String meaning;
        private String example;
        private int topic_id;
        private Topic topic;
        private String difficulty;

        public int VocabId { get => vocabId; set => vocabId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Word { get => word; set => word = value; }
        public string Meaning { get => meaning; set => meaning = value; }
        public string Example { get => example; set => example = value; }
        public int Topic_id { get => topic_id; set => topic_id = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        internal Topic Topic { get => topic; set => topic = value; }

        public Vocabulary(int vocabId, int userId, string word, string meaning, string example, int topic_id, Topic topic, string difficulty)
        {
            this.vocabId = vocabId;
            this.userId = userId;
            this.word = word;
            this.meaning = meaning;
            this.example = example;
            this.topic_id = topic_id;
            this.topic = topic;
            this.difficulty = difficulty;
        }


        public Vocabulary(int vocabId, int userId, string word, string meaning, string example, int topic_id, string difficulty)
        {
            this.vocabId = vocabId;
            this.userId = userId;
            this.word = word;
            this.meaning = meaning;
            this.example = example;
            this.topic_id = topic_id;
            this.difficulty = difficulty;
        }

        public Vocabulary(int userId, string word, string meaning, string example, int topic_id, string difficulty)
        {
            this.userId = userId;
            this.word = word;
            this.meaning = meaning;
            this.example = example;
            this.topic_id = topic_id;
            this.difficulty = difficulty;
        }

        public Vocabulary()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using FlashCard.Entity;

namespace FlashCard.Model
{
    internal interface VocabularyDao
    {
        List<object[]> LoadVocabularyData(int userId, string sortByWord, string topicName, string difficulty);
        void InsertVocab(Vocabulary modelVocabulary);
        bool DeleteById(int vocabularyId);
        void Update(Vocabulary modelVocabulary);
        Vocabulary FindById(int vocabId);
        List<Topic> GetTopicByUserId(int userId);
        List<object[]> FindVocabularyByKey(int userId, string name);
    }
}

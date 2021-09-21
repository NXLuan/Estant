using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Service.Model
{
    public class BaseFirestoreModel
    {
        public string id { get; set; }
    }

    [FirestoreData]
    public class Topic: BaseFirestoreModel
    {
        [FirestoreProperty]
        public List<Vocabulary> vocabularies { get; set; }
        [FirestoreProperty]
        public string title { get; set; }
        [FirestoreProperty]
        public string imageUrl { get; set; }

        public Topic()
        {
            vocabularies = new List<Vocabulary>();
        }
    }

    public class Vocabulary
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<Meaning> meanings { get; set; }

        public class Meaning
        {
            public string partOfSpeech { get; set; }
            public List<Definition> definitions { get; set; }

            public class Definition
            {
                public string definition { get; set; }
                public string example { get; set; }
                public List<string> synonyms { get; set; }
                public List<string> antonyms { get; set; }
            }
        }
    }
}

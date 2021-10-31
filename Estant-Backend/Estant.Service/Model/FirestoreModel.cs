using Estant.Material.Model.DTOModel;
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
    public class Topic : BaseFirestoreModel
    {
        [FirestoreProperty]
        public List<string> vocabularies { get; set; }
        [FirestoreProperty]
        public string imageUrl { get; set; }
        public Topic()
        {
            vocabularies = new List<string>();
        }

        public TopicDTO ToDTO()
        {
            return new TopicDTO()
            {
                title = id,
                imageUrl = imageUrl,
                vocabularies = vocabularies
            };
        }
    }

    [FirestoreData]
    public class Vocabulary : BaseFirestoreModel
    {
        [FirestoreProperty]
        public string topic { get; set; }
        [FirestoreProperty]
        public string phonetic { get; set; }
        [FirestoreProperty]
        public string audio { get; set; }
        [FirestoreProperty]
        public List<Dictionary<string, object>> meanings { get; set; }

        public Vocabulary()
        {
            meanings = new List<Dictionary<string, object>>();
        }
    }


    [FirestoreData]
    public class User : BaseFirestoreModel
    {
        [FirestoreProperty]
        public List<string> savedwords { get; set; }

        public User()
        {
            savedwords = new List<string>();
        }
    }
}

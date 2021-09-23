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
        public List<DocumentReference> vocabularies { get; set; }
        [FirestoreProperty]
        public string imageUrl { get; set; }
        public Topic()
        {
            vocabularies = new List<DocumentReference>();
        }
    }

    [FirestoreData]
    public class Vocabulary : BaseFirestoreModel
    {
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
}

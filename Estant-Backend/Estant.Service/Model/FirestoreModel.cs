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
    public class Vocabulary : BaseFirestoreModel
    {
        [FirestoreProperty]
        public string word { get; set; }
    }
}

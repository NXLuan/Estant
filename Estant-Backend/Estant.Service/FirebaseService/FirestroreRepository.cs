using Estant.Material;
using Estant.Service.Model;
using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.FirebaseService
{
    class FirestoreConfig
    {
        private static FirestoreConfig _inStance;
        public  FirestoreDb CurrentFireStorDb { get; set; }
        public static FirestoreConfig Instance
        {
            get
            {
                if (_inStance == null)
                    _inStance = new FirestoreConfig();
                return _inStance;
            }
        }
        public FirestoreConfig()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", ConfigConstants.PrivateKeyPath);
            CurrentFireStorDb = FirestoreDb.Create(ConfigConstants.ProjectID);
        }
    }

    class FirestroreRepository<T> where T : BaseFirestoreModel
    {
        private static string _collectionName;
        private FirestoreDb fireStoreDb;
        public FirestroreRepository(string collectionName)
        {
            fireStoreDb = FirestoreConfig.Instance.CurrentFireStorDb;
            _collectionName = collectionName;
        }

        public T Add(T record)
        {
            CollectionReference colRef = fireStoreDb.Collection(_collectionName);
            DocumentReference doc = colRef.AddAsync(record).GetAwaiter().GetResult();
            record.id = doc.Id;
            return record;
        }

        public bool Update(T record)
        {
            DocumentReference recordRef = fireStoreDb.Collection(_collectionName).Document(record.id);
            return recordRef.SetAsync(record, SetOptions.MergeAll).IsCompletedSuccessfully;
        }
        public bool Delete(T record)
        {
            DocumentReference recordRef = fireStoreDb.Collection(_collectionName).Document(record.id);
            return recordRef.DeleteAsync().IsCompletedSuccessfully;
        }

        public T Get(T record)
        {
            DocumentReference docRef = fireStoreDb.Collection(_collectionName).Document(record.id);
            DocumentSnapshot snapshot = docRef.GetSnapshotAsync().GetAwaiter().GetResult();
            if (snapshot.Exists)
            {
                T result = snapshot.ConvertTo<T>();
                result.id = snapshot.Id;
                return result;
            }
            else
            {
                return null;
            }
        }

        public List<T> GetAll()
        {
            Query query = fireStoreDb.Collection(_collectionName);
            QuerySnapshot querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult();
            List<T> list = new List<T>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, object> data = documentSnapshot.ToDictionary();
                    string json = JsonConvert.SerializeObject(data);
                    T newItem = JsonConvert.DeserializeObject<T>(json);
                    newItem.id = documentSnapshot.Id;
                    list.Add(newItem);
                }
            }
            return list;
        }

        public List<T> QueryRecords(Query query)
        {
            QuerySnapshot querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult();
            List<T> list = new List<T>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, object> data = documentSnapshot.ToDictionary();
                    string json = JsonConvert.SerializeObject(data);
                    T newItem = JsonConvert.DeserializeObject<T>(json);
                    newItem.id = documentSnapshot.Id;
                    list.Add(newItem);
                }
            }
            return list;
        }
    }
}

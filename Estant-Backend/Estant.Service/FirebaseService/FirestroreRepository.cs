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
        public FirestoreDb CurrentFireStorDb { get; set; }
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
        public FirestoreDb fireStoreDb { get; }
        public FirestroreRepository(string collectionName)
        {
            fireStoreDb = FirestoreConfig.Instance.CurrentFireStorDb;
            _collectionName = collectionName;
        }

        public async Task<T> Add(T record)
        {
            CollectionReference colRef = fireStoreDb.Collection(_collectionName);
            DocumentReference doc = await colRef.AddAsync(record);
            record.id = doc.Id;
            return record;
        }

        public async Task<bool> Set(T record)
        {
            try
            {
                DocumentReference recordRef = fireStoreDb.Collection(_collectionName).Document(record.id);
                await recordRef.SetAsync(record, SetOptions.MergeAll);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Update(IDictionary<string, object> record, string documentID)
        {
            try
            {
                DocumentReference recordRef = fireStoreDb.Collection(_collectionName).Document(documentID);
                await recordRef.UpdateAsync(record);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Delete(T record)
        {
            try
            {
                DocumentReference recordRef = fireStoreDb.Collection(_collectionName).Document(record.id);
                await recordRef.DeleteAsync();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<T> Get(string documentId)
        {
            DocumentReference docRef = fireStoreDb.Collection(_collectionName).Document(documentId);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
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

        public async Task<List<T>> GetAll()
        {
            Query query = fireStoreDb.Collection(_collectionName);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
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

        public async Task<List<T>> QueryRecords(Query query)
        {
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
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

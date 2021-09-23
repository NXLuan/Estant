using Estant.Material.Model.DTOModel;
using Estant.Service.Interface;
using Estant.Service.Model;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.FirebaseService
{
    public class TopicFirestoreService : ITopicService
    {
        FirestroreRepository<Topic> repository;

        public TopicFirestoreService()
        {
            repository = new FirestroreRepository<Topic>("Topic");
        }
        public void Add(TopicDTO dto)
        {
            if (dto == null) return;
            Topic topic = new Topic()
            {
                id = dto.title,
            };

            dto.vocabularies.ForEach(vocab =>
            {
                DocumentReference reference = repository.fireStoreDb.Collection("Vocabulary").Document(vocab.word);
                topic.vocabularies.Add(reference);
            });

            repository.Update(topic);
        }
    }
}

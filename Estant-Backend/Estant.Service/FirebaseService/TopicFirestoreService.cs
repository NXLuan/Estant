using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
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

        public TopicFirestoreService(IVocabularyService vocabularyService)
        {
            repository = new FirestroreRepository<Topic>("Topic");
        }

        public async Task<TopicDTO> GetTopic(string topic)
        {
            TopicDTO dto = null;

            var result = await repository.Get(topic);
            if (result != null)
            {
                dto = result.ToDTO();
            }

            return dto;
        }

        public async Task<List<TopicDTO>> GetAll()
        {
            List<TopicDTO> list = new List<TopicDTO>();
            var data = await repository.GetAll();
            if (data != null)
            {
                foreach (var topic in data)
                {
                    list.Add(topic.ToDTO());
                }
            }
            return list;
        }

        public void Add(TopicDTO dto)
        {
            if (dto == null) return;
            Topic topic = new Topic()
            {
                id = dto.title,
            };

            dto.vocabularies.ForEach(word =>
            {
                topic.vocabularies.Add(word);
            });

            repository.Set(topic);
        }

        public async void DeleteWord(string topic, string word)
        {
            Dictionary<string, object> record = new Dictionary<string, object>()
            {
                {"vocabularies", FieldValue.ArrayRemove(word) }
            };
            repository.Update(record, topic);
        }

        public void AddWord(string topic, string word)
        {
            Dictionary<string, object> record = new Dictionary<string, object>()
            {
                {"vocabularies", FieldValue.ArrayUnion(word) }
            };
            repository.Update(record, topic);
        }
    }
}

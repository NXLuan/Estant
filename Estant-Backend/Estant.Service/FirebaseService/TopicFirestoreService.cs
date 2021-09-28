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
        private readonly IVocabularyService _vocabularyService;

        public TopicFirestoreService(IVocabularyService vocabularyService)
        {
            repository = new FirestroreRepository<Topic>("Topic");
            _vocabularyService = vocabularyService;
        }

        public async Task<TopicViewModel> GetTopic(string topic)
        {
            TopicViewModel vm = null;

            var result = await repository.Get(new Topic() { id = topic });
            MultiRequestHelper<VocabularyViewModel> helper = new MultiRequestHelper<VocabularyViewModel>();
            if (result != null)
            {
                #region Get all vocabulary in topic
                result.vocabularies?.ForEach(word =>
                {
                    helper.AddRequest(_vocabularyService.Get(word));
                });

                var responses = await helper.Execute();
                List<VocabularyViewModel> vocabVMs = new List<VocabularyViewModel>();
                foreach (var response in responses)
                {
                    if (response != null)
                        vocabVMs.Add(response);
                }
                #endregion

                vm = new TopicViewModel()
                {
                    title = result.id,
                    imageUrl = result.imageUrl,
                    vocabularies = vocabVMs
                };
            }

            return vm;
        }

        public async Task<List<TopicViewModel>> GetAll()
        {
            List<TopicViewModel> list = new List<TopicViewModel>();
            var data = await repository.GetAll();
            if (data != null)
            {
                MultiRequestHelper<TopicViewModel> helper = new MultiRequestHelper<TopicViewModel>();

                data.ForEach(topic => helper.AddRequest(GetTopic(topic.id)));
                var responses = await helper.Execute();
                foreach (var response in responses)
                {
                    if (response != null)
                        list.Add(response);
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

            dto.vocabularies.ForEach(vocab =>
            {
                topic.vocabularies.Add(vocab.word);
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
    }
}

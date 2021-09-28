using Estant.Material.Model.ViewModel;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Estant.Core.Mappings;
using Estant.Service.ApiService;
using System.Threading.Tasks;
using Estant.Service.Model;
using Estant.Material;
using System.Linq;
using Estant.Material.Model.DTOModel;
using Estant.Material.Utilities;

namespace Estant.Core.Handlers
{
    public class VocabularyHandler
    {
        #region constructor
        private readonly ITopicService _topicService;
        private readonly IVocabularyService _vocabularyService;
        public VocabularyHandler(ITopicService topicService, IVocabularyService vocabularyService)
        {
            _topicService = topicService;
            _vocabularyService = vocabularyService;
        }
        #endregion

        public async Task<List<TopicViewModel>> GetAllTopic()
        {
            List<TopicViewModel> data = await _topicService.GetAll();
            return data;
        }

        public async Task<TopicDTO> AddByTopic(string topic)
        {
            TopicDTO data = null;
            var jsonTopic = await VocabularyApi.GetByTopic(topic);

            if (jsonTopic != null)
            {
                data = jsonTopic.ArrayJsonToTopic(topic);

                #region Lấy thông tin từ vựng theo Dictionary
                if (data.vocabularies.Count != 0)
                {
                    MultiRequestHelper<string> helperCallApi = new MultiRequestHelper<string>();

                    for (int i = 0; i < ConfigConstants.WordCountPerTopic; i++)
                    {
                        helperCallApi.AddRequest(VocabularyApi.GetFromDictionary(data.vocabularies[i].word));
                    }
                    var responseCallApis = await helperCallApi.Execute();

                    #region handle add data in database
                    data.vocabularies.Clear();

                    #region handle add vocabulary
                    foreach (var jsonVocabulary in responseCallApis)
                    {
                        if (jsonVocabulary != null)
                        {
                            var vocabulary = jsonVocabulary.ArrayJsonToVocabulary(topic);
                            if (vocabulary != null)
                            {
                                _vocabularyService.Add(vocabulary);
                                data.vocabularies.Add(vocabulary);
                            }
                        }
                    }
                    #endregion

                    // add topic
                    if (data.vocabularies.Count > 0)
                        _topicService.Add(data);

                    #endregion
                }
                #endregion
            }

            return data;
        }

        public async Task<TopicDTO> AddWordToTopic(string topic, string word)
        {
            TopicDTO data = new TopicDTO()
            {
                title = topic,
            };

            if (!string.IsNullOrWhiteSpace(word))
            {
                #region Lấy thông tin từ vựng theo Dictionary
                var jsonVocabulary = await VocabularyApi.GetFromDictionary(word);

                if (jsonVocabulary != null)
                {
                    var vocabulary = jsonVocabulary.ArrayJsonToVocabulary(topic);
                    if (vocabulary != null)
                    {
                        _vocabularyService.Add(vocabulary);
                        data.vocabularies.Add(vocabulary);
                        _topicService.Add(data);
                    }
                }
                #endregion
            }

            return data;
        }

        public async Task<bool> DeleteWord(string word)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(word))
            {
                var topic = await _vocabularyService.Delete(word);
                if (!string.IsNullOrEmpty(topic))
                {
                    _topicService.DeleteWord(topic, word);
                    result = true;
                }
            }
            return result;
        }
    }
}

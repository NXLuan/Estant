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

        public List<VocabularyViewModel> GetAll()
        {
            List<VocabularyViewModel> data = new List<VocabularyViewModel>();

            var result = _vocabularyService.GetAll();
            result?.ForEach(e => data.Add(e.ToViewModel()));

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
                    MultiRequestHelper<VocabularyDTO> helperFirestore = new MultiRequestHelper<VocabularyDTO>();
                    foreach (var jsonVocabulary in responseCallApis)
                    {
                        if (jsonVocabulary != null)
                        {
                            var vocabulary = jsonVocabulary.ArrayJsonToVocabulary();
                            if (vocabulary != null)
                            {
                                helperFirestore.AddRequest(_vocabularyService.Add(vocabulary));
                            }
                        }
                    }
                    var responseFirestores = await helperFirestore.Execute();
                    foreach (var response in responseFirestores)
                    {
                        if (response != null) data.vocabularies.Add(response);
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

        public async Task<TopicDTO> AddByWord(string topic, string word)
        {
            TopicDTO data = new TopicDTO()
            {
                title = topic,
            };

            if (string.IsNullOrWhiteSpace(word))
            {
                #region Lấy thông tin từ vựng theo Dictionary
                var jsonVocabulary = await VocabularyApi.GetFromDictionary(word);

                if (jsonVocabulary != null)
                {
                    var vocabulary = jsonVocabulary.ArrayJsonToVocabulary();
                    if (vocabulary != null)
                    {
                        var response = await _vocabularyService.Add(vocabulary);
                        if (response != null)
                        {
                            data.vocabularies.Add(response);
                            _topicService.Add(data);
                        }      
                    }
                }
                #endregion
            }

            return data;
        }
    }
}

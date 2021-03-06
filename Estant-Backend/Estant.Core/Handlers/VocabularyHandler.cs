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
using Estant.Material.Model.EnumModel;

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
            List<TopicViewModel> data = new List<TopicViewModel>();
            var topicDTOs = await _topicService.GetAll();
            if (topicDTOs != null && topicDTOs.Count > 0)
            {
                topicDTOs.ForEach(dto => data.Add(dto.ToViewModel()));
            }

            return data;
        }

        public async Task<List<VocabularyViewModel>> GetByTopic(string topic)
        {
            List<VocabularyViewModel> data = new List<VocabularyViewModel>();

            var topicDTOs = await _topicService.GetTopic(topic);
            if (topicDTOs != null)
            {
                #region Get all content vocabulary in topic
                MultiRequestHelper<VocabularyViewModel> helper = new MultiRequestHelper<VocabularyViewModel>();

                topicDTOs.vocabularies?.ForEach(word =>
                {
                    helper.AddRequest(_vocabularyService.Get(word));
                });

                var responses = await helper.Execute();

                foreach (var response in responses)
                {
                    if (response != null)
                        data.Add(response);
                }
                #endregion
            }

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
                        helperCallApi.AddRequest(VocabularyApi.GetFromDictionary(data.vocabularies[i]));
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
                                data.vocabularies.Add(vocabulary.word);
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
                        data.vocabularies.Add(vocabulary.word);
                        _topicService.AddWord(topic, vocabulary.word);
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

        public async Task<VocabularyDTO> GetFromDictionary(string word)
        {
            VocabularyDTO viewModel = null;
            var jsonVocabulary = await VocabularyApi.GetFromDictionary(word);

            if (jsonVocabulary != null)
            {
                viewModel = jsonVocabulary.ArrayJsonToVocabulary();
            }

            return viewModel;
        }

        public async Task<List<object>> GenerateExercise(string topic)
        {
            List<object> exerciseViewModels = new List<object>();
            var vocabList = await this.GetByTopic(topic);
            if (vocabList != null && vocabList.Count > 0)
            {
                MultiRequestHelper<object> helper = new MultiRequestHelper<object>();
                RandomSelectIndex random = new RandomSelectIndex(vocabList.Count);

                int count = vocabList.Count >= ConfigConstants.NumOfQuestion ? ConfigConstants.NumOfQuestion : vocabList.Count;
                Random rand = new Random();
                for (int i = 0; i < count; i++)
                {
                    int index = random.GetIndexRandom();
                    var vocab = vocabList[index];

                    int type = rand.Next(1, ConfigConstants.NumTypeOfExe + 1);
                    switch (type)
                    {
                        case (int)TypeQuestion.FillBlank:
                            helper.AddRequest(Task.Run(() => vocab.GenFillBlankExe()));
                            break;
                        case (int)TypeQuestion.ChooseWordByExample:
                            helper.AddRequest(Task.Run(() => vocab.GenChooseWordByExampleExe(vocabList)));
                            break;
                        case (int)TypeQuestion.ChooseMeaningByWord:
                            helper.AddRequest(Task.Run(() => vocab.GenChooseMeaningByWordExe(vocabList)));
                            break;
                        case (int)TypeQuestion.WriteWordByAudio:
                            helper.AddRequest(Task.Run(() => vocab.GenWriteWordByAudioExe()));
                            break;
                        default:
                            helper.AddRequest(Task.Run(() => vocab.GenWriteWordByAudioExe()));
                            break;
                    }
                }

                var responses = await helper.Execute();

                foreach (var response in responses)
                {
                    if (response != null)
                        exerciseViewModels.Add(response);
                }
            }
            return exerciseViewModels;
        }
    }
}

using Estant.Core.Helpers;
using Estant.Material;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Core.Handlers
{
    public class ExerciseHandler
    {
        private readonly ITopicService _topicService;
        private readonly VocabularyHandler _vocabularyHandler;
        public ExerciseHandler(ITopicService topicService, VocabularyHandler vocabularyHandler)
        {
            _topicService = topicService;
            _vocabularyHandler = vocabularyHandler;
        }

        public async Task<List<object>> GenerateVocabExes(string topic)
        {
            List<object> exerciseViewModels = new List<object>();
            var vocabList = await _vocabularyHandler.GetByTopic(topic);
            if (vocabList != null && vocabList.Count > 0)
            {
                MultiRequestHelper<object> helper = new MultiRequestHelper<object>();
                RandomSelectIndex random = new RandomSelectIndex(vocabList.Count);

                int count = vocabList.Count >= ConfigConstants.NumOfQuestion ? ConfigConstants.NumOfQuestion : vocabList.Count;
                for (int i = 0; i < count; i++)
                {
                    int index = random.GetIndexRandom();
                    var vocab = vocabList[index];

                    FormQuestion form = FormQuestion.FillBlank;
                    switch (form)
                    {
                        case FormQuestion.FillBlank:
                            var definitions = vocab.meanings[0]["definitions"] as List<object>;
                            var keyValuePairs = definitions[0] as Dictionary<string, object>;
                            string definition = keyValuePairs["definition"].ToString();
                            string partOfSpeech = vocab.meanings[0]["partOfSpeech"].ToString();
                            helper.AddRequest(Task.Run(() => VocabExeHelper.CreateForm1(vocab.word, definition, partOfSpeech)));
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

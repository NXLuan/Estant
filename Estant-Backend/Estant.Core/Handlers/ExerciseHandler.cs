using Estant.Core.Mappings;
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
                Random rand = new Random();
                for (int i = 0; i < count; i++)
                {
                    int index = random.GetIndexRandom();
                    var vocab = vocabList[index];

                    int type = rand.Next(1, 4);
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

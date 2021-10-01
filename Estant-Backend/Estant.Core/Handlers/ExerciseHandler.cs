using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Handlers
{
    public class ExerciseHandler
    {
        private readonly ITopicService _topicService;
        public ExerciseHandler(ITopicService topicService)
        {
            _topicService = topicService;
        }

        public async void GenerateVocabExes(string topic)
        {
            var topicDTOs = await _topicService.GetTopic(topic);
        }
    }
}

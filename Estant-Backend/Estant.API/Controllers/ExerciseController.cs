using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class ExerciseController : BaseController
    {
        #region Contructor
        private readonly VocabularyHandler _vocabHandler;
        private readonly GrammarHandler _grammarHandler;
        public ExerciseController(VocabularyHandler vocabHandler, GrammarHandler grammarHandler)
        {
            _vocabHandler = vocabHandler;
            _grammarHandler = grammarHandler;
        }
        #endregion

        [HttpGet("GetByTopic")]
        public async Task<IActionResult> GetByTopic(string topic)
        {
            var responseError = ResponseError.NoError;
            var data = await _vocabHandler.GenerateExercise(topic);
            return ReturnData(data, responseError);
        }
        
        [HttpGet("GetByGrammar")]
        public async Task<IActionResult> GetByGrammar(string code)
        {
            var responseError = ResponseError.NoError;
            var data = await _grammarHandler.GetExercise(code);
            return ReturnData(data, responseError);
        }
    }
}

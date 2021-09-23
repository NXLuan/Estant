using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Service.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class VocabularyController : BaseController
    {
        #region Contructor
        private readonly VocabularyHandler _vocabularyHandler;
        public VocabularyController(VocabularyHandler vocabularyHandler)
        {
            _vocabularyHandler = vocabularyHandler;
        }
        #endregion

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var responseError = ResponseError.NoError;
            var data = _vocabularyHandler.GetAll();

            return ReturnData<List<VocabularyViewModel>>(data, responseError);
        }

        #region CRUD
        [HttpPost("AddTopic")]
        public async Task<IActionResult> AddTopic(string topic)
        {
            if (string.IsNullOrWhiteSpace(topic)) return Content("Topic is empty");
            var data = await _vocabularyHandler.AddByTopic(topic);
            return Json(data);
        }

        [HttpPost("AddVocabulary")]
        public async Task<IActionResult> AddVocabulary(string topic, string word)
        {
            if (string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(word)) return Content("Input is empty");
            var data = await _vocabularyHandler.AddByWord(topic, word);
            return Json(data);
        }
        #endregion
    }
}

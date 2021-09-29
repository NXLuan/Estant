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

        #region GET DATA
        [HttpGet("GetAllTopic")]
        public async Task<IActionResult> GetAllTopic()
        {
            var responseError = ResponseError.NoError;
            var data = await _vocabularyHandler.GetAllTopic();
            return ReturnData<List<TopicViewModel>>(data, responseError);
        }

        [HttpGet("GetByTopic")]
        public async Task<IActionResult> GetByTopic(string topic)
        {
            var responseError = ResponseError.NoError;
            var data = await _vocabularyHandler.GetByTopic(topic);
            return ReturnData<List<VocabularyViewModel>>(data, responseError);
        }
        #endregion

        #region CRUD
        [HttpPost("AddTopic")]
        public async Task<IActionResult> AddTopic(string topic)
        {
            if (string.IsNullOrWhiteSpace(topic)) return Content("Topic is empty");
            var data = await _vocabularyHandler.AddByTopic(topic);
            return Json(data);
        }

        [HttpPost("AddToTopic")]
        public async Task<IActionResult> AddToTopic(string topic, string word)
        {
            if (string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(word)) return Content("Input is empty");
            var data = await _vocabularyHandler.AddWordToTopic(topic, word);
            return Json(data);
        }

        [HttpPost("DeleteWord")]
        public async Task<IActionResult> DeleteFromTopic(string word)
        {
            string message = string.Empty;
            if (string.IsNullOrWhiteSpace(word)) message = "Input is empty";
            else if (await _vocabularyHandler.DeleteWord(word)) message = "Success!";
            else message = "Word not found";
            return Content(message);
        }
        #endregion

    }
}

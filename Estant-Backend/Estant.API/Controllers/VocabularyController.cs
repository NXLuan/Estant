using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}

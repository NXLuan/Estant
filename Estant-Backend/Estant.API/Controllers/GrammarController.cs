using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class GrammarController : BaseController
    {
        #region Contructor
        private readonly GrammarHandler _grammarHandler;
        public GrammarController(GrammarHandler grammarHandler)
        {
            _grammarHandler = grammarHandler;
        }
        #endregion

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var responseError = ResponseError.NoError;
            var data = await _grammarHandler.GetAll();
            return ReturnData(data, responseError);
        }

        [HttpGet("GetHtmlContent")]
        public async Task<IActionResult> GetHtmlContent(string code)
        {
            var responseError = ResponseError.NoError;
            var data = await _grammarHandler.GetHtmlContent(code);
            return ReturnData(data, responseError);
        }

        [HttpPost("CheckSpellAndGrammar")]
        public async Task<IActionResult> CheckSpellAndGrammar([FromBody]string text)
        {
            var responseError = ResponseError.NoError;
            if (string.IsNullOrWhiteSpace(text))
                responseError = ResponseError.IsEmptyInput;
            List<SpellAndGrammarViewModel> data = null;
            if (!responseError.HasError())
            {
                data = await _grammarHandler.CheckSpellAndGrammar(text);
            }
            return ReturnData(data, responseError);
        }
    }
}

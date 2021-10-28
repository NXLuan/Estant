using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class NewsController : BaseController
    {
        #region Contructor
        private readonly NewsHandler _newsHandler;
        public NewsController(NewsHandler newsHandler)
        {
            _newsHandler = newsHandler;
        }
        #endregion

        [HttpGet("GetNewsToday")]
        public IActionResult GetNewsTopToday()
        {
            var responseError = ResponseError.NoError;
            var data = _newsHandler.GetNewsTopToday();
            return ReturnData(data, responseError);
        }

        [HttpGet("GetNewsByKeyWord")]
        public IActionResult GetNewByKeyWord(string keyword)
        {
            var responseError = ResponseError.NoError;
            var data = _newsHandler.GetNewsByKeyWord(keyword);
            return ReturnData(data, responseError);
        }
    }
}

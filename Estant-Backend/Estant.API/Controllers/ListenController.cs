using Estant.Material.Model.EnumModel;
using Estant.Service.ApiService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class ListenController : BaseController
    {
        [HttpGet("Search")]
        public async Task<IActionResult> Search(string title)
        {
            var responseError = ResponseError.NoError;
            var data = await ListenApi.Search(title);
            return ReturnData(data, responseError);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetList()
        {
            var responseError = ResponseError.NoError;
            var data = await ListenApi.Search("Listen");
            return ReturnData(data, responseError);
        }
    }
}

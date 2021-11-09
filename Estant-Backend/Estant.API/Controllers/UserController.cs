using Estant.Core.Handlers;
using Estant.Material.Model.EnumModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        #region Contructor
        private readonly UserHandler _userHandler;
        public UserController(UserHandler userHandler)
        {
            _userHandler = userHandler;
        }
        #endregion

        [HttpPost("SaveWord")]
        public async Task<IActionResult> SaveWord([FromBody] string word)
        {
            var responseError = ResponseError.NoError;
            List<string> data = null;
            string uid = GetCurrentUID();
            if (!string.IsNullOrEmpty(uid))
            {
                data = await _userHandler.SaveWord(uid, word);
                if (data == null) responseError = ResponseError.SaveWordFail;
            }
            else responseError = ResponseError.TokenInvalid;
            return ReturnData(data, responseError);
        }
    }
}

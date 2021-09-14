using Estant.Core.Handlers;
using Estant.Material;
using Estant.Material.Model;
using Estant.Material.Model.RequestModel;
using Estant.Material.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estant.Material.Model.EnumModel;

namespace Estant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        #region Contructor
        private readonly AuthHandler _authHandler;
        public AuthController(AuthHandler authHandler)
        {
            _authHandler = authHandler;
        }
        #endregion

        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] SignInRequestModel requestModel)
        {
            var responseError = ResponseError.NoError;

            var data = await _authHandler.SignInHandle(requestModel);
            if (data == null) responseError = ResponseError.SignInFail;

            return ReturnData<UserViewModel>(data, responseError);
        }
    }
}

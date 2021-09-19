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
using Estant.Material.Utilities;

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

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequestModel requestModel)
        {
            var responseError = ResponseError.NoError;
            if (requestModel == null)
                responseError = ResponseError.InputInvalid;
            responseError = requestModel.ValidateParams();

            UserViewModel data = null;
            if (!responseError.HasError())
            {
                data = await _authHandler.SignInAsync(requestModel);
                if (data == null) responseError = ResponseError.SignInFail;
            }

            return ReturnData<UserViewModel>(data, responseError);
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequestModel requestModel)
        {
            var responseError = ResponseError.NoError;
            if (requestModel == null)
                responseError = ResponseError.InputInvalid;
            responseError = requestModel.ValidateParams();

            if (!responseError.HasError())
            {
                var data = await _authHandler.SignUpAsync(requestModel);
                if (!data) responseError = ResponseError.SignUpFail;
            }

            return ReturnNoData(responseError);
        }
    }
}

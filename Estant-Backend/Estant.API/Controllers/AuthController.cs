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
                else if (!data.IsEmailVerified) responseError = ResponseError.EmailNotVerified;
            }

            return ReturnData(data, responseError);
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
                var IsSuccess = await _authHandler.SignUpAsync(requestModel);
                if (!IsSuccess) responseError = ResponseError.SignUpFail;
            }

            return ReturnNoData(responseError, "Successful account registration, please check your email to verify your account");
        }

        [HttpPost("ResetAccount")]
        public async Task<IActionResult> ResetAccount([FromBody] string email)
        {
            var responseError = ResponseError.NoError;
            if (!ValidationData.IsEmail(email))
                responseError = ResponseError.EmailInvalid;

            if (!responseError.HasError())
            {
                var IsSuccess = await _authHandler.ResetAccountAsync(email);
                if (!IsSuccess) responseError = ResponseError.ResetAccountFail;
            }

            return ReturnNoData(responseError, "Reset account successfully, please check your email for a new password");
        }
    }
}

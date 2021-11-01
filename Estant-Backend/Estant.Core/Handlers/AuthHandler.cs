using Estant.Material.Model.EnumModel;
using Estant.Material.Model.RequestModel;
using Estant.Material.Model.ViewModel;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Estant.Core.Mappings;
namespace Estant.Core.Handlers
{
    public class AuthHandler
    {
        private readonly IAuthenticationService _authService;
        private readonly IUserService _userService;
        public AuthHandler(IAuthenticationService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
        }

        public async Task<UserViewModel> SignInAsync(SignInRequestModel requestModel)
        {
            UserViewModel data = null;

            if (requestModel != null)
            {
                var result = await _authService.SignInWithEmailAndPassword(requestModel.Email, requestModel.Password);
                if (result != null)
                {
                    // Map info user Authentication
                    data = result.ToViewModel();

                    if (data.IsEmailVerified)
                    {
                        // Map info user of Estant
                        var userInfo = await _userService.Get(result.UID);
                        data.SavedWords = userInfo.savedwords;
                    }
                }
            }

            return data;
        }

        public async Task<bool> SignUpAsync(SignUpRequestModel requestModel)
        {
            bool IsSuccess = false;

            if (requestModel != null)
            {
                var uid = await _authService.SignUp(requestModel.Email, requestModel.Password, requestModel.DisplayName);
                if (!string.IsNullOrEmpty(uid))
                {
                    _userService.Add(uid);
                    IsSuccess = true;
                }
            }

            return IsSuccess;
        }
    }
}

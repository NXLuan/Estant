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
        public AuthHandler(IAuthenticationService authService)
        {
            _authService = authService;
        }

        public async Task<UserViewModel> SignInHandle(SignInRequestModel requestModel)
        {
            UserViewModel data = null;

            if (requestModel != null)
            {
                var result = await _authService.SignInWithEmailAndPassword(requestModel.Email, requestModel.Password);
                data = result?.ToViewModel();
            }

            return data;
        }
    }
}

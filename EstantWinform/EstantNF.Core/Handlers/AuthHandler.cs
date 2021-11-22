using EstantWF.Material.Model;
using EstantWF.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantNF.Core.Handlers
{
    public static class AuthHandler
    {
        public static async Task<ResponseModel<User>> SignIn(string email, string password)
        {
            var request = new SignInRequest()
            {
                email = email,
                password = password
            };
            string path = "Auth/SignIn";
            return await API.PostRequestAsync<User>(path, request);
        }

        public static async Task<ResponseModel<object>> SignUp(string name, string email, string password, string confirmPassword)
        {
            var request = new SignUpRequest()
            {
                displayName = name,
                email = email,
                password = password,
                confirmPassword = confirmPassword
            };
            string path = "Auth/SignUp";
            return await API.PostRequestAsync<object>(path, request);
        }

        public static async Task<ResponseModel<object>> ResetPassword(string email)
        {
            string path = "Auth/ResetAccount";
            return await API.PostRequestAsync<object>(path, email);
        }
    }
}

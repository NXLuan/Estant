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
    }
}

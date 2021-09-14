using Estant.Material;
using Estant.Material.Model.DTOModel;
using Estant.Service.Interface;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.FirebaseService
{
    public class AuthFirebaseService : IAuthenticationService
    {
        private FirebaseAuthProvider AuthProvider;
        public AuthFirebaseService()
        {
            AuthProvider = new FirebaseAuthProvider(new FirebaseConfig(ConfigConstants.ApiKey));
        }
        public async Task<UserDTO> SignInWithEmailAndPassword(string email, string password)
        {
            UserDTO result = null;
            try
            {
                var auth = await AuthProvider.SignInWithEmailAndPasswordAsync(email, password);
                var user = auth?.User;
                if (user != null)
                {
                    result = new UserDTO()
                    {
                        UID = user.LocalId,
                        DISPLAYNAME = user.DisplayName,
                        EMAIL = user.Email,
                        PHOTOURL = user.PhotoUrl
                    };
                }
            }
            catch
            {
            }
            return result;
        }

        public void SignOut()
        {
        }

        public void SignUp()
        {
        }
    }
}

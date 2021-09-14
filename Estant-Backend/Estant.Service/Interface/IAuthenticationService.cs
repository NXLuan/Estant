using Estant.Material.Model.DTOModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IAuthenticationService
    {
        public Task<UserDTO> SignInWithEmailAndPassword(string email, string password);
        public void SignOut();
        public void SignUp();
    }
}

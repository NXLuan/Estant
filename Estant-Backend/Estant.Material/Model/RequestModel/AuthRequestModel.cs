using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.RequestModel
{
    public class SignInRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class SignUpRequestModel
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }
    }
}

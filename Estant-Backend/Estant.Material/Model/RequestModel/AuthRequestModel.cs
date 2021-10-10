using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.RequestModel
{
    public class SignInRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ResponseError ValidateParams()
        {
            if (!ValidationData.IsEmail(Email))
                return ResponseError.EmailInvalid;

            if (string.IsNullOrWhiteSpace(Password))
                return ResponseError.IsEmptyInput;

            return ResponseError.NoError;
        }
    }

    public class SignUpRequestModel
    {
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ResponseError ValidateParams()
        {
            if (!ValidationData.IsEmail(Email))
                return ResponseError.EmailInvalid;

            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword) || string.IsNullOrWhiteSpace(DisplayName))
                return ResponseError.IsEmptyInput;

            if (!Password.Equals(ConfirmPassword))
                return ResponseError.PasswordNotMatch;

            return ResponseError.NoError;
        }
    }
}

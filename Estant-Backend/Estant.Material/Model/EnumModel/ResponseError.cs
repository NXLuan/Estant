using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Estant.Material.Model.EnumModel
{
    public enum ResponseError
    {
        [Description("No error")]
        NoError,

        #region Authentication Error
        [Description("Incorrect username or password")]
        IncorrectUser = 1001,
        [Description("Sign in fail")]
        SignInFail = 1002,
        [Description("Sign up fail")]
        SignUpFail = 1003,
        #endregion
    }
}

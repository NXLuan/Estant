using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Estant.Material.Model.EnumModel
{
    public enum ResponseError
    {
        [Description("No error")]
        NoError = 0,
        [Description("Empty input")]
        IsEmptyInput = 1,

        #region Authentication Error
        [Description("Invalid input")]
        InputInvalid = 1000,
        [Description("Invalid email")]
        EmailInvalid = 1001,
        [Description("Incorrect username or password")]
        IncorrectUser = 1002,
        [Description("Sign in fail")]
        SignInFail = 1003,
        [Description("Sign up fail")]
        SignUpFail = 1004,
        [Description("Password and Confirm password does not match")]
        PasswordNotMatch = 1005,
        [Description("Password weak")]
        WeakPassword = 1006,
        [Description("Email is not verified")]
        EmailNotVerified= 1007,
        [Description("Invalid token")]
        TokenInvalid = 1008,
        [Description("Reset account fail")]
        ResetAccountFail = 1009,
        #endregion

        #region Vocabulary Error
        [Description("No results found")]
        NoResultFound= 2000,
        #endregion

        #region User Error
        [Description("Save word fail")]
        SaveWordFail = 3000,
        [Description("Unsave word fail")]
        UnSaveWordFail
        #endregion
    }
}

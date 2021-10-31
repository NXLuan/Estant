using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Estant.Material.Utilities
{
    public class PasswordAdvisor
    {
        public static bool CheckStrength(string password)
        {
            bool IsValid = false;
            if (password.Length >= 8 && Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[!@#$%^&*?_~\-£()]", RegexOptions.ECMAScript).Success)
                IsValid = true;
            return IsValid;
        }
    }
}

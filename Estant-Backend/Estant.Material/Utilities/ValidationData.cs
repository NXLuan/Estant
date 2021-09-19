using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Estant.Material.Utilities
{
    public class ValidationData
    {
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            const string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email.Trim(), sMailPattern);
        }
    }
}

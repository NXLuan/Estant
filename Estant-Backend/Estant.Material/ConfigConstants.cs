using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material
{
    public static class ConfigConstants
    {
        #region JWT variables
        public static string JwtKey { get; set; }
        public static string JwtIssuer { get; set; }
        #endregion

        #region Firebase variables
        public static string ApiKey { get; set; }
        #endregion
    }
}

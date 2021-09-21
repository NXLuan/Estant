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
        public static string ProjectID { get; set; }
        public static string PrivateKeyPath { get; set; }
        #endregion

        public static int WordCountPerTopic = 15;
    }
}

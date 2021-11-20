using EstantWF.Material.Model;
using EstantWF.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantNF.Core.Handlers
{
    public static class GrammarHandler
    {
        public static async Task<List<Grammar>> GetAll()
        {
            var data = new List<Grammar>();
            string path = "Grammar/GetAll";
            var response = await API.GetRequestAsync<List<Grammar>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }

        public static async Task<string> GetHTMLContent(string code)
        {
            var data = string.Empty;
            string path = "Grammar/GetHtmlContent?code=" + code;
            var response = await API.GetRequestAsync<string>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

using EstantWF.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantNF.Core.Handlers
{
    public static class UserHandler
    {
        public static async Task<List<string>> SaveWord(string word, string token)
        {
            var data = new List<string>();
            string path = "User/SaveWord?word=" + word;
            var response = await API.GetRequestAsync<List<string>>(path, token);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }

        public static async Task<List<string>> UnSaveWord(string word, string token)
        {
            var data = new List<string>();
            string path = "User/UnSaveWord?word=" + word;
            var response = await API.GetRequestAsync<List<string>>(path, token);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

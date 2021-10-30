using EstantWF.Material.Model;
using EstantWF.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantNF.Core.Handlers
{
    public static class VocabularyHandler
    {
        public static async Task<List<Topic>> GetAllTopic()
        {
            var data = new List<Topic>();
            string path = "Vocabulary/GetAllTopic";
            var response = await API.GetRequestAsync<List<Topic>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

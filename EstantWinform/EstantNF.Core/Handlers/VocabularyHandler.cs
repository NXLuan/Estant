using EstantWF.Material;
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
            //return MockData.GetAllTopic();
            var data = new List<Topic>();
            string path = "Vocabulary/GetAllTopic";
            var response = await API.GetRequestAsync<List<Topic>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }

        public static async Task<List<Vocabulary>> GetByTopic(string topic)
        {
            var data = new List<Vocabulary>();
            string path = "Vocabulary/GetByTopic?topic=" + topic;
            var response = await API.GetRequestAsync<List<Vocabulary>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

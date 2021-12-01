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
    public class NewsHandler
    {
        public static async Task<List<News>> GetNewsToday()
        {
            //return MockData.GetNewsToday();
            var data = new List<News>();
            string path = "News/GetNewsToday";
            var response = await API.GetRequestAsync<List<News>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }

        public static async Task<List<News>> GetNewsByKeyWord(string keyword)
        {
            var data = new List<News>();
            string path = "News/GetNewsByKeyWord?keyword=" + keyword;
            var response = await API.GetRequestAsync<List<News>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

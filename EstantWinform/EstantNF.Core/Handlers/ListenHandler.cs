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
    public static class ListenHandler
    {
        public static async Task<Listen> GetList()
        {
            //return MockData.GetListening();
            var data = new Listen();
            string path = "Listen/GetList";
            var response = await API.GetRequestAsync<Listen>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }

        public static async Task<Listen> Search(string title)
        {
            var data = new Listen();
            string path = $"Listen/Search?title={title}";
            var response = await API.GetRequestAsync<Listen>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}

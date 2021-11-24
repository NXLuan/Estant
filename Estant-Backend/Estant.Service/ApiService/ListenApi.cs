using Estant.Material.Model.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Estant.Service.ApiService
{
    public static class ListenApi
    {
        public static async Task<ListenViewModel> Search(string q)
        {
            ListenViewModel result = null;
            using (var client = new HttpClient())
            {
                try
                {
                    string param = $"q={q}&sort_by_date=0&type=episode&offset=0&len_min=10&len_max=15&genre_ids=68%2C82&published_before=1580172454000&published_after=0&only_in=title%2Cdescription&language=English&safe_mode=0";
                    client.DefaultRequestHeaders.Add("X-ListenAPI-Key", "57a93dc30d764d5196ab204e9c4a7ce9");
                    var response = await client.GetAsync("https://listen-api.listennotes.com/api/v2/search?" + param);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        result = JsonConvert.DeserializeObject<ListenViewModel>(json);
                    }
                }
                catch (Exception e)
                {
                    result = null;
                }
            }

            return result;
        }
    }
}

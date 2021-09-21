using Estant.Material;
using Estant.Service.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.ApiService
{
    public static class VocabularyApi
    {
        public static async Task<string> GetByTopic(string title)
        {
            string result = null;
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://api.datamuse.com/words?topics=" + title);

                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
                catch (Exception e)
                {
                    result = null;
                }
            }

            return result;
        }

        public static async Task<string> GetFromDictionary(string word)
        {
            string result = null;
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://api.dictionaryapi.dev/api/v2/entries/en/" + word);

                    if (response.IsSuccessStatusCode)
                    {
                        result = await response.Content.ReadAsStringAsync();
                 
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

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.ApiService
{
    public static class LanguageToolApi
    {
        public static async Task<string> TextChecking(string text)
        {
            var result = string.Empty;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://dnaber-languagetool.p.rapidapi.com/v2/check"),
                Headers =
                {
                    { "x-rapidapi-host", "dnaber-languagetool.p.rapidapi.com" },
                    { "x-rapidapi-key", "350f660195msh59f495a7db6352dp15c559jsn90c3257ca551" },
                },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "language", "en-US" },
                    { "text", text },
                }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}

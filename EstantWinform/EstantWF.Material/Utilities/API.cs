using EstantWF.Material.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Utilities
{
    public static class API
    {
        private static string BaseUrlApi = "http://localhost:5001/api/";

        public static async Task<ResponseModel<T>> GetRequestAsync<T>(string path)
        {
            ResponseModel<T> result = null;
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(BaseUrlApi + path);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        result = JsonConvert.DeserializeObject<ResponseModel<T>>(jsonString);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }

            if (result == null)
            {
                result = new ResponseModel<T>()
                {
                    code = -1,
                    message = "Đã có lỗi xảy ra",
                };
            }

            return result;
        }

        public static async Task<ResponseModel<T>> PostRequestAsync<T>(string path, object requestBody)
        {
            ResponseModel<T> result = null;
            using (var client = new HttpClient())
            {
                try
                {
                    var bodyString = JsonConvert.SerializeObject(requestBody);
                    var httpContent = new StringContent(bodyString, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(BaseUrlApi + path, httpContent);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        result = JsonConvert.DeserializeObject<ResponseModel<T>>(jsonString);
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }

            if (result == null)
            {
                result = new ResponseModel<T>()
                {
                    code = -1,
                    message = "Đã có lỗi xảy ra",
                };
            }

            return result;
        }
    }
}

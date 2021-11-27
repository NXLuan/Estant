using Estant.Material.Model;
using Estant.Material.Model.RequestModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.ApiService
{
    public static class PronunciationAssessmentApi
    {
        public async static Task<PronunciationAssessmentResponse> Report(PronunciationAssessmentRequest requestModel)
        {
            PronunciationAssessmentResponse result = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://pronunciation-assessment1.p.rapidapi.com/pronunciation"),
                Headers =
                {
                   { "x-rapidapi-host", "pronunciation-assessment1.p.rapidapi.com" },
                   { "x-rapidapi-key", "350f660195msh59f495a7db6352dp15c559jsn90c3257ca551" },
                },
                Content = new StringContent("{\r\"audio_base64\": \"" + requestModel.audio_base64 + "\",\r\"audio_format\": \"" + requestModel.audio_format + "\",\r\"text\": \"" + requestModel.text + "\"\r}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<PronunciationAssessmentResponse>(body);
            }

            return result;
        }
    }
}

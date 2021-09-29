using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using Estant.Service.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Mappings
{
    public static class VocabularyMapping
    {
        public static TopicDTO ArrayJsonToTopic(this string json, string title)
        {
            TopicDTO topic = null;
            JArray arrJson = JArray.Parse(json);

            if (arrJson != null && arrJson.Count != 0)
            {
                topic = new TopicDTO()
                {
                    title = title
                };

                foreach (var data in arrJson)
                {
                    topic.vocabularies.Add(data["word"].ToString());
                }
            }
            return topic;
        }

        public static VocabularyDTO ArrayJsonToVocabulary(this string json, string topic)
        {
            VocabularyDTO vocabulary = null;

            try
            {
                JArray arrJson = JArray.Parse(json);
                if (arrJson != null && arrJson.Count > 0)
                {
                    var objJson = arrJson[0];
                    vocabulary = objJson.ToObject<VocabularyDTO>();
                    vocabulary.topic = topic;

                    #region gán lại thông tin cần lấy
                    var phonetic = objJson["phonetics"][0];
                    if (phonetic["audio"] == null)
                    {
                        vocabulary.audio = "https://ssl.gstatic.com/dictionary/static/sounds/oxford/" + objJson["word"] + "--_us_1.mp3";
                    }
                    else
                    {
                        vocabulary.phonetic = phonetic["text"].ToString();
                        vocabulary.audio = phonetic["audio"].ToString();
                    }
                    #endregion
                }
            }
            catch
            {
                vocabulary = null;
            }

            return vocabulary;
        }
    }
}

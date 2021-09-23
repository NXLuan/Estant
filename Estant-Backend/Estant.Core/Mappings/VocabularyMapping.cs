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
        public static VocabularyViewModel ToViewModel(this VocabularyDTO dto)
        {
            VocabularyViewModel vm = null;

            if (dto != null)
            {
                vm = new VocabularyViewModel()
                {
                    Word = dto.word,
                    LinkPronounce = "https://ssl.gstatic.com/dictionary/static/sounds/oxford/" + dto.word + "--_us_1.mp3",
                };
            }

            return vm;
        }

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
                    topic.vocabularies.Add(new VocabularyDTO()
                    {
                        word = data["word"].ToString()
                    });
                }
            }
            return topic;
        }

        public static VocabularyDTO ArrayJsonToVocabulary(this string json)
        {
            VocabularyDTO vocabulary = null;

            JArray arrJson = JArray.Parse(json);
            if (arrJson != null && arrJson.Count > 0)
            {
                var objJson = arrJson[0];
                vocabulary = objJson.ToObject<VocabularyDTO>();

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

            return vocabulary;
        }
    }
}

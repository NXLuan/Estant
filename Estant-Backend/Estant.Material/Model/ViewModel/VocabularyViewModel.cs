using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class TopicViewModel
    {
        public string title { get; set; }
        public string imageUrl { get; set; }
    }
    public class VocabularyViewModel
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<Dictionary<string, object>> meanings { get; set; }

        public Dictionary<string, object> GetFirstDefinitionDictionary()
        {
            Dictionary<string, object> result = null;

            if (meanings != null && meanings.Count > 0)
            {
                var definitions = meanings[0]["definitions"] as List<object>;
                result = definitions[0] as Dictionary<string, object>;
            }

            return result;
        }

        public string GetFirstDefiniton()
        {
            var keyValuePairs = GetFirstDefinitionDictionary();
            return keyValuePairs?["definition"]?.ToString();
        }

        public string GetFirstExample()
        {
            var keyValuePairs = GetFirstDefinitionDictionary();
            return keyValuePairs?["example"]?.ToString();
        }

        public string GetFirstPartOfSpeech()
        {
            return meanings[0]["partOfSpeech"].ToString();
        }
    }

}

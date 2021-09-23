using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.DTOModel
{
    public class TopicDTO
    {
        public string title { get; set; }
        public List<VocabularyDTO> vocabularies { get; set; }
        public string imageUrl { get; set; }
        public TopicDTO()
        {
            vocabularies = new List<VocabularyDTO>();
        }
    }

    public class VocabularyDTO
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<MeaningDTO> meanings { get; set; }

        public class MeaningDTO
        {
            public string partOfSpeech { get; set; }
            public List<DefinitionDTO> definitions { get; set; }

            public class DefinitionDTO
            {
                public string definition { get; set; }
                public string example { get; set; }
                public List<string> synonyms { get; set; }
                public List<string> antonyms { get; set; }
            }
        }
    }
}

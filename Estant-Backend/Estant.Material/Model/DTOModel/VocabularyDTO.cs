using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.DTOModel
{
    public class TopicDTO
    {
        public string ID { get; set; }
        public List<VocabularyDTO> VOCABULARIES { get; set; }
        public string TITLE { get; set; }
        public string IMAGEURL { get; set; }
    }

    public class VocabularyDTO
    {
        public string WORD { get; set; }
        public string PHONETIC { get; set; }
        public string AUDIO { get; set; }
        public List<Meaning> MEANINGS { get; set; }

        public class Meaning
        {
            public string PARTOFSPEECH { get; set; }
            public List<Definition> DEFINITIONS { get; set; }

            public class Definition
            {
                public string DEFINITION { get; set; }
                public string EXAMPLE { get; set; }
                public List<string> SYNONYMS { get; set; }
                public List<string> ANTONYMS { get; set; }
            }
        }
    }
}

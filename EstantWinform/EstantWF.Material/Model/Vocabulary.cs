using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class Topic
    {
        public string title { get; set; }
        public string imageUrl { get; set; }
    }

    public class Vocabulary
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string audio { get; set; }
        public List<Meaning> meanings { get; set; }

        public class Meaning
        {
            public string partOfSpeech { get; set; }
            public List<Definition> definitions { get; set; }

            public class Definition
            {
                public string definition { get; set; }
                public string example { get; set; }
                public List<string> synonyms { get; set; }
                public List<string> antonyms { get; set; }
            }
        }
    }
}

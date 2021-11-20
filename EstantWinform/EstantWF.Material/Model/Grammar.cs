using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class Grammar
    {
        public string title { get; set; }
        public List<Lesson> lessons { get; set; }
        public class Lesson
        {
            public string code { get; set; }
            public string name { get; set; }
        }
    }

    public class SpellAndGrammarCheck
    {
        public string message { get; set; }
        public string replacement { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }
}

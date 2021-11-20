using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class Exercise
    {
        public int type { get; set; }
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public string audio { get; set; }
        public List<string> choices { get; set; }
        public string example { get; set; }
        public string missingWord { get; set; }
        public string definition { get; set; }
        public string word { get; set; }
        public string userAnswer { get; set; }
        public string sentence { get; set; }
    }
}

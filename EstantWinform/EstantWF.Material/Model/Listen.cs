using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class Listen
    {
        public int count { get; set; }
        public List<Episode> results { get; set; }
        public class Episode
        {
            public string audio { get; set; }
            public string image { get; set; }
            public string thumbnail { get; set; }
            public string description_original { get; set; }
            public string title_original { get; set; }
        }
    }
}

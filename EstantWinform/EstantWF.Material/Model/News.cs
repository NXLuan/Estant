using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class News
    {
        public Source source { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }

        public class Source
        {
            public string name { get; set; }
        }
    }
}

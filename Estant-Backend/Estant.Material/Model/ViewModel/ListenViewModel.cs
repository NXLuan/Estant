using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class ListenViewModel
    {
        public int count { get; set; }
        public List<Episodes> results { get; set; }
        public class Episodes
        {
            public string audio { get; set; }
            public string image { get; set; }
            public string thumbnail { get; set; }
            public string description_original { get; set; }
            public string title_original { get; set; }
        }
    }
}

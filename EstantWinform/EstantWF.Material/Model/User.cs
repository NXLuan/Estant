using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class User
    {
        public string token { get; set; }
        public string email { get; set; }
        public string displayName { get; set; }
        public string photoUrl { get; set; }
    }
}

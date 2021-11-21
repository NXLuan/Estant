using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class SignInRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class SignUpRequest
    {
        public string displayName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.DTOModel
{
    public class UserDTO
    {
        public string UID { get; set; }
        public string EMAIL { get; set; }
        public string DISPLAYNAME { get; set; }
        public string PHOTOURL { get; set; }
        public bool ISEMAILVERIFIED { get; set; }
    }
}

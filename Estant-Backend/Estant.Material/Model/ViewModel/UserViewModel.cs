using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class UserViewModel
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string PhotoUrl { get; set; }
        public List<string> SavedWords { get; set; }
    }
}

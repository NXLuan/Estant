using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Core.Handlers
{
    public class UserHandler
    {
        private readonly IUserService _userService;
        public UserHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<List<string>> SaveWord(string uid, string word)
        {
            return await _userService.SaveWord(uid, word);
        }
    }
}

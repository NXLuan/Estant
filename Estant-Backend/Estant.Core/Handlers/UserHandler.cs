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
            List<string> data = null;
            var user = await _userService.Get(uid);
            if (user != null)
            {
                user.savedwords.Insert(0, word);
                var IsSuccess = await _userService.UpdateSaveWord(uid, user.savedwords);
                if (IsSuccess)
                    data = user.savedwords;
            }
            return data;
        }

        public async Task<List<string>> UnSaveWord(string uid, string word)
        {
            List<string> data = null;
            var user = await _userService.Get(uid);
            if (user != null)
            {
                user.savedwords.RemoveAll(w => w.Trim().ToLower().Equals(word?.Trim().ToLower()));
                var IsSuccess = await _userService.UpdateSaveWord(uid, user.savedwords);
                if (IsSuccess)
                    data = user.savedwords;
            }
            return data;
        }
    }
}

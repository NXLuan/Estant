﻿using Estant.Material.Model.DTOModel;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IUserService
    {
        public Task<User> Get(string uid);
        public void Add(string uid);
        public Task<List<string>> SaveWord(string uid, string word);
    }
}

using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.LocalDataService
{
    public class LocalGrammarService : BaseLocalService, IGrammarService
    {
        public LocalGrammarService() : base("grammar.json") { }
        public async Task<string> GetAll()
        {
            return await ReadData();
        }
    }
}

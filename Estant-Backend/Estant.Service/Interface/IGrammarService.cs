using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IGrammarService
    {
        public Task<string> GetAll();
    }
}

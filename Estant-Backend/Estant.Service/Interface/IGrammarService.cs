using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IGrammarService
    {
        public Task<string> GetAll();
        public Task<string> GetHtmlContent(string code);
        public Task<string> GetExercise(string code);
    }
}

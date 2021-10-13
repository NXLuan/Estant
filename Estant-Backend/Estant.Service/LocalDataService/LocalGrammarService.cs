using Estant.Material.Utilities;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.LocalDataService
{
    public class LocalGrammarService : IGrammarService
    {
        private string _rootPath;
        public LocalGrammarService()
        {
            _rootPath = "../Estant.Resource";
        }
        public async Task<string> GetAll()
        {
            // return await ReadData();
            return string.Empty;
        }

        public async Task<string> GetHtmlContent(string filePath)
        {
            return await FileHelper.ReadFileAsync(_rootPath +"/ViewContent/"+ filePath);
        }
    }
}

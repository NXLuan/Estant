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
            return await FileHelper.ReadFileAsync(_rootPath + "/JsonData/grammar.json");
        }

        public async Task<string> GetHtmlContent(string code)
        {
            string content = null;
            string html = await FileHelper.ReadFileAsync(_rootPath + "/ViewContent/html/" + code + ".html");
            string css = await FileHelper.ReadFileAsync(_rootPath + "/ViewContent/css/global.css");
            if (html != null)
            {
                content = html.Insert(html.IndexOf("</style>"), css);
            }
            return content;
        }

        public async Task<string> GetExercise(string code){
            return await FileHelper.ReadFileAsync(_rootPath + "/JsonData/" + code + ".json");
        }
    }
}

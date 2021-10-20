using Estant.Core.Mappings;
using Estant.Material;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using Estant.Service.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Core.Handlers
{
    public class GrammarHandler
    {
        private readonly IGrammarService _grammarService;
        public GrammarHandler(IGrammarService grammarService)
        {
            _grammarService = grammarService;
        }

        public async Task<List<GrammarViewModel>> GetAll()
        {
            List<GrammarViewModel> data = new List<GrammarViewModel>();
            var json = await _grammarService.GetAll();
            if (json != null)
                data = json.ConvertToGrammarView();
            return data;
        }
        public async Task<string> GetHtmlContent(string code)
        {
            return await _grammarService.GetHtmlContent(code);
        }

        public async Task<List<object>> GetExercise(string code)
        {
            List<object> exerciseViewModels = new List<object>();
            var jsonString = await _grammarService.GetExercise(code);
            if (jsonString != null)
            {
                JArray arrJson = JArray.Parse(jsonString);
                if (arrJson != null && arrJson.Count != 0)
                {
                    RandomSelectIndex random = new RandomSelectIndex(arrJson.Count);
                    int count = arrJson.Count >= ConfigConstants.NumOfQuestion ? ConfigConstants.NumOfQuestion : arrJson.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var quiz = arrJson[i].DeserializeGrammarExe();
                        if (quiz != null)
                            exerciseViewModels.Add(quiz);
                    }
                }
            }
            return exerciseViewModels;
        }
    }
}

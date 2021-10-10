using Estant.Core.Mappings;
using Estant.Material.Model.ViewModel;
using Estant.Service.Interface;
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
    }
}

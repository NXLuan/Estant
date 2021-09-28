using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IVocabularyService
    {
        public Task<VocabularyViewModel> Get(string word);
        public void Add(VocabularyDTO dto);
        public Task<string> Delete(string word);
    }
}

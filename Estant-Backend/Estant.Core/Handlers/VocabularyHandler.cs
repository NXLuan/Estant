using Estant.Material.Model.ViewModel;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Estant.Core.Mappings;

namespace Estant.Core.Handlers
{
    public class VocabularyHandler
    {
        private readonly IVocabularyService _vocabularyService;
        public VocabularyHandler(IVocabularyService vocabularyService)
        {
            _vocabularyService = vocabularyService;
        }
        public List<VocabularyViewModel> GetAll()
        {
            List<VocabularyViewModel> data = new List<VocabularyViewModel>();

            var result = _vocabularyService.GetAll();
            result.ForEach(e => data.Add(e.ToViewModel()));

            return data;
        }
    }
}

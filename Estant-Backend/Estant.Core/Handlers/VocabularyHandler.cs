using Estant.Material.Model.ViewModel;
using Estant.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Estant.Core.Mappings;
using Estant.Service.ApiService;
using System.Threading.Tasks;
using Estant.Service.Model;
using Estant.Material;

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
            result?.ForEach(e => data.Add(e.ToViewModel()));

            return data;
        }

        public async Task<Topic> AddByTopic(string title)
        {
            Topic data = null;
            var jsonTopic = await VocabularyApi.GetByTopic(title);

            if (jsonTopic != null)
            {
                data = jsonTopic.ArrayJsonToTopic(title);

                #region Lấy thông tin từ vựng theo Dictionary
                if (data.vocabularies.Count != 0)
                {
                    List<Vocabulary> list = new List<Vocabulary>();
                    for (int i = 0; i < ConfigConstants.WordCountPerTopic; i++)
                    {
                        var jsonVocabulary = await VocabularyApi.GetFromDictionary(data.vocabularies[i].word).ConfigureAwait(false);

                        if (jsonVocabulary != null)
                        {
                            var vocabulary = jsonVocabulary.ArrayJsonToVocabulary();
                            if (vocabulary != null)
                                list.Add(vocabulary);
                        }
                    }

                    data.vocabularies = list;
                }
                #endregion
            }

            return data;
        }
    }
}

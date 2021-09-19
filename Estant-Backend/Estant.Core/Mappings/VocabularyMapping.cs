using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Mappings
{
    public static class VocabularyMapping
    {
        public static VocabularyViewModel ToViewModel(this VocabularyDTO dto)
        {
            VocabularyViewModel vm = null;

            if (dto != null)
            {
                vm = new VocabularyViewModel()
                {
                    Word = dto.WORD,
                    LinkPronounce = "https://ssl.gstatic.com/dictionary/static/sounds/oxford/" + dto.WORD + "--_us_1.mp3",
                };
            }

            return vm;
        }
    }
}

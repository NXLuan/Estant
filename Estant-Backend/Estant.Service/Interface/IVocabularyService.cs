using Estant.Material.Model.DTOModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Service.Interface
{
    public interface IVocabularyService
    {
        public List<VocabularyDTO> GetAll();
    }
}

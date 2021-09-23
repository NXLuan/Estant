﻿using Estant.Material.Model.DTOModel;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.Interface
{
    public interface IVocabularyService
    {
        public List<VocabularyDTO> GetAll();
        public Task<VocabularyDTO> Add(VocabularyDTO dto);
    }
}

using Estant.Material.Model.DTOModel;
using Estant.Service.Interface;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Service.FirebaseService
{
    public class VocabularyFirestoreService : IVocabularyService
    {
        FirestroreRepository<Vocabulary> repository;

        public VocabularyFirestoreService()
        {
            repository = new FirestroreRepository<Vocabulary>("Vocabulary");
        }

        public List<VocabularyDTO> GetAll()
        {
            List<VocabularyDTO> list = new List<VocabularyDTO>();

            var result = repository.GetAll();
            result.ForEach(e => list.Add(new VocabularyDTO()
            {
                WORD = e.word,
            }));

            return list;
        }
    }
}

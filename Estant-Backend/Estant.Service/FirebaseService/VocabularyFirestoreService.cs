using Estant.Material.Model.DTOModel;
using Estant.Service.Interface;
using Estant.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.FirebaseService
{
    public class VocabularyFirestoreService : IVocabularyService
    {
        FirestroreRepository<Vocabulary> repository;

        public VocabularyFirestoreService()
        {
            repository = new FirestroreRepository<Vocabulary>("Vocabulary");
        }

        public async Task<VocabularyDTO> Add(VocabularyDTO dto)
        {
            if (dto == null) return null;
            Vocabulary vocabulary = new Vocabulary()
            {
                id = dto.word,
                phonetic = dto.phonetic,
                audio = dto.audio,
            };

            foreach (var meaning in dto.meanings)
            {
                #region parse meaning

                #region parse definition
                List<Dictionary<string, object>> definitions = new List<Dictionary<string, object>>();
                meaning.definitions?.ForEach(definition =>
                {
                    Dictionary<string, object> dicDefinition = new Dictionary<string, object>()
                    {
                        { "definition", definition.definition },
                        { "example", definition.example },
                        { "synonyms", definition.antonyms },
                        { "antonyms", definition.antonyms }
                    };
                    definitions.Add(dicDefinition);
                });
                #endregion

                Dictionary<string, object> dicMeaning = new Dictionary<string, object>()
                {
                    {"partOfSpeech", meaning.partOfSpeech },
                    {"definitions",  definitions}
                };
                #endregion

                vocabulary.meanings.Add(dicMeaning);
            }

            var result = await repository.Update(vocabulary);

            if (result) return dto;
            return null;
        }

        public List<VocabularyDTO> GetAll()
        {
            List<VocabularyDTO> list = new List<VocabularyDTO>();

            var result = repository.GetAll();
            result.ForEach(e => list.Add(new VocabularyDTO()
            {
                //WORD = e.word,
            }));

            return list;
        }
    }
}

using Estant.Material.Model.DTOModel;
using Estant.Material.Model.ViewModel;
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

        public void Add(VocabularyDTO dto)
        {
            if (dto == null) return;
            Vocabulary vocabulary = new Vocabulary()
            {
                topic = dto.topic,
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

            repository.Set(vocabulary);
        }

        public async Task<string> Delete(string word)
        {
            string result = string.Empty;

            var vocabResult = await repository.Get(word);
            if (vocabResult != null)
            {
                repository.Delete(vocabResult);
                result = vocabResult.topic;
            }

            return result;
        }

        public async Task<VocabularyViewModel> Get(string word)
        {
            VocabularyViewModel vm = null;

            var result = await repository.Get(word);
            if (result != null)
            {
                vm = new VocabularyViewModel()
                {
                    word = result.id,
                    phonetic = result.phonetic,
                    audio = result.audio,
                    meanings = result.meanings
                };
            }

            return vm;
        }
    }
}

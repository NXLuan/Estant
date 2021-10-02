using Estant.Material.Model.DTOModel;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Core.Helpers
{
    public static class VocabExeHelper
    {
        /// <summary>
        /// Fill in the blanks
        /// </summary>
        /// <param name="vocabularyDTO"></param>
        public static object CreateType1(string word, string definition, string partOfSpeech)
        {
            VocabExeType1 exeType1 = null;
            if (!string.IsNullOrEmpty(word))
            {
                #region main algorithm
                StringBuilder missWord = new StringBuilder(word);
                // hide 1/2 characters in a word
                int numHideChar = missWord.Length / 2;
                RandomSelectIndex random = new RandomSelectIndex(word.Length);

                for (int i = 0; i < numHideChar; i++)
                {
                    int index = random.GetIndexRandom();
                    missWord[index] = '_';
                }
                #endregion

                exeType1 = new VocabExeType1()
                {
                    CorrectAnswer = word,
                    MissingWord = missWord.ToString(),
                    Definition = definition,
                    PartOfSpeech = partOfSpeech,
                };
                exeType1.SetQuestion(TypeQuestion.FillBlank);
            }
            return exeType1;
        }

        private static VocabExeType1 Type2(string word, string definition, string partOfSpeech)
        {
            VocabExeType1 exeType1 = null;
            if (!string.IsNullOrEmpty(word))
            {
                #region main algorithm
                StringBuilder missWord = new StringBuilder(word);
                // hide 1/2 characters in a word
                int numHideChar = missWord.Length / 2;
                var indexList = Enumerable.Range(0, missWord.Length - 1).ToList();

                Random r = new Random();
                for (int i = 0; i < numHideChar; i++)
                {
                    int rInt = r.Next(0, indexList.Count);
                    missWord[indexList[rInt]] = '_';
                    indexList.RemoveAt(rInt);
                }
                #endregion

                exeType1 = new VocabExeType1()
                {
                    CorrectAnswer = word,
                    MissingWord = missWord.ToString(),
                    Definition = definition,
                    PartOfSpeech = partOfSpeech,
                };
            }
            return exeType1;
        }
    }
}

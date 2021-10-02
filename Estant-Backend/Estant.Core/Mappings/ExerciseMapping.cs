using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Mappings
{
    public static class ExerciseMapping
    {
        /// <summary>
        /// Fill in the blanks
        /// </summary>
        /// <param name="vocab"></param>
        /// <returns></returns>
        public static object FillBlankExe(this VocabularyViewModel vocab)
        {
            FillBlankExe fillBlank = null;

            #region Parse value from vocab
            string word = vocab.word;
            var definitions = vocab.meanings[0]["definitions"] as List<object>;
            var keyValuePairs = definitions[0] as Dictionary<string, object>;
            string definition = keyValuePairs["definition"].ToString();
            string partOfSpeech = vocab.meanings[0]["partOfSpeech"].ToString();
            #endregion

            if (!string.IsNullOrEmpty(word))
            {
                #region Main algorithm
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

                fillBlank = new FillBlankExe()
                {
                    CorrectAnswer = word,
                    MissingWord = missWord.ToString(),
                    Definition = definition,
                    PartOfSpeech = partOfSpeech,
                };
                fillBlank.SetQuestion(TypeQuestion.FillBlank);
            }

            return fillBlank;
        }

        /// <summary>
        /// Choose the most suitable word from the given example
        /// </summary>
        /// <param name="vocab"></param>
        /// <param name="answers"></param>
        /// <returns></returns>
        public static object ChooseWordByExampleExe(this VocabularyViewModel vocab, List<VocabularyViewModel> vocabList)
        {
            ExerciseViewModel exercise = null;
            if (vocab != null && vocabList != null)
            {
                #region Parse necessary information
                int n = vocabList.Count;
                string word = vocab.word;
                var definitions = vocab.meanings[0]["definitions"] as List<object>;
                var keyValuePairs = definitions[0] as Dictionary<string, object>;
                var example = keyValuePairs["example"];
                if (example == null || n < 3)
                {
                    exercise = vocab.FillBlankExe() as FillBlankExe;
                    goto Finish;
                }

                StringBuilder exampleBuilder = new StringBuilder(example.ToString());
                string replaceString = "";
                for (int i = 0; i < word.Length; i++)
                {
                    replaceString += "_";
                }
                exampleBuilder = exampleBuilder.Replace(word, replaceString);

                #region Handle list answer
                int position = vocabList.IndexOf(vocab);
                RandomSelectIndex random = new RandomSelectIndex(n);
                // remove position of correct answer to avoid random 
                random.RemoveIndex(position);

                List<string> answers = new List<string>();
                // get 3 different answers 
                for (int i = 0; i < 3; i++)
                {
                    int index = random.GetIndexRandom();
                    answers.Add(vocabList[index].word);
                }
                #endregion

                #endregion

                exercise = new ChooseWordByExampleExe()
                {
                    CorrectAnswer = word,
                    Answers = answers,
                    Example = exampleBuilder.ToString(),
                };
                exercise.SetQuestion(TypeQuestion.ChooseWordByExample);
            }

        Finish:
            return exercise;
        }
    }
}

using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using Estant.Material.Utilities;
using Newtonsoft.Json.Linq;
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
        public static object GenFillBlankExe(this VocabularyViewModel vocab)
        {
            FillBlankExe exercise = null;

            #region Parse value from vocab
            string word = vocab.word;
            string definition = vocab.GetFirstDefiniton();
            #endregion

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

            exercise = new FillBlankExe()
            {
                CorrectAnswer = word,
                MissingWord = missWord.ToString(),
                Definition = definition,
            };
            exercise.SetQuestion(TypeQuestion.FillBlank);

            return exercise;
        }

        /// <summary>
        /// Choose the most suitable word from the given example
        /// </summary>
        /// <param name="vocab"></param>
        /// <param name="answers"></param>
        /// <returns></returns>
        public static object GenChooseWordByExampleExe(this VocabularyViewModel vocab, List<VocabularyViewModel> vocabList)
        {
            ChooseWordByExampleExe exercise = null;

            #region Parse necessary information
            int n = vocabList.Count;
            string word = vocab.word;
            string example = vocab.GetFirstExample();

            // Check not have example or list vocabulary less than 4, return exercise listen and write word
            if (example == null || n < 4)
            {
                return vocab.GenWriteWordByAudioExe();
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

            List<string> choices = new List<string>();
            // get 3 different answers 
            for (int i = 0; i < 3; i++)
            {
                int index = random.GetIndexRandom();
                choices.Add(vocabList[index].word);
            }

            #region Insert correct answer to choices
            Random rand = new Random();
            int correctIndex = rand.Next(0, 4);
            choices.Insert(correctIndex, word);
            #endregion

            #endregion

            #endregion

            exercise = new ChooseWordByExampleExe()
            {
                CorrectAnswer = correctIndex,
                Choices = choices,
                Example = exampleBuilder.ToString(),
            };
            exercise.SetQuestion(TypeQuestion.ChooseWordByExample);

            return exercise;
        }

        /// <summary>
        /// Choose the meaning of this word
        /// </summary>
        /// <param name="vocab"></param>
        /// <param name="vocabList"></param>
        /// <returns></returns>
        public static object GenChooseMeaningByWordExe(this VocabularyViewModel vocab, List<VocabularyViewModel> vocabList)
        {
            ChooseMeaningByWordExe exercise = null;

            #region Parse necessary information
            int n = vocabList.Count;
            string word = vocab.word;

            // Check list vocabulary less than 4, return exercise fill blank
            if (n < 4)
            {
                return vocab.GenFillBlankExe();
            }

            #region Handle list answer
            int position = vocabList.IndexOf(vocab);
            RandomSelectIndex random = new RandomSelectIndex(n);
            // remove position of correct answer to avoid random 
            random.RemoveIndex(position);

            List<string> choices = new List<string>();
            // get 3 different answers 
            for (int i = 0; i < 3; i++)
            {
                int index = random.GetIndexRandom();
                choices.Add(vocabList[index].GetFirstDefiniton());
            }

            #region Insert correct answer to choices
            Random rand = new Random();
            int correctIndex = rand.Next(0, 4);
            choices.Insert(correctIndex, vocab.GetFirstDefiniton());
            #endregion

            #endregion

            #endregion

            exercise = new ChooseMeaningByWordExe()
            {
                CorrectAnswer = correctIndex,
                Word = word,
                Choices = choices,
            };
            exercise.SetQuestion(TypeQuestion.ChooseMeaningByWord);

            return exercise;
        }


        /// <summary>
        /// Write the correct word
        /// </summary>
        /// <param name="vocab"></param>
        /// <returns></returns>
        public static object GenWriteWordByAudioExe(this VocabularyViewModel vocab)
        {
            var exercise = new WriteWordByAudioExe()
            {
                Audio = vocab.audio,
                CorrectAnswer = vocab.word,
            };
            exercise.SetQuestion(TypeQuestion.WriteWordByAudio);

            return exercise;
        }

        public static object DeserializeGrammarExe(this JToken objJson)
        {
            object quiz = null;
            int typeQuiz = int.Parse(objJson["Type"].ToString());
            switch (typeQuiz)
            {
                case (int)TypeQuestion.FillBlankGrammar:
                    quiz = objJson.ToObject<FillBlankGramarExe>();
                    break;
                case (int)TypeQuestion.ChooseCorrectAnswer:
                    quiz = objJson.ToObject<ChooseCorrectAnswerGramarExe>();
                    break;
            }
            return quiz;
        }
    }
}

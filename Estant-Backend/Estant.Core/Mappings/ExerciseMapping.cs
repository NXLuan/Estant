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
            ExerciseViewModel exercise = null;

            #region Parse necessary information
            int n = vocabList.Count;
            string word = vocab.word;
            string example = vocab.GetFirstExample();
            if (example == null || n < 3)
            {
                exercise = vocab.GenWriteWordByAudioExe() as WriteWordByAudioExe;
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

        Finish:
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
            ExerciseViewModel exercise = null;

            #region Parse necessary information
            int n = vocabList.Count;
            string word = vocab.word;

            if (n < 3)
            {
                exercise = vocab.GenFillBlankExe() as FillBlankExe;
                goto Finish;
            }

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
                answers.Add(vocabList[index].GetFirstDefiniton());
            }
            #endregion

            #endregion

            exercise = new ChooseMeaningByWordExe()
            {
                CorrectAnswer = vocab.GetFirstDefiniton(),
                word = word,
                Answers = answers,
            };
            exercise.SetQuestion(TypeQuestion.ChooseMeaningByWord);

        Finish:
            return exercise;
        }

        public static object GenWriteWordByAudioExe(this VocabularyViewModel vocab)
        {
            var exercise = new WriteWordByAudioExe()
            {
                audio = vocab.audio,
                CorrectAnswer = vocab.word,
            };
            exercise.SetQuestion(TypeQuestion.WriteWordByAudio);

            return exercise;
        }
    }
}

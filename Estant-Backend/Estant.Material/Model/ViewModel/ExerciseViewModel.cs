using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class ExerciseViewModel<T>
    {
        public int Type { get; set; }
        public string Question { get; set; }
        public T CorrectAnswer { get; set; }
        public void SetQuestion(TypeQuestion typeExe)
        {
            if (this != null)
            {
                Type = (int)typeExe;
                Question = typeExe.ToDescription();
            }
        }
    }

    #region Vocabulary exercise
    public class FillBlankExe : ExerciseViewModel<string>
    {
        public string MissingWord { get; set; }
        public string Definition { get; set; }
    }

    public class ChooseWordByExampleExe : ExerciseViewModel<int>
    {
        public List<string> Choices { get; set; }
        public string Example { get; set; }
    }

    public class ChooseMeaningByWordExe : ExerciseViewModel<int>
    {
        public List<string> Choices { get; set; }
        public string Word { get; set; }
    }

    public class WriteWordByAudioExe : ExerciseViewModel<string>
    {
        public string Audio { get; set; }
    }
    #endregion

    #region Grammar exercise
    public class FillBlankGramarExe : ExerciseViewModel<string>
    {
        public string Sentence { get; set; }
        public FillBlankGramarExe()
        {
            SetQuestion(TypeQuestion.FillBlankGrammar);
        }
    }
    public class ChooseCorrectAnswerGramarExe : ExerciseViewModel<int>
    {
        public string Sentence { get; set; }
        public List<string> Choices { get; set; }
        public ChooseCorrectAnswerGramarExe()
        {
            SetQuestion(TypeQuestion.ChooseCorrectAnswer);
        }
    }
    #endregion
}

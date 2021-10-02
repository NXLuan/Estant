using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class ExerciseViewModel
    {
        public int type { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public void SetQuestion(TypeQuestion typeExe)
        {
            if (this != null)
            {
                type = (int)typeExe;
                Question = typeExe.ToDescription();
            }
        }
    }

    #region Vocabulary exercise
    public class FillBlankExe: ExerciseViewModel
    {
        public string MissingWord { get; set; }
        public string Definition { get; set; }
        public string PartOfSpeech { get; set; }
    }

    public class ChooseWordByExampleExe : ExerciseViewModel
    {
        public List<string> Answers { get; set; }
        public string Example { get; set; }
    }

    public class ChooseMeaningByWordExe: ExerciseViewModel
    {
        public List<string> Answers { get; set; }
        public string word { get; set; }
    }

    #endregion
}

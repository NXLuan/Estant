using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Material.Model.ViewModel
{
    public class ExerciseViewModel
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public void SetQuestion(FormQuestion form)
        {
            if (this != null)
            {
                Question = form.ToDescription();
            }
        }
    }

    #region Vocabulary exercise
    public class VocabExeForm1: ExerciseViewModel
    {
        public string MissingWord { get; set; }
        public string Definition { get; set; }
        public string PartOfSpeech { get; set; }
    }
    #endregion
}

using Estant.Material.Model.DTOModel;
using Estant.Material.Model.EnumModel;
using Estant.Material.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Helpers
{
    public static class VocabExeHelper
    {
        public static ExerciseViewModel Generate(VocabularyDTO vocabularyDTO, FormQuestion form)
        {
            ExerciseViewModel exeVM = null;
            if (vocabularyDTO != null)
            {
                switch (form)
                {
                    case FormQuestion.FillBlank:
                        exeVM = Form1(vocabularyDTO.word);
                        break;
                }

                exeVM.SetQuestion(form);
            }
            return exeVM;
        }

        /// <summary>
        /// Fill in the blanks
        /// </summary>
        /// <param name="vocabularyDTO"></param>
        private static VocabExeForm1 Form1(string word)
        {
            VocabExeForm1 exeForm1 = null;
            if (!string.IsNullOrEmpty(word))
            {
                exeForm1 = new VocabExeForm1()
                {
                    CorrectAnswer = word,
                };
            }
            return exeForm1;
        }
    }
}

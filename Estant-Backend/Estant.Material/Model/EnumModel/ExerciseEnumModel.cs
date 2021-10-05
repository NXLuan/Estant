using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Estant.Material.Model.EnumModel
{
    public enum TypeQuestion
    {
        [Description("Fill in the blanks")]
        FillBlank = 1,
        [Description("Choose the most suitable word")]
        ChooseWordByExample = 2,
        [Description("Choose the meaning of this word")]
        ChooseMeaningByWord = 3,
        [Description("Listen and type the word")]
        WriteWordByAudio = 4,
    }
}

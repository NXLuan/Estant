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
        [Description("Choose the most suitable word:")]
        ChooseSuitableWord = 2,
        [Description("Choose the meaning of this word:")]
        FillBlank3 = 3,
        [Description("Write the correct word")]
        FillBlank4 = 4,
    }
}

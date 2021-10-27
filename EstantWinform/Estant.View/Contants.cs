using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.View
{
    public static class AppColor
    {
        public static Color MainColor
        {
            get => Color.FromArgb(245, 106, 77);
        }
    }

    public enum PageForm
    {
        VOCABULARY, GRAMMAR, ACCOUNT
    }
}

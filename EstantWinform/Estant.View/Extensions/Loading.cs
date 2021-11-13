using Estant.Material.Utilities;
using Estant.View.FormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.View.Extensions
{
    public static class Loading
    {
        public static void Show()
        {
            Singleton<MainForm>.Instance.ShowLoading();
        }

        public static void End()
        {
            Singleton<MainForm>.Instance.EndLoading();
        }
    }
}

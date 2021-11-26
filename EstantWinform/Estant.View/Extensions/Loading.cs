using Estant.Material.Utilities;
using Estant.View.FormUI;
using Estant.View.FormUI.PopupUI;
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
            MainForm.Instance.ShowLoading();
        }

        public static void End()
        {
            MainForm.Instance.EndLoading();
        }

        public static void ShowPopup()
        {
            PopupLoading.Instance.Show();
        }

        public static void EndPopup()
        {
            PopupLoading.Instance.Hide();
        }
    }
}

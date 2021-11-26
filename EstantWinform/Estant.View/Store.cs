using Estant.View.FormUI.VocabularyUI;
using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.View
{
    public static class Store
    {
        public static User CurrentUser { get; set; }

        public static List<string> SavedWords
        {
            get => CurrentUser?.savedWords;
            set
            {
                if (CurrentUser != null)
                {
                    CurrentUser.savedWords = value;
                    VocabularyForm.Instance.UpdateSavedWord();
                }
            }
        }
    }
}

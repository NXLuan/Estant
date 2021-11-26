using Estant.View.FormUI.AuthUI;
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
        private static User _currentUser;
        public static User CurrentUser 
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                if(value != null)
                {
                    if (string.IsNullOrEmpty(value.photoUrl)) _currentUser.photoUrl = "https://scontent.fsgn3-1.fna.fbcdn.net/v/t1.30497-1/143086968_2856368904622192_1959732218791162458_n.png?_nc_cat=1&ccb=1-5&_nc_sid=7206a8&_nc_ohc=Q_Y6W2vdkywAX_Oj3iP&_nc_ht=scontent.fsgn3-1.fna&oh=66122a39812cf5a5a3cccefa1b64a3a7&oe=61C56EF8";
                    ProfileForm.Instance.UpdateInfoUser();
                    VocabularyForm.Instance.UpdateSavedWord();
                }
            }
        }

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

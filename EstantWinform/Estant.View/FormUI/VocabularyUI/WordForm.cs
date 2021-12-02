using Estant.View.CustomControl;
using Estant.View.Extensions;
using Estant.View.FormUI.PopupUI;
using EstantNF.Core.Handlers;
using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class WordForm : Form
    {
        private Vocabulary vocabulary;
        public bool IsSavedWord { get; set; }
        public WordForm(Vocabulary vocabParam)
        {
            InitializeComponent();
            InitHandle(vocabParam);
        }

        private void InitHandle(Vocabulary vocabParam)
        {
            vocabulary = vocabParam;
            lbWord.Text = vocabulary.word;
            lbPhonetic.Text = "/ " + vocabulary.phonetic + " /";
            foreach (var meaning in vocabulary.meanings)
            {
                var meaningItem = new MeaningItem(meaning);
                meaningItem.Dock = DockStyle.Top;
                pnMeaning.Controls.Add(meaningItem);
            }

            if (Store.SavedWords.Contains(vocabulary.word))
                SetIsSaveWord(true);
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            MediaExtension.PlayMP3ByURL(vocabulary.audio);
        }

        private void pbBookMark_Click(object sender, EventArgs e)
        {
            ChangeSaveWordHandle();
        }

        public async void ChangeSaveWordHandle()
        {
            Loading.ShowPopup();

            List<string> data = null;
            string token = Store.CurrentUser.token;
            if (IsSavedWord)
                data = await UserHandler.UnSaveWord(vocabulary.word, token);
            else
                data = await UserHandler.SaveWord(vocabulary.word, token);
            if (data != null) Store.SavedWords = data;

            Loading.EndPopup();
            SetIsSaveWord(!IsSavedWord);
        }

        public void SetIsSaveWord(bool IsSaved)
        {
            IsSavedWord = IsSaved;
            pbBookMark.Image = IsSaved ? global::Estant.View.Properties.Resources.bookmark_remove : global::Estant.View.Properties.Resources.bookmark;
        }

        private void pbPronounce_Click(object sender, EventArgs e)
        {
            VocabularyForm.Instance.ShowNewTab(VocabForm.PRONOUNCE, "Pronounce", data: vocabulary);
        }
    }
}

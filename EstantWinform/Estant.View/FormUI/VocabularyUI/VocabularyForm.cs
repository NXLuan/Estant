using Estant.Material.Utilities;
using Estant.View.CustomControl;
using Estant.View.Extensions;
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
    public partial class VocabularyForm : Form
    {
        public static VocabularyForm Instance
        {
            get => Singleton<VocabularyForm>.Instance;
        }
        private List<Topic> topics;
        public VocabularyForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            LoadTopicsHandle();
            stNavigate.tabControl = tabForm;
            stNavigate.AddTab("Vocabulary");
        }

        public void UpdateSavedWord()
        {
            if (Store.SavedWords == null || Store.SavedWords.Count == 0)
                flSaveWords.Visible = false;
            else
            {
                flSaveWords.Controls.Clear();
                flSaveWords.Visible = true;
                foreach (var word in Store.CurrentUser?.savedWords)
                {
                    var savedWordItem = new SavedWordItem(word);
                    flSaveWords.Controls.Add(savedWordItem);
                }
            }
        }

        public async void LoadTopicsHandle()
        {
            Loading.Show(); // show load

            topics = await VocabularyHandler.GetAllTopic();
            if (topics != null && topics.Count > 0)
            {
                foreach (var topic in topics)
                {
                    var card = new CardItem()
                    {
                        ImgURL = topic.imageUrl,
                        Title = topic.title,
                    };

                    tableTopic.Controls.Add(card);
                }

                // add event for card control
                foreach (CardItem card in tableTopic.Controls)
                {
                    card.Selected += (s, e) =>
                    {
                        var item = s as CardItem;
                        ShowNewTab(VocabForm.TOPIC, item.Title);
                    };
                }
            }

            Loading.End(); // end load
        }

        public void ShowNewTab(VocabForm index, string tabName, object data = null)
        {
            if (string.IsNullOrEmpty(tabName)) return;
            tabForm.TabPages.Add(tabName);

            Form form = null;
            switch (index)
            {
                case VocabForm.TOPIC:
                    form = new TopicForm(tabName);
                    break;
                case VocabForm.WORD:
                    form = new WordForm(data as Vocabulary);
                    break;
                case VocabForm.FLASHCARD:
                    form = new FlashCardForm(data as List<Vocabulary>);
                    break;
                case VocabForm.PRACTICE:
                    form = new PracticeForm(data as string);
                    break;
                case VocabForm.PRONOUNCE:
                    form = new PronounceForm(data as Vocabulary);
                    break;                  
            }
            ControlExtension.ShowFormInControl(tabForm.TabPages[tabForm.TabCount - 1], form);

            stNavigate.AddTab(tabName);
        }

        private void searchBar_Search(object sender, EventArgs e)
        {
            GetDataVocabulary(searchBar.TextSearch);
        }

        public async void GetDataVocabulary(string word)
        {
            Loading.Show(); // show load
            var response = await VocabularyHandler.LookupDictionary(word);
            if (response.IsSuccess())
            {
                ShowNewTab(VocabForm.WORD, word, response.data);
            }
            else
            {
                MessageBox.Show(response.message, "Notification");
            }
            Loading.End(); // end load
        }
    }
}

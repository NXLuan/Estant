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
    public partial class TopicForm : Form
    {
        private List<Vocabulary> vocabularies;
        public TopicForm(string topic)
        {
            InitializeComponent();
            LoadDataTopic(topic);
        }

        private async void LoadDataTopic(string topic)
        {
            Loading.Show(); // show load

            vocabularies = await VocabularyHandler.GetByTopic(topic);
            foreach (var vocab in vocabularies)
            {
                var vocabItemControl = new VocabularyItem(vocab);
                flListVocab.Controls.Add(vocabItemControl);
            }

            Loading.End(); // end load
        }

        private void btnFlashCard_UserClick(object sender, EventArgs e)
        {
            VocabularyForm.Instance.ShowNewTab(VocabForm.FLASHCARD, "Flash card", data: vocabularies);
        }
    }
}

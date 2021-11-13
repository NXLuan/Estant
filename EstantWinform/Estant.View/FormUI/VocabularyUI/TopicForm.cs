using Estant.Material.Utilities;
using Estant.View.CustomControl;
using Estant.View.Extensions;
using EstantNF.Core.Handlers;
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
        public TopicForm(string topic)
        {
            InitializeComponent();
            LoadDataTopic(topic);
        }

        private async void LoadDataTopic(string topic)
        {
            Loading.Show(); // show load

            var listVocab = await VocabularyHandler.GetByTopic(topic);
            foreach (var vocab in listVocab)
            {
                var vocabItemControl = new VocabularyItem(vocab);
                flListVocab.Controls.Add(vocabItemControl);
            }

            Loading.End(); // end load
        }
    }
}

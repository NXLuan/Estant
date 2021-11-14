using Estant.View.CustomControl;
using Estant.View.Extensions;
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
            foreach(var meaning in vocabulary.meanings) 
            {
                var meaningItem = new MeaningItem(meaning);
                meaningItem.Dock = DockStyle.Top;
                pnMeaning.Controls.Add(meaningItem);
            }
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            MediaExtension.PlayMP3ByURL(vocabulary.audio);
        }
    }
}

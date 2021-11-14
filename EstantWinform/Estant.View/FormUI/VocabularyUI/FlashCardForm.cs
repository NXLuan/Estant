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
    public partial class FlashCardForm : Form
    {
        private List<Vocabulary> vocabularies;

        private int currentIndex;
        public FlashCardForm(List<Vocabulary> vocabList)
        {
            InitializeComponent();
            vocabularies = vocabList;
            currentIndex = 0;
            FetchWordToFlashCard(currentIndex);
        }

        public void FetchWordToFlashCard(int index)
        {
            pnFront.Visible = true;
            pnBack.Visible = false;
            lblWord.Text = vocabularies[index].word;
            lblPhonetic.Text = "/ " + vocabularies[index].phonetic + " /";
            lblPartOfSpeech.Text = vocabularies[index].meanings[0].partOfSpeech;
            lblDefinition.Text = vocabularies[index].meanings[0].definitions[0].definition;
            lblExample.Text = vocabularies[index].meanings[0].definitions[0].example;
            if (lblExample.Text.Length > 0) lblExample.Text = "E.g. " + lblExample.Text;
            UpdateProgressBar();
        }

        public void UpdateProgressBar()
        {
            pnCurrentCard.Width = Convert.ToInt32(((double)pnTotalCard.Width / (vocabularies.Count - 1)) * currentIndex);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            pnFront.Visible = !pnFront.Visible;
            pnBack.Visible = !pnBack.Visible;
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == vocabularies.Count)
                currentIndex = 0;
            FetchWordToFlashCard(currentIndex);
            UpdateProgressBar();
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
                currentIndex = vocabularies.Count -1;
            FetchWordToFlashCard(currentIndex);
            UpdateProgressBar();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            MediaExtension.PlayMP3ByURL(vocabularies[currentIndex].audio);
        }
    }
}

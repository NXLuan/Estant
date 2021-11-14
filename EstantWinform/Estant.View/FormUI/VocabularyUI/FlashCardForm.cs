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
        public FlashCardForm(List<Vocabulary> vocabList)
        {
            InitializeComponent();
            vocabularies = vocabList;
        }
    }
}

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
    public partial class SavedWordItem : UserControl
    {
        public SavedWordItem(string word)
        {
            InitializeComponent();
            lbWord.Text = word;
        }

        private void pbOpen_Click(object sender, EventArgs e)
        {
            VocabularyForm.Instance.GetDataVocabulary(lbWord.Text);
        }
    }
}

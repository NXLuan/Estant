using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstantWF.Material.Model.Vocabulary;

namespace Estant.View.CustomControl
{
    public partial class MeaningItem : UserControl
    {
        private Meaning meaning;
        public MeaningItem(Meaning meanParam)
        {
            InitializeComponent();
            InitHandle(meanParam);  
        }

        private void InitHandle(Meaning meanParam)
        {
            meaning = meanParam;
            lbPartOfSpeech.Text = meaning.partOfSpeech;
            foreach(var meaning in meaning.definitions)
            {

            }
        }
    }
}

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
                if (!string.IsNullOrEmpty(meaning.example))
                {
                    var labelExample = CreateLabel("E.g. " + meaning.example, isDefinition: false);
                    pnDefinition.Controls.Add(labelExample);
                }
                var labelDefinition = CreateLabel(meaning.definition, isDefinition: true);
                pnDefinition.Controls.Add(labelDefinition);
            }
        }

        private Label CreateLabel(string text, bool isDefinition)
        {
            var label = new Label();
            label.Text = text;
            label.Dock = DockStyle.Top;
            var fontStyle = isDefinition ? FontStyle.Bold : FontStyle.Italic;
            label.Font = new Font("Segoe UI Semibold", 10.2F, fontStyle, GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = isDefinition ? Color.Black : Color.FromArgb(180, 180, 180);
            return label;
        }
    }
}

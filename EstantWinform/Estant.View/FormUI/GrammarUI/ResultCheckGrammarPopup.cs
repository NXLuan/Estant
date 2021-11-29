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

namespace Estant.View.FormUI.GrammarUI
{
    public partial class ResultCheckGrammarPopup : Form
    {
        private List<SpellAndGrammarCheck> results;
        private string sentence;
        public ResultCheckGrammarPopup(string setenceParam, List<SpellAndGrammarCheck> resultParams)
        {
            InitializeComponent();
            results = resultParams;
            sentence = setenceParam;
            InitHandle();
        }

        private void InitHandle()
        {
            if (results.Count > 0)
            {
                tabForm.SelectedIndex = 1;
                int indexChar = sentence.Length - 1;
                string correcSetence = "";
                for (int i = results.Count - 1; i >= 0; i--)
                {
                    var wrong = results[i];
                    string wrongWord = sentence.Substring(wrong.offset, wrong.length);
                    var sentenceTail = sentence.Substring(wrong.offset + wrong.length, indexChar - (wrong.offset + wrong.length) + 1);
                    correcSetence = correcSetence.Insert(0, wrong.replacement + sentenceTail);
                    indexChar = wrong.offset - 1;

                    var labelWordWrong = CreateLabel($"{i + 1}. " + wrongWord, true);
                    var labelMessage = CreateLabel(wrong.message);
                    pnListWrong.Controls.Add(labelMessage);
                    pnListWrong.Controls.Add(labelWordWrong);
                }

                lbCorrectSentence.Text = correcSetence;
            }

            this.Height = label2.Height + label3.Height + pnListWrong.Height + lbCorrectSentence.Height + 60;
        }

        public Label CreateLabel(string text, bool isWordWrong = false)
        {
            var label = new Label();
            label.Font = new Font("Segoe UI Semibold", 10F, isWordWrong ? FontStyle.Bold : FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = isWordWrong ? Color.FromArgb(226, 13, 37) : Color.Black;
            label.AutoSize = true;
            label.Dock = DockStyle.Top;
            label.MaximumSize = new Size(380, 0);
            label.Text = text;
            return label;
        }
    }
}

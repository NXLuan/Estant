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
    public partial class GrammarItem : UserControl
    {
        private Grammar grammar;
        public GrammarItem(Grammar grammarParam)
        {
            InitializeComponent();
            grammar = grammarParam;
            InitHandle();
        }

        private void InitHandle()
        {
            this.Height = lbLesson.Height;
            lbLesson.Text = grammar.title;
            var lessons = grammar.lessons;
            for (int i = 0; i < lessons.Count; i++)
            {
                var lessonItem = new LessonItem(lessons[i]);
                lessonItem.Index = i + 1;
                flLessons.Controls.Add(lessonItem);
                if (i % 2 == 0) this.Height += lessonItem.Height + 20;
            }
        }
    }
}

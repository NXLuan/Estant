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
using static EstantWF.Material.Model.Grammar;

namespace Estant.View.FormUI.GrammarUI
{
    public partial class LessonItem : UserControl
    {
        private Lesson lesson;
        public int Index
        {
            set => lbIndex.Text = value.ToString();
        }

        public LessonItem(Lesson lessonParam)
        {
            InitializeComponent();
            lesson = lessonParam;
            lbGrammar.Text = lessonParam.name;
            EventHandle();
        }

        private void EventHandle()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    GrammarForm.Instance.ShowNewTab(GramForm.LESSON, lesson.name, lesson.code);
                };
            }
        }
    }
}

using Estant.Material.Utilities;
using Estant.View.Extensions;
using EstantNF.Core.Handlers;
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
    public partial class GrammarForm : Form
    {
        public static GrammarForm Instance
        {
            get => Singleton<GrammarForm>.Instance;
        }

        public GrammarForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            LoadGrammarsHandle();
            stackNavigator.tabControl = tabForm;
            stackNavigator.AddTab("Grammar");
        }

        public async void LoadGrammarsHandle()
        {
            Loading.Show(); // show load

            var grammars = await GrammarHandler.GetAll();
            foreach (var grammar in grammars)
            {
                var grammarItem = new GrammarItem(grammar);
                grammarItem.Dock = DockStyle.Top;
                pnGrammars.Controls.Add(grammarItem);
            }

            Loading.End(); // end load
        }

        public void ShowNewTab(GramForm index, string tabName, object data = null)
        {
            if (string.IsNullOrEmpty(tabName)) return;
            tabForm.TabPages.Add(tabName);

            Form form = null;
            switch (index)
            {
                case GramForm.LESSON:
                    form = new LessonForm(data as string);
                    break;
            }
            ControlExtension.ShowFormInControl(tabForm.TabPages[tabForm.TabCount - 1], form);

            stackNavigator.AddTab(tabName);
        }
    }
}

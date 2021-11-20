using Estant.Material.Utilities;
using Estant.View.FormUI.VocabularyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstantWF.Material.Model;
using Estant.View.Extensions;
using Estant.View.FormUI.GrammarUI;

namespace Estant.View.FormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            ResetSelect();
            EndLoading();
        }

        private void btnVocab_Selected(object sender, EventArgs e)
        {
            ShowForm(ScreenForm.VOCABULARY);
        }

        private void btnGrammar_Selected(object sender, EventArgs e)
        {
            ShowForm(ScreenForm.GRAMMAR);
        }

        private void btnAccount_Load(object sender, EventArgs e)
        {
            ShowForm(ScreenForm.ACCOUNT);
        }

        public void ShowForm(ScreenForm page)
        {
            ResetSelect();
            Form form = null;
            switch (page)
            {
                case ScreenForm.VOCABULARY:
                    form = VocabularyForm.Instance;
                    break;
                case ScreenForm.GRAMMAR:
                    form = GrammarForm.Instance;
                    break;
                case ScreenForm.ACCOUNT:
                    break;
            }
            ControlExtension.ShowFormInControl(pnForm, form);
        }

        public void ResetSelect()
        {
            btnVocab.IsActive = false;
            btnGrammar.IsActive = false;
            btnAccount.IsActive = false;
            btnLogOut.IsActive = false;
        }

        public void ShowLoading()
        {
            pbLoading.Visible = true;
        }

        public void EndLoading()
        {
            pbLoading.Visible = false;
        }
    }
}

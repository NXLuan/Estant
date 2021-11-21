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
using Estant.View.FormUI.NewsUI;
using Estant.View.FormUI.AuthUI;

namespace Estant.View.FormUI
{
    public partial class MainForm : Form
    {
        public User CurrentUser { get; set; }
        public static MainForm Instance
        {
            get => Singleton<MainForm>.Instance;
        }

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

        private void btnNews_Selected(object sender, EventArgs e)
        {
            ShowForm(ScreenForm.NEWS);
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
                case ScreenForm.NEWS:
                    form = NewsForm.Instance;
                    break;
                case ScreenForm.ACCOUNT:
                    break;
            }
            ControlExtension.ShowFormInControl(pnForm, form);
        }

        public void ShowAuthForm()
        {
            this.Hide();
            AuthForm.Instance.ShowDialog();
        }

        public void ResetSelect()
        {
            btnVocab.IsActive = false;
            btnGrammar.IsActive = false;
            btnNews.IsActive = false;
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

        private void btnLogOut_Selected(object sender, EventArgs e)
        {
            CurrentUser = null;
            ShowAuthForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser == null)
                ShowAuthForm();
        }
    }
}

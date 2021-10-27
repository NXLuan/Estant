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
        }

        private void btnVocab_Selected(object sender, EventArgs e)
        {
            ShowForm(PageForm.VOCABULARY);
        }

        private void btnGrammar_Selected(object sender, EventArgs e)
        {
            ShowForm(PageForm.GRAMMAR);
        }

        private void btnAccount_Load(object sender, EventArgs e)
        {
            ShowForm(PageForm.ACCOUNT);
        }

        public void ShowForm(PageForm page)
        {
            ResetSelect();
            Form form = null;
            switch (page)
            {
                case PageForm.VOCABULARY:
                    form = Singleton<VocabularyForm>.Instance;
                    break;
                case PageForm.GRAMMAR:
                    break;
                case PageForm.ACCOUNT:
                    break;
            }

            if (form != null)
            {
                pnForm.Controls.Clear();
                form.TopLevel = false;
                pnForm.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        public void ResetSelect()
        {
            btnVocab.IsActive = false;
            btnGrammar.IsActive = false;
            btnAccount.IsActive = false;
            btnLogOut.IsActive = false;
        }


    }
}

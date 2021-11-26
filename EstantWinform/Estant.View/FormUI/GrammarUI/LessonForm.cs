﻿using Estant.View.Extensions;
using EstantNF.Core.Handlers;
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
    public partial class LessonForm : Form
    {
        public LessonForm(string code)
        {
            InitializeComponent();
            LoadLessonHandle(code);
        }

        public async void LoadLessonHandle(string code)
        {
            Loading.Show(); // show load

            var htmlContent = await GrammarHandler.GetHTMLContent(code);
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.NavigateToString(htmlContent);
            //.Document.CreateElement(htmlContent);

            Loading.End(); // end load
        }

        private void btnPractice_Load(object sender, EventArgs e)
        {

        }
    }
}

using Estant.View.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.NewsUI
{
    public partial class ArticleForm : Form
    {
        public ArticleForm(string url)
        {
            InitializeComponent();
            LoadWeb(url);
        }

        private async void LoadWeb(string url)
        {
            Loading.Show(); // show load
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(url);
            Loading.End(); // show load
        }
    }
}

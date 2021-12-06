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

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class FacebookViewForm : Form
    {
        public FacebookViewForm()
        {
            InitializeComponent();
            LoadWeb("https://www.facebook.com/");
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

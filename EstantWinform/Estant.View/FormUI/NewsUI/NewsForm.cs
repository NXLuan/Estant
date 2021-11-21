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

namespace Estant.View.FormUI.NewsUI
{
    public partial class NewsForm : Form
    {
        public static NewsForm Instance
        {
            get => Singleton<NewsForm>.Instance;
        }

        public NewsForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            LoadNewsHandle();
            stackNavigator.tabControl = tabForm;
            stackNavigator.AddTab("News");
        }

        public async void LoadNewsHandle()
        {
            Loading.Show(); // show load

            var listNews = await NewsHandler.GetNewsToday();
            foreach(var news in listNews)
            {
                var newsItem = new NewsItem(news);
                flListNews.Controls.Add(newsItem);
            }

            Loading.End(); // end load
        }

        public void ShowNewTab(NewsPageForm index, string tabName, object data = null)
        {
            if (string.IsNullOrEmpty(tabName)) return;
            tabForm.TabPages.Add(tabName);

            Form form = null;
            switch (index)
            {
                case NewsPageForm.ARTICLE:
                    form = new ArticleForm(data as string);
                    break;
            }
            ControlExtension.ShowFormInControl(tabForm.TabPages[tabForm.TabCount - 1], form);

            stackNavigator.AddTab(tabName);
        }
    }
}

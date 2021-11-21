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

        private List<News> listNewsToday;

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

            listNewsToday = await NewsHandler.GetNewsToday();
            ShowNewsToday();

            Loading.End(); // end load
        }

        public void ShowNewsToday()
        {
            lbTypeNews.Text = "POPULAR NEWS TODAY";
            btnShowNewsToday.Visible = false;
            ShowListNews(listNewsToday);
        }

        public async void SearchNewsAsync(string keyword)
        {
            Loading.Show(); // show load

            var listNewsSearch = await NewsHandler.GetNewsByKeyWord(keyword);
            ShowListNews(listNewsSearch);

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

        private void searchBar_Search(object sender, EventArgs e)
        {
            var text = searchBar.TextSearch;
            if (string.IsNullOrEmpty(text.Trim()) == false)
            {
                SearchNewsAsync(text);
                lbTypeNews.Text = "NEWS ABOUT " + text.ToUpper();
                btnShowNewsToday.Visible = true;
            }
        }

        private void ShowListNews(List<News> listNews)
        {
            if (listNews== null || listNews.Count == 0)
            {
                flListNews.Visible = false;
            }
            else
            {
                flListNews.Visible = true;
                flListNews.Controls.Clear();
                foreach (var news in listNews)
                {
                    var newsItem = new NewsItem(news);
                    flListNews.Controls.Add(newsItem);
                }
            }
        }

        private void btnShowNewsToday_UserClick(object sender, EventArgs e)
        {
            ShowNewsToday();
        }
    }
}

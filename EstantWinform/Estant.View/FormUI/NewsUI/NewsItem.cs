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
    public partial class NewsItem : UserControl
    {
        private News news;
        public NewsItem(News newsParam)
        {
            InitializeComponent();
            news = newsParam;
            InitHanle();
            EventHandle();
        }

        private void InitHanle()
        {
            lbSourceName.Text = news.source.name;
            lbPublishedAt.Text = news.publishedAt.ToString();
            if (news.urlToImage != null)
                pbImage.LoadAsync(news.urlToImage);
            else pbImage.Visible = false;
            lbTitle.Text = news.title;

            #region reset size to suit
            lbTitle.MaximumSize = new Size(pnContent.Width - 30, 0);
            this.Height = lbTitle.Height + lbSourceName.Height + lbPublishedAt.Height + 30;
            #endregion
        }

        private void EventHandle()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    NewsForm.Instance.ShowNewTab(NewsPageForm.ARTICLE, "Article", news.url);
                };
            }

            foreach (Control control in pnContent.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    NewsForm.Instance.ShowNewTab(NewsPageForm.ARTICLE, "Article", news.url);
                };
            }
        }
    }
}

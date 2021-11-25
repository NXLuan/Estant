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
using static EstantWF.Material.Model.Listen;

namespace Estant.View.FormUI.ListenUI
{
    public partial class ListenForm : Form
    {
        public static ListenForm Instance
        {
            get => Singleton<ListenForm>.Instance;
        }

        private Listen data;
        public ListenForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            LoadListensHandle();
            stackNavigator.tabControl = tabForm;
            stackNavigator.AddTab("Listen");
        }

        public void ShowNewTab(ListenPageForm index, string tabName, object data = null)
        {
            if (string.IsNullOrEmpty(tabName)) return;
            tabForm.TabPages.Add(tabName);

            Form form = null;
            switch (index)
            {
                case ListenPageForm.PODCAST:
                    form = new PodcastForm(data as Episode);
                    break;
            }
            ControlExtension.ShowFormInControl(tabForm.TabPages[tabForm.TabCount - 1], form);

            stackNavigator.AddTab(tabName);
        }

        public async void LoadListensHandle()
        {
            Loading.Show(); // show load

            data = await ListenHandler.GetList();
            ShowPodcastHome();

            Loading.End(); // end load
        }

        public void ShowPodcastHome()
        {
            lbTypePodcast.Text = "PODCAST";
            lbShowPodcastsHome.Visible = false;
            ShowListPodcast(data);
        }

        private void ShowListPodcast(Listen data)
        {
            if (data == null || data.count == 0)
            {
                flListListen.Visible = false;
            }
            else
            {
                flListListen.Visible = true;
                flListListen.Controls.Clear();
                foreach (var episode in data.results)
                {
                    var podcastItem = new PodcastItem(episode);
                    flListListen.Controls.Add(podcastItem);
                }
            }
        }

        private void lbShowPodcastsHome_Click(object sender, EventArgs e)
        {
            ShowPodcastHome();
        }

        private void searchBar_Search(object sender, EventArgs e)
        {
            var text = searchBar.TextSearch;
            if (string.IsNullOrEmpty(text.Trim()) == false)
            {
                SearchPodcastAsync(text);
                lbTypePodcast.Text = "PODCASTS ABOUT " + text.ToUpper();
                lbShowPodcastsHome.Visible = true;
            }
        }

        public async void SearchPodcastAsync(string title)
        {
            Loading.Show(); // show load

            var podcasts = await ListenHandler.Search(title);
            ShowListPodcast(podcasts);

            Loading.End(); // end load
        }
    }
}

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
    public partial class PodcastItem : UserControl
    {
        private Episode episode;
        public PodcastItem(Episode episodeParam)
        {
            InitializeComponent();
            episode = episodeParam;
            InitHanle();
            EventHandle();
        }

        private void InitHanle()
        {
            lbTitle.Text = episode.title_original;
            lbDescription.Text = episode.description_original;
            pbImage.LoadAsync(episode.image);
        }

        private void EventHandle()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    ListenForm.Instance.ShowNewTab(ListenPageForm.PODCAST, "Podcast", episode);
                };
            }

            this.MouseClick += (s, e) =>
            {
                ListenForm.Instance.ShowNewTab(ListenPageForm.PODCAST, "Podcast", episode);
            };
        }
    }
}

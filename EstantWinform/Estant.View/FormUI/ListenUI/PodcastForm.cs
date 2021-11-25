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
    public partial class PodcastForm : Form
    {
        private Episode episode;
        public PodcastForm(Episode episodeParam)
        {
            InitializeComponent();
            episode = episodeParam;
            InitHandle();
        }

        private void InitHandle()
        {
            mediaPlayer.URL = episode.audio;
            pbImage.LoadAsync(episode.image);
            lbTitle.Text = episode.title_original;
            lbDescription.Text = episode.description_original;
            lbDescription.MaximumSize = new Size(pnDetail.Width - 90, 0);
        }

        private void PodcastForm_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

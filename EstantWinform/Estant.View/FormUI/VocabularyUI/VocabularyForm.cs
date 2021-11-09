using Estant.Material.Utilities;
using Estant.View.CustomControl;
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

namespace Estant.View.FormUI.VocabularyUI
{
    public partial class VocabularyForm : Form
    {
        private List<Topic> topics;
        public VocabularyForm()
        {
            InitializeComponent();
            InitHandle();
        }

        private void InitHandle()
        {
            LoadTopicsHandle();
            stNavigate.tabControl = tabForm;
            stNavigate.AddTab("Vocabulary");
        }

        public async void LoadTopicsHandle()
        {
            tableTopic.Visible = false; // show load
            topics = await VocabularyHandler.GetAllTopic();

            if (topics != null && topics.Count > 0)
            {
                foreach (var topic in topics)
                {
                    var card = new CardItem()
                    {
                        ImgURL = topic.imageUrl,
                        Title = topic.title,
                    };

                    tableTopic.Controls.Add(card);
                }

                // add event for card control
                foreach (CardItem card in tableTopic.Controls)
                {
                    card.Selected += (s, e) =>
                    {
                        var item = s as CardItem;
                        ShowTab((int)VocabForm.TOPIC, item.Title);
                    };
                }
            }

            tableTopic.Visible = true; // end load
        }

        public void ShowTab(int index, string tabName = "")
        {
            if (index >= tabForm.TabCount)
            {
                if (string.IsNullOrEmpty(tabName)) return;
                tabForm.TabPages.Add(tabName);

                Form form = null;
                switch (index)
                {
                    case (int)VocabForm.TOPIC:
                        form = new TopicForm();
                        break;
                }
                ControlExtension.ShowFormInControl(tabForm.TabPages[index], form);

                stNavigate.AddTab(tabName);
            }
        }
    }
}

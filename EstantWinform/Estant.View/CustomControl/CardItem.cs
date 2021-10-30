using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.CustomControl
{
    public partial class CardItem : UserControl
    {
        private string _imgURL;

        public string ImgURL
        {
            get => _imgURL;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _imgURL = value;
                    pbImage.LoadAsync(value);
                }
            }
        }

        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user select card")]
        public event EventHandler Selected;

        public CardItem()
        {
            InitializeComponent();
            EventHandle();
        }

        private void EventHandle()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    //bubble the event up to the parent
                    if (Selected != null)
                        Selected(this, e);
                };
            }
        }
    }
}

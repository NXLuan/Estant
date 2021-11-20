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
    public partial class TabNavigate : UserControl
    {
        public int Index { get; set; }

        public bool IsNotEndTab
        {
            get => pbArrow.Visible;
            set => pbArrow.Visible = value;
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                lbTabName.ForeColor = value ? AppColor.MainColor : AppColor.TextNormalColor;
            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user select tab")]
        public event EventHandler Selected;

        public TabNavigate(string tabname)
        {
            InitializeComponent();
            lbTabName.Text = tabname;
            this.Width = lbTabName.Size.Width + pbArrow.Size.Width;
            IsActive = true;
            EventHandle();
        }

        private void EventHandle()
        {
            foreach (Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    if (!IsActive)
                    {
                        //bubble the event up to the parent
                        if (Selected != null)
                            Selected(this, e);

                        IsActive = true;
                    }
                };
            }
        }
    }
}

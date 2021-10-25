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
    public partial class ButtonImage : UserControl
    {
        public Image NormalImage { get; set; }
        public Image ActiveImage { get; set; }

        public string TextButton
        {
            get => lbTextButton.Text;
            set => lbTextButton.Text = value;
        }

        private bool _isActive;
        public bool IsActive 
        {
            get => _isActive;
            set
            {
                _isActive = value;
                if (value)
                {
                    pbIcon.Image = ActiveImage;
                    lbTextButton.ForeColor = AppColor.MainColor;
                }
                else
                {
                    pbIcon.Image = NormalImage;
                    lbTextButton.ForeColor = Color.FromArgb(152, 152, 152);
                }
            }
        }

        public ButtonImage()
        {
            InitializeComponent();
            EventHandle();
        }

        private void EventHandle()
        {
            foreach(Control control in this.Controls)
            {
                control.MouseClick += (s, e) =>
                {
                    IsActive = !IsActive;
                };
            }
        }
    }
}

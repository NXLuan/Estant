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
    public partial class ButtonFlatImage : UserControl
    {
        private Color _normalColor;
        public Color NormalColor 
        { 
            get => _normalColor;
            set {
                _normalColor = BackColor = value;
            }
        }
        public Color HoverColor { get; set; }
        public Color ActiveColor { get; set; }

        public Color TextColor
        {
            get => lbTextButton.ForeColor;
            set => lbTextButton.ForeColor = value;
        }

        public Image IconButton 
        {
            get => pbIcon.Image;
            set => pbIcon.Image = value;
        }

        public string TextButton
        {
            get => lbTextButton.Text;
            set => lbTextButton.Text = value;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user click button")]
        public event EventHandler UserClick;

        public ButtonFlatImage()
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
                    if (UserClick != null)
                        UserClick(this, e);
                };

                control.MouseDown += (s, e) =>
                {
                    BackColor = ActiveColor;
                };

                control.MouseUp += (s, e) =>
                {
                    BackColor = NormalColor;
                };

                control.MouseEnter += (s, e) =>
                {
                    BackColor = HoverColor;
                };

                control.MouseLeave += (s, e) =>
                {
                    BackColor = NormalColor;
                };
            }
        }
    }
}

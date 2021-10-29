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
    public partial class SearchBar : UserControl
    {
        public string Hint
        {
            get => lbHint.Text;
            set => lbHint.Text = value;
        }

        public SearchBar()
        {
            InitializeComponent();
            HandleInit();
        }

        private void HandleInit()
        {
            lbHint.Parent = tbInput;
            lbHint.Location = new Point(tbInput.Location.X - 15, tbInput.Location.Y - 8);
            lbHint.BackColor = Color.Transparent;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            lbHint.Visible = string.IsNullOrEmpty(tbInput.Text);
        }

        private void lbHint_MouseDown(object sender, MouseEventArgs e)
        {
            tbInput.Focus();
        }
    }
}

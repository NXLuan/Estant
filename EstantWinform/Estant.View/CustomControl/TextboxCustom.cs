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
    public partial class TextboxCustom : UserControl
    {
        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }

        public char PassChar
        {
            get => tbInput.PasswordChar;
            set => tbInput.PasswordChar = value;
        }

        public string TextInput
        {
            get => tbInput.Text;
        }

        public TextboxCustom()
        {
            InitializeComponent();
        }
    }
}

using Estant.Material.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.FormUI.PopupUI
{
    public partial class PopupLoading : Form
    {
        public static PopupLoading Instance
        {
            get => Singleton<PopupLoading>.Instance;
        }
        public PopupLoading()
        {
            InitializeComponent();
        }
    }
}

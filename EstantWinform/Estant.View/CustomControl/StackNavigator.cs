using Estant.View.Extensions;
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
    public partial class StackNavigator : UserControl
    {
        public TabControl tabControl { get; set; }
        public StackNavigator()
        {
            InitializeComponent();
        }

        public void AddTab(string screenName)
        {
            var tabNavigate = new TabNavigate();
            tabNavigate.Index = flTab.Controls.Count;
            tabNavigate.TabName = screenName;
            tabNavigate.Selected += (s, e) =>
            {
                var tab = s as TabNavigate;
                SelectTab(tab.Index);
            };

            flTab.Controls.Add(tabNavigate);
            SelectTab(tabNavigate.Index);
        }

        public void SelectTab(int index)
        {
            while (index != flTab.Controls.Count - 1)
            {
                int endIndex = flTab.Controls.Count - 1;
                flTab.Controls.RemoveAt(endIndex);
                if (tabControl != null)
                    tabControl.TabPages.RemoveAt(endIndex);
            }
            foreach (var control in flTab.Controls)
            {
                var tab = control as TabNavigate;
                if (tab.Index != index)
                {
                    tab.IsActive = false;
                    tab.IsNotEndTab = true;
                }
                else tab.IsNotEndTab = false;
            }

            if (tabControl != null)
                tabControl.SelectedIndex = index;
        }
    }
}

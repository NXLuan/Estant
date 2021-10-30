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
        private int currentIndex;
        private List<string> tabs;
        public TabControl tabControl { get; set; }
        public StackNavigator()
        {
            InitializeComponent();
            tabs = new List<string>();
            Controls.Clear();
            currentIndex = -1;
        }

        public void AddTab(string screenName)
        {
            int n = tabs.Count;

            List<Control> controls = new List<Control>();

            if (n != 0)
            {
                #region Add arrow
                var pbArrowClone = ControlExtension.Clone<PictureBox>(pbArrow);
                pbArrowClone.Visible = true;
                pbArrow.BringToFront();
                Controls.Add(pbArrowClone);
                #endregion
            }

            #region Add tab
            var lbTabClone = ControlExtension.Clone<Label>(lbTab);
            lbTabClone.Text = screenName;
            lbTabClone.Name = screenName;
            lbTabClone.Visible = true;
            lbTabClone.Click += (s, e) =>
            {
                SelectTab(Controls.IndexOf(s as Label) / 2);
            };
            Controls.Add(lbTabClone);
            #endregion

            tabs.Insert(n, screenName);
            SelectTab(n);
        }

        public void SelectTab(int index)
        {
            if (index != currentIndex)
            {
                currentIndex = index;

                if (index != tabs.Count - 1)
                {
                    while (2 * index != Controls.Count - 1)
                    {
                        Controls.RemoveAt(Controls.Count - 1);
                    }

                    while(index != tabs.Count - 1)
                    {
                        tabs.RemoveAt(tabs.Count - 1);
                    }
                }

                for (int i = 0; i < tabs.Count; i++)
                {
                    var label = Controls[2 * i] as Label;
                    label.ForeColor = index == i ? AppColor.MainColor : AppColor.TextNormalColor;
                }

                if (tabControl != null)
                    tabControl.SelectedIndex = index;
            }
        }
    }
}

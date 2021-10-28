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

            #region generate tab
            var lbTabClone = ControlExtension.Clone<Label>(lbTab);
            lbTabClone.Text = screenName;
            lbTabClone.Name = screenName;
            lbTabClone.Visible = true;
            lbTabClone.Click += (s, e) =>
              {
                  SelectTab(Controls.IndexOf(s as Label) / 2);
              };
            #endregion

            if (n != 0)
            {
                #region generate arrow
                var pbArrowClone = ControlExtension.Clone<PictureBox>(pbArrow);
                pbArrowClone.Visible = true;
                #endregion

                Controls.Add(pbArrowClone);
            }

            Controls.Add(lbTabClone);
            tabs.Add(screenName);
            SelectTab(n);
        }

        public void SelectTab(int index)
        {
            if (index != currentIndex)
            {
                int n = tabs.Count;
                currentIndex = index;

                if (index != n - 1)
                {
                    for (int i = 2 * index + 1; i < Controls.Count; i++)
                    {
                        Controls.RemoveAt(i);
                    }
                }

                for (int i = 0; i < n; i++)
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

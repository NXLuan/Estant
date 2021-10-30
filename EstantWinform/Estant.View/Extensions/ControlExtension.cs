using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View.Extensions
{
    public static class ControlExtension
    {
        public static T Clone<T>(this T controlToClone) where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }

        public static void ShowFormInControl(Control control, Form form)
        {
            if (control != null && form != null)
            {
                form.TopLevel = false;
                control.Controls.Add(form);
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }
    }
}

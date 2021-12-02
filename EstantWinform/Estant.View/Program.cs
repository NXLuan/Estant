using Estant.Material.Utilities;
using Estant.View.FormUI;
using Estant.View.FormUI.VocabularyUI;
using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estant.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm.Instance);
            //Application.Run(new PronounceForm(new Vocabulary() { word = "Accounting", audio = "https://ssl.gstatic.com/dictionary/static/sounds/20200429/accounting--_gb_1.mp3" }));
        }
    }
}

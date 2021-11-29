using Estant.Material.Utilities;
using Estant.View.FormUI;
using Estant.View.FormUI.VocabularyUI;
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
            //Application.Run(new PronunciationAssessmentForm());     
        }
    }
}

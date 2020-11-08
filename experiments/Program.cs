using System;
using System.Collections.Generic;
using System.Windows.Forms;
using experiments.Presents;

namespace experiments
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewMainForm view = new ViewMainForm();
            PresentMainForm present = new PresentMainForm(view);
            Application.Run(view);
        }
    }
}

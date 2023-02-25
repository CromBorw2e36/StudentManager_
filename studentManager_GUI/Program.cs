using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using studentManager_GUI.UI;
using studentManager_GUI.UI.LoginControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace studentManager_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RegisterControl_());
            Application.Run(new loginControl());
            //Application.Run(new HomePage());
        }
    }
}

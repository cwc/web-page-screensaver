using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pl.polidea.lab.Web_Page_Screensaver;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    static class Program
    {
        public static readonly string KEY = "Software\\Web-Page-Screensaver";  

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0].ToLower().Contains("/p"))
                return;

            Application.Run(new PreferencesForm());

            if(args.Length > 0 && args[0].ToLower().Contains("/c"))
                Application.Run(new PreferencesForm());
            else
                Application.Run(new ScreensaverForm());
        }
    }
}

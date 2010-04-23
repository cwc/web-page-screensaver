using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pl.polidea.lab.Web_Page_Screensaver;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new ScreensaverForm());
        }
    }
}

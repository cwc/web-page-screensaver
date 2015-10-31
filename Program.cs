using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    static class Program
    {
        public static readonly string KEY = "Software\\Web-Page-Screensaver";

        [STAThread]
        static void Main(string[] args)
        {
            // Set version of embedded browser (http://weblog.west-wind.com/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version)
            var exeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", exeName, 0x2AF8, RegistryValueKind.DWord);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0].ToLower().Contains("/p"))
                return;

            if (args.Length > 0 && args[0].ToLower().Contains("/c"))
                Application.Run(new PreferencesForm());
            else
                Application.Run(new ScreensaverForm());
        }
    }
}

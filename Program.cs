using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Windows.Forms;

[assembly: SupportedOSPlatform("windows")]
namespace WebPageScreensaver
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ProcessModule? mainModule = Process.GetCurrentProcess().MainModule;

            if (mainModule == null)
            {
                throw new NullReferenceException("Current process main module is null.");
            }

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2); // Helps respect the specified window sizes
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true); // Prevents seeing tiny unexpected fonts

            // Argument verification - More than 1 argument, or passing
            // the wrong argument, will silently exit the program

            // No arguments is interpreted as "/P" or "/S"
            if (args.Length == 0)
            {
                ShowScreenSaver();
            }
            else if(args.Length == 1)
            {
                switch (args[0].ToUpperInvariant())
                {
                    case "/C": // Configure
                        Application.Run(new PreferencesForm());
                        break;
                    case "/P": // Preview
                    case "/S": // Show
                        ShowScreenSaver();
                        break;
                }
            }
        }

        /// <summary>
        /// Shows the screensaver form in all the screens.
        /// </summary>
        private static void ShowScreenSaver()
        {
            var forms = new List<Form>();

            foreach (KeyValuePair<int, ScreenInformation> kvp in Preferences.Screens)
            {
                var form = new ScreensaverForm(kvp.Value);
                forms.Add(form);
            }

            Application.Run(new MultiFormContext(forms));
        }
    }
}

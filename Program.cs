using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

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
            if (Process.GetCurrentProcess().MainModule is not ProcessModule)
            {
                throw new NullReferenceException("Current process main module is null.");
            }

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2); // Helps respect the specified window sizes
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true); // Prevents seeing tiny unexpected fonts

            // Argument verification:
            // - The arguments /C, /P and /S are required by Windows Control Panel.
            // - More than 1 argument, or passing the wrong argument, will exit the program

            // Passing no arguments is interpreted as using "/C"
            switch (args.Length)
            {
                case 0:
                    ShowPreferences();
                    break;

                case 1:
                    switch (args[0].ToUpperInvariant())
                    {
                        case "/C": // Configure
                            ShowPreferences();
                            break;
                        case "/P": // Preview
                        case "/S": // Show
                            ShowScreenSaver();
                            break;
                        default:
                            Console.WriteLine($"Unrecognized argument: {args[0]}");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Unexpected number of arguments.");
                    break;
            }
        }

        /// <summary>
        /// Show the screensaver preferences window.
        /// </summary>
        private static void ShowPreferences()
        {
            Application.Run(new PreferencesForm());
        }

        /// <summary>
        /// Shows the screensaver form in all the screens.
        /// </summary>
        private static void ShowScreenSaver()
        {
            var forms = new List<Form>();

            foreach ((int _, ScreenInformation info) in Preferences.Screens)
            {
                var form = new ScreensaverForm(info);
                forms.Add(form);
            }

            Application.Run(new MultiFormContext(forms));
        }
    }
}

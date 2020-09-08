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
            ProcessModule? mainModule = Process.GetCurrentProcess().MainModule;

            if (mainModule == null)
            {
                throw new NullReferenceException("Current process main module is null.");
            }

            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Argument verification - More than 1 argument, or passing
            // the wrong argument, will silently exit the program

            // No arguments means preview the screensaver (cursor enabled)
            if (args.Length == 0)
            {
                ShowScreenSaver(showCursor: true);
            }
            else if(args.Length == 1)
            {
                switch (args[0].ToUpperInvariant())
                {
                    case "/C":
                        Application.Run(new PreferencesForm());
                        break;
                    case "/P":
                        ShowScreenSaver(showCursor: true);
                        break;
                    case "/S":
                        ShowScreenSaver(showCursor: false);
                        break;
                }
            }
        }

        /// <summary>
        /// Shows the screensaver form in all the screens, and allows specifying if the
        /// cursor should be shown.
        /// </summary>
        /// <param name="showCursor"><see langword="true" /> if the cursor should be shown
        /// (for preview mode); <see langword="false" /> otherwise (for show mode).</param>
        private static void ShowScreenSaver(bool showCursor)
        {
            var forms = new List<Form>();

            foreach (KeyValuePair<int, ScreenInformation> kvp in Preferences.Screens)
            {
                var form = new ScreensaverForm(kvp.Value, showCursor);
                forms.Add(form);
            }

            Application.Run(new MultiFormContext(forms));
        }
    }
}

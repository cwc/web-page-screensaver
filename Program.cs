using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    static class Program
    {
        public const string Webpage = "http://github.com/carlossanlop/web-page-screensaver/";

        public const string KeyWebPageScreensaver = @"Software\WebPageScreensaver";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var mainModule = System.Diagnostics.Process.GetCurrentProcess().MainModule;

            if (mainModule == null)
            {
                throw new NullReferenceException("Current process main module is null.");
            }

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0 && args[0].ToUpperInvariant().Equals("/P"))
                return;

            if (args.Length > 0 && args[0].ToUpperInvariant().Equals("/C"))
            {
                Application.Run(new PreferencesForm());
            }
            else
            {
                var formsList = new List<Form>();
                var screens = (new PreferencesManager()).EffectiveScreensList;
                foreach (var screen in screens)
                {
                    var screensaverForm = new ScreensaverForm(screen.ScreenNum)
                    {
                        Location = new Point(screen.Bounds.Left, screen.Bounds.Top),
                        Size = new Size(screen.Bounds.Width, screen.Bounds.Height)
                    };

                    formsList.Add(screensaverForm);
                }

                Application.Run(new MultiFormContext(formsList));
            }
        }
    }

    public class MultiFormContext : ApplicationContext
    {
        public MultiFormContext(List<Form> forms)
        {
            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    // End program on form close
                    ExitThread();
                };

                form.Show();
            }
        }
    }
}

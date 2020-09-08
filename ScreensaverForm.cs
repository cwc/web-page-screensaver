using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal partial class ScreensaverForm : Form
    {
        private DateTime StartTime;
        private Timer timer;
        private int currentSiteIndex = -1;
        private MouseEventHandler userEventHandler;

        private ScreenInformation Screen;

        [ThreadStatic]
        private static Random random = new Random();

        public ScreensaverForm(ScreenInformation screen, bool showCursor)
        {
            userEventHandler = new MouseEventHandler();
            userEventHandler.Event += new MouseEventHandler.UserEvent(HandleUserActivity);

            Screen = screen;

            Location = new Point(Screen.Bounds.Left, Screen.Bounds.Top);
            Size = new Size(Screen.Bounds.Width, Screen.Bounds.Height);

            InitializeComponent();

            if (!showCursor)
            {
                Cursor.Hide();
            }
        }

        private async void ScreensaverForm_Load(object sender, EventArgs e)
        {
            if (_webBrowser == null)
            {
                throw new NullReferenceException("webBrowser should have been initialized by now.");
            }
            await _webBrowser.EnsureCoreWebView2Async();

            if (Screen.URLs.Any())
            {
                if (Screen.URLs.Count > 1)
                {
                    if (Screen.Shuffle)
                    {

                        int n = Screen.URLs.Count;
                        while (n > 1)
                        {
                            n--;
                            int k = random.Next(n + 1);
                            var value = Screen.URLs[k];
                            Screen.URLs[k] = Screen.URLs[n];
                            Screen.URLs[n] = value;
                        }
                    }

                    // Set up timer to rotate to the next URL
                    timer = new Timer();
                    timer.Interval = Screen.RotationInterval * 1000;
                    timer.Tick += (s, ee) => RotateSite();
                    timer.Start();
                }

                // Display the first site in the list
                RotateSite();

                StartTime = DateTime.Now;
            }
            else
            {
                _webBrowser.Visible = false;
            }
        }

        private void BrowseTo(string url)
        {
            // Disable the user event handler while navigating
            Application.RemoveMessageFilter(userEventHandler);

            if (string.IsNullOrWhiteSpace(url))
            {
                _webBrowser.Visible = false;
            }
            else
            {
                _webBrowser.Visible = true;
                _webBrowser.CoreWebView2.Navigate(url);
            }

            Application.AddMessageFilter(userEventHandler);
        }

        private void RotateSite()
        {
            currentSiteIndex++;

            if (currentSiteIndex >= Screen.URLs.Count)
            {
                currentSiteIndex = 0;
            }

            var url = Screen.URLs[currentSiteIndex];

            BrowseTo(url);
        }

        private void HandleUserActivity()
        {
            if (StartTime.AddSeconds(1) > DateTime.Now)
            {
                return;
            }

            if (Preferences.CloseOnMouseMovement)
            {
                Close();
            }
            else
            {
                _closeButton.Visible = true;
                Cursor.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
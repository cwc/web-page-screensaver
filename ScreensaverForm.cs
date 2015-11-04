using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    public partial class ScreensaverForm : Form
    {
        private DateTime StartTime;
        private Timer timer;
        private int currentSiteIndex = -1;
        private GlobalUserEventHandler userEventHandler;
        private bool shuffleOrder;
        private string[] urls;

        [ThreadStatic]
        private static Random random;

        public ScreensaverForm()
        {
            userEventHandler = new GlobalUserEventHandler();
            userEventHandler.Event += new GlobalUserEventHandler.UserEvent(HandleUserActivity);

            InitializeComponent();

            Cursor.Hide();
        }

        public string[] Urls
        {
            get
            {
                if (urls == null)
                {
                    RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
                    urls = ((string)reg.GetValue(PreferencesForm.URL_PREF, PreferencesForm.URL_PREF_DEFAULT)).Split(' ');
                    reg.Close();
                }

                return urls;
            }
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            if (Urls.Length > 1)
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);

                // Shuffle the URLs if necessary
                shuffleOrder = Boolean.Parse((string)reg.GetValue(PreferencesForm.RANDOMIZE_PREF, PreferencesForm.RANDOMIZE_PREF_DEFAULT));
                if (shuffleOrder)
                {
                    random = new Random();

                    int n = urls.Length;
                    while (n > 1)
                    {
                        n--;
                        int k = random.Next(n + 1);
                        var value = urls[k];
                        urls[k] = urls[n];
                        urls[n] = value;
                    }
                }

                // Set up timer to rotate to the next URL
                timer = new Timer();
                timer.Interval = int.Parse((string)reg.GetValue(PreferencesForm.INTERVAL_PREF, PreferencesForm.INTERVAL_PREF_DEFAULT)) * 1000;
                timer.Tick += (s, ee) => RotateSite();
                timer.Start();
            }

            // Display the first site in the list
            RotateSite();

            StartTime = DateTime.Now;
        }

        private void BrowseTo(string url)
        {
            // Disable the user event handler while navigating
            Application.RemoveMessageFilter(userEventHandler);

            try
            {
                Debug.WriteLine($"Navigating: {url}");
                webBrowser.Navigate(url);
            }
            catch
            {
                // This can happen if IE pops up a window that isn't closed before the next call to Navigate()
            }

            Application.AddMessageFilter(userEventHandler);
        }

        private void RotateSite()
        {
            currentSiteIndex++;

            if (currentSiteIndex >= Urls.Length)
            {
                currentSiteIndex = 0;
            }

            var url = Urls[currentSiteIndex];

            BrowseTo(url);
        }

        private void HandleUserActivity()
        {
            if (StartTime.AddSeconds(1) > DateTime.Now) return;

            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);

            if (Boolean.Parse((string)reg.GetValue(PreferencesForm.CLOSE_ON_ACTIVITY_PREF, PreferencesForm.CLOSE_ON_ACTIVITY_PREF_DEFAULT)))
            {
                Close();
            }
            else
            {
                closeButton.Visible = true;
                Cursor.Show();
            }

            reg.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class GlobalUserEventHandler : IMessageFilter
    {
        public delegate void UserEvent();

        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MBUTTONDBLCLK = 0x209;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        public event UserEvent Event;

        public bool PreFilterMessage(ref Message m)
        {
            if ((m.Msg >= WM_MOUSEMOVE && m.Msg <= WM_MBUTTONDBLCLK)
                || m.Msg == WM_KEYDOWN
                || m.Msg == WM_KEYUP)
            {
                if (Event != null)
                {
                    Event();
                }
            }
            // Always allow message to continue to the next filter control
            return false;
        }
    }
}
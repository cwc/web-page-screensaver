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
        private int currentSiteIndex = 0;
        private GlobalUserEventHandler userEventHandler;

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
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
                var urls = ((string)reg.GetValue(PreferencesForm.URL_PREF, "http://www.polidea.pl")).Split(' ');
                reg.Close();

                return urls;
            }
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            BrowseTo(Urls[0]);

            if (Urls.Length > 1)
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);

                currentSiteIndex = 0;
                timer = new Timer();
                timer.Interval = int.Parse((string)reg.GetValue(PreferencesForm.INTERVAL_PREF, "30")) * 1000;
                timer.Tick += (s, ee) => RotateSite();
                timer.Start();
            }

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

            if (Boolean.Parse((string)reg.GetValue(PreferencesForm.CLOSE_ON_ACTIVITY_PREF, "True")))
            {
                Close();
            }
            else
            {
                closeButton.Visible = true;
                Cursor.Show();
            }
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
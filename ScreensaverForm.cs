using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    public partial class ScreensaverForm : Form
    {
        private DateTime StartTime = DateTime.Now;

        public ScreensaverForm()
        {
            GlobalUserEventHandler gueh = new GlobalUserEventHandler();
            gueh.Event += new GlobalUserEventHandler.UserEvent(CloseAfter1Second);
            Application.AddMessageFilter(gueh);

            InitializeComponent();

            Cursor.Hide();
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
            webBrowser.Navigate((string)reg.GetValue(PreferencesForm.URL_PREF, "http://www.polidea.pl"));
            reg.Close();
        }

        private void CloseAfter1Second()
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);

            if (Boolean.Parse((string)reg.GetValue(PreferencesForm.CLOSE_ON_ACTIVITY_PREF, "True")))
            {
                if (StartTime.AddSeconds(1) < DateTime.Now)
                    Close();
            }
            else
            {
                closeButton.Visible = true;
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
                || m.Msg == WM_KEYDOWN || m.Msg == WM_KEYUP)
            {
                Cursor.Show();

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
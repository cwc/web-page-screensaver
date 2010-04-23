using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.google.com");
        }

        private void CloseAfter1Second()
        {
            if (StartTime.AddSeconds(1) < DateTime.Now)
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
            if ( (m.Msg >= WM_MOUSEMOVE && m.Msg <= WM_MBUTTONDBLCLK) 
                || m.Msg == WM_KEYDOWN || m.Msg == WM_KEYUP)
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
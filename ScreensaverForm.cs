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
        public ScreensaverForm()
        {
            InitializeComponent();
        }

        private void ScreensaverForm_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.google.com");
        }
    }
}

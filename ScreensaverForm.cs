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
        private int _currentURLIndex;

        private readonly Timer _timer;
        private readonly bool _closeOnMouseMovement;
        private readonly int _rotationInterval;
        private readonly bool _shuffle;
        private readonly List<string> _urls;
        private readonly Size _savedSize;
        private readonly Point _savedLocation;

        public ScreensaverForm(ScreenInformation screen)
        {
            _closeOnMouseMovement = Preferences.CloseOnMouseMovement;
            _rotationInterval = screen.RotationInterval;
            _shuffle = screen.Shuffle;
            _urls = screen.URLs.ToList();
            _currentURLIndex = 0;

            _savedSize = new Size(screen.Bounds.Width, screen.Bounds.Height);
            _savedLocation = new Point(screen.Bounds.Left, screen.Bounds.Top);

            Cursor.Hide();
            InitializeComponent();

            _timer = new Timer();
        }

        private async void ScreensaverForm_Load(object sender, EventArgs e)
        {
            if (_webBrowser == null)
            {
                throw new NullReferenceException("webBrowser should have been initialized by now.");
            }
            await _webBrowser.EnsureCoreWebView2Async();

            if (_urls.Any())
            {
                if (_shuffle)
                {
                    Random random = new Random();
                    int n = _urls.Count;
                    while (n > 1)
                    {
                        n--;
                        int k = random.Next(n + 1);
                        var value = _urls[k];
                        _urls[k] = _urls[n];
                        _urls[n] = value;
                    }
                }

                _timer.Interval = _rotationInterval * 1000;
                _timer.Tick += (s, ee) => RotateSite();
                _timer.Start();
            }
            else
            {
                _webBrowser.Visible = false;
            }
        }

        private void RotateSite()
        {
            if (_currentURLIndex >= _urls.Count)
            {
                _currentURLIndex = 0;
            }
            BrowseTo(_urls[_currentURLIndex]);
            _currentURLIndex++;
        }

        private void BrowseTo(string url)
        {
            _webBrowser.Visible = true;
            _webBrowser.CoreWebView2.Navigate(url);
        }

        private void WebBrowser_MouseMove(object sender, MouseEventArgs e)
        {
            if (_closeOnMouseMovement)
            {
                Close();
            }
        }

        /// <summary>
        /// Allows capturing the ESC key to close the form.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
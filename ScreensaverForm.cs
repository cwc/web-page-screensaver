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

        private readonly DateTime _startTime;
        private readonly Timer _timer;
        private readonly MouseEventHandler _mouseEventHandler;
        private readonly bool _closeOnMouseMovement;
        private readonly int _rotationInterval;
        private readonly bool _shuffle;
        private readonly List<string> _urls;

        public ScreensaverForm(ScreenInformation screen, bool showCursor)
        {
            _mouseEventHandler = new MouseEventHandler();
            _mouseEventHandler.Event += new MouseEventHandler.UserEvent(HandleUserActivity);

            _closeOnMouseMovement = Preferences.CloseOnMouseMovement;
            _rotationInterval = screen.RotationInterval;
            _shuffle = screen.Shuffle;
            _urls = screen.URLs.ToList();
            _currentURLIndex = 0;

            Location = new Point(screen.Bounds.Left, screen.Bounds.Top);
            Size = new Size(screen.Bounds.Width, screen.Bounds.Height);

            InitializeComponent();

            if (!showCursor)
            {
                Cursor.Hide();
            }

            _startTime = DateTime.Now;
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
            // Disable the user event handler while navigating
            Application.RemoveMessageFilter(_mouseEventHandler);

            if (string.IsNullOrWhiteSpace(url))
            {
                _webBrowser.Visible = false;
            }
            else
            {
                _webBrowser.Visible = true;
                _webBrowser.CoreWebView2.Navigate(url);
            }

            Application.AddMessageFilter(_mouseEventHandler);
        }

        private void HandleUserActivity()
        {
            if (_startTime.AddSeconds(1) > DateTime.Now)
            {
                return;
            }

            if (_closeOnMouseMovement)
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
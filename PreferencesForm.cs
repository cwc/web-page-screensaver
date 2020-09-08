using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal partial class PreferencesForm : Form
    {
        private const string Webpage = "http://github.com/carlossanlop/web-page-screensaver/";

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            Fetch();
        }

        private void anyMultiScreenModeButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Opens the project website in a new default browser tab.
        /// </summary>
        private void LinkLabelProjectURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                Arguments = $"/c start {Webpage}",
                CreateNoWindow = true
            };
            Process.Start(startInfo);
        }

        /// <summary>
        /// Saves the selected settings and closes the window.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        /// <summary>
        /// Closes the window without saving the settings.
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Retrieve shared data and show it in the form.
        /// </summary>
        private void Fetch()
        {
            MultiScreenMode multiScreenMode = Preferences.MultiScreen;

            _checkBoxCloseOnMouseMovement.Checked = Preferences.CloseOnMouseMovement;

            _flowLayoutPanelMultiScreenButtons.Enabled = Screen.AllScreens.Length > 1;

            _radioButtonMirrorScreens.Checked = multiScreenMode == MultiScreenMode.Mirror;
            _radioButtonSeparateScreens.Checked = multiScreenMode == MultiScreenMode.Separate;
            _radioButtonSpanScreens.Checked = multiScreenMode == MultiScreenMode.Span;

            _tabControlScreens.TabPages.Clear();

            int totalTabs = multiScreenMode switch
            {
                MultiScreenMode.Mirror or MultiScreenMode.Span => 1,
                MultiScreenMode.Separate => Screen.AllScreens.Length,
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };

            string tabTextSuffix = multiScreenMode switch
            {
                MultiScreenMode.Mirror => " (Mirror)",
                MultiScreenMode.Span => " (Composite)",
                MultiScreenMode.Separate => "",
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };


            for (int tabNumber = 0; tabNumber < totalTabs; tabNumber++)
            {
                TabPage tab = new TabPage();
                tab.Text = $"Display {tabNumber + 1}{tabTextSuffix}"; // Matches registry key name

                var currentUserControl = new PrefsByScreenUserControl
                {
                    AutoSize = true,
                    BackColor = Color.White,
                    Dock = DockStyle.Fill,
                    Location = new Point(4, 5),
                    Margin = new Padding(0),
                    MinimumSize = new Size(640, 300),
                    Name = $"_prefsByScreenUserControl{tabNumber}",
                    Size = new Size(640, 300),
                    TabIndex = 25
                };

                ScreenInformation currentScreen = Preferences.Screens[tabNumber];

                foreach (string url in currentScreen.URLs)
                {
                    currentUserControl._listViewURLs.Items.Add(url);
                }

                currentUserControl._numericUpDownRotationInterval.Value = currentScreen.RotationInterval;
                currentUserControl._checkBoxShuffle.Checked = currentScreen.Shuffle;

                tab.Controls.Add(currentUserControl);
                _tabControlScreens.TabPages.Add(tab);
            }
        }

        /// <summary>
        /// Read the data from the form and save it in the registry.
        /// </summary>
        private void Save()
        {
            Preferences.CloseOnMouseMovement = _checkBoxCloseOnMouseMovement.Checked;

            if (_radioButtonSpanScreens.Checked)
            {
                Preferences.MultiScreen = MultiScreenMode.Span;
            }
            else if (_radioButtonMirrorScreens.Checked)
            {
                Preferences.MultiScreen = MultiScreenMode.Mirror;
            }
            else // default
            {
                Preferences.MultiScreen = MultiScreenMode.Separate;
            }

            int screenNumber = 0;
            foreach (TabPage tab in _tabControlScreens.TabPages)
            {
                if (tab.Controls[0] is PrefsByScreenUserControl userControl)
                {
                    userControl.Save(screenNumber);
                    screenNumber++;
                }
                else
                {
                    throw new KeyNotFoundException("PrefsByScreenUserControl instance not found in tab.");
                }
            }
        }
    }
}

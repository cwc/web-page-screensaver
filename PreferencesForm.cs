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

        private List<PrefsByScreenUserControl> Tabs => new List<PrefsByScreenUserControl>();

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            _checkBoxCloseOnMouseMovement.Checked = Preferences.CloseOnMouseMovement;
            if (Screen.AllScreens.Length == 1)
            {
                _flowLayoutPanelMultiScreenButtons.Enabled = false;
            }
            else
            {
                _flowLayoutPanelMultiScreenButtons.Enabled = true;
            }
            SetMultiScreenButtonFromMode();
            ArrangeScreenTabs();
        }

        private void ArrangeScreenTabs()
        {
            switch (Preferences.MultiScreen)
            {
                case MultiScreenMode.Span:
                    RemoveExtraTabPages();
                    _tabControlScreens.TabPages[0].Text = "Composite Screen";
                    // Need to clear because we only expect one tab
                    Tabs.Clear();
                    Tabs.Add(_prefsByScreenUserControl);
                    Fetch();
                    break;
                case MultiScreenMode.Mirror:
                    RemoveExtraTabPages();
                    _tabControlScreens.TabPages[0].Text = "Each Screen";
                    // Need to clear because we only expect one tab
                    Tabs.Clear();
                    Tabs.Add(_prefsByScreenUserControl);
                    Fetch();
                    break;
                case MultiScreenMode.Separate:
                    for (int i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        TabPage? tabPage = null;

                        if (i >= _tabControlScreens.TabPages.Count)
                        {
                            tabPage = new TabPage();
                            _tabControlScreens.TabPages.Add(tabPage);

                            if (i > 0)
                            {
                                var prefsByScreenUserControl = new PrefsByScreenUserControl
                                {
                                    Name = string.Format("prefsByScreenUserControl{0}", i + 1),
                                    Location = new Point(0, 0),
                                    Size = _prefsByScreenUserControl.Size,
                                    Anchor = _prefsByScreenUserControl.Anchor,
                                    BackColor = _prefsByScreenUserControl.BackColor
                                };
                                prefsByScreenUserControl._listViewURLs.ContextMenuStrip =
                                    _prefsByScreenUserControl.ContextMenuStrip;
                                // No need to clear because we are re-adding the missing tabs
                                Tabs.Add(prefsByScreenUserControl);
                                tabPage.Controls.Add(prefsByScreenUserControl);
                            }
                        }
                        else if (_tabControlScreens.TabPages.Count == 1)
                        {
                            tabPage = _tabControlScreens.TabPages[0];
                            // Clearing before adding prevents a crash when going from Separate to Mirror and back to Separate
                            Tabs.Clear();
                            Tabs.Add(_prefsByScreenUserControl);
                        }

                        if (tabPage == null)
                        {
                            throw new NullReferenceException("tabPage should not be null.");
                        }

                        Fetch();
                        string primaryIndicator = string.Empty;
                        if (Screen.AllScreens[i].Primary) primaryIndicator = " (main)";
                        tabPage.Text = string.Format("Screen {0}{1}", i + 1, primaryIndicator);
                    }

                    break;
            }
        }

        private void RemoveExtraTabPages()
        {
            while (_tabControlScreens.TabPages.Count > 1)
            {
                _tabControlScreens.TabPages.RemoveAt(_tabControlScreens.TabPages.Count - 1);
            }
        }

        private void SetMultiScreenButtonFromMode()
        {
            switch (Preferences.MultiScreen)
            {
                case MultiScreenMode.Span:
                    _radioButtonSpanScreens.Checked = true;
                    break;
                case MultiScreenMode.Mirror:
                    _radioButtonMirrorScreens.Checked = true;
                    break;
                case MultiScreenMode.Separate:
                    _radioButtonSeparateScreens.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Unrecognized MultiScreenMode.");
            }
        }

        private void SetMultiScreenModeFromButtonState()
        {
            if (_radioButtonSpanScreens.Checked)
            {
                Preferences.MultiScreen = MultiScreenMode.Span;
            }
            else if (_radioButtonMirrorScreens.Checked)
            {
                Preferences.MultiScreen = MultiScreenMode.Mirror;
            }
            else
            {
                Preferences.MultiScreen = MultiScreenMode.Separate;
            }
        }


        private void anyMultiScreenModeButton_Click(object sender, EventArgs e)
        {
            Save();
            SetMultiScreenModeFromButtonState();
            ArrangeScreenTabs();
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
        /// Retrieve data for the specified screen from the registry and show it in the form.
        /// </summary>
        /// <param name="screenNumber">The screen number.</param>
        private void Fetch()
        {
            _checkBoxCloseOnMouseMovement.Checked = Preferences.CloseOnMouseMovement;

            for (int screenNumber = 0; screenNumber < Tabs.Count; screenNumber++)
            {
                PrefsByScreenUserControl currentTab = Tabs[screenNumber];
                ScreenInformation currentScreen = Preferences.Screens[screenNumber];


                currentTab._listViewURLs.Items.Clear();
                foreach (string url in currentScreen.URLs)
                {
                    currentTab._listViewURLs.Items.Add(url);
                }

                currentTab._numericUpDownRotationInterval.Value = Preferences.Screens[screenNumber].RotationInterval;
                currentTab._checkBoxShuffle.Checked = Preferences.Screens[screenNumber].Shuffle;
            }
        }

        /// <summary>
        /// Retrieve data from the form and save it in the registry.
        /// </summary>
        private void Save()
        {
            Preferences.CloseOnMouseMovement = _checkBoxCloseOnMouseMovement.Checked;

            for (int screenNumber = 0; screenNumber < Tabs.Count; screenNumber++)
            {
                PrefsByScreenUserControl currentTab = Tabs[screenNumber];
                ScreenInformation currentScreen = Preferences.Screens[screenNumber];

                currentScreen.URLs.Clear();
                foreach (ListViewItem item in currentTab._listViewURLs.Items)
                {
                    currentScreen.URLs.Add(item.Text);
                }

                currentScreen.RotationInterval = (int)currentTab._numericUpDownRotationInterval.Value;
                currentScreen.Shuffle = currentTab._checkBoxShuffle.Checked;
            }
        }
    }
}

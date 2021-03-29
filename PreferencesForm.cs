using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        /// <summary>
        /// Method called when the form is loaded, so the UI gets updated with the registry data.
        /// </summary>
        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            _checkBoxCloseOnMouseMovement.Checked = Preferences.CloseOnMouseMovement;

            MultiScreenMode multiScreenMode = Preferences.MultiScreen;

            // The Checked event will determine what to show in the tabs
            _radioButtonMirrorScreens.Checked = multiScreenMode == MultiScreenMode.Mirror;
            _radioButtonSeparateScreens.Checked = multiScreenMode == MultiScreenMode.Separate;
            _radioButtonSpanScreens.Checked = multiScreenMode == MultiScreenMode.Span;

            //_flowLayoutPanelMultiScreenMode.Enabled = Screen.AllScreens.Length > 1;
        }


        private void RadioButtonMultiScreenMode_Checked(object sender, EventArgs e)
        {
            if (sender is not RadioButton radioButton || !radioButton.Checked)
            {
                return;
            }

            MultiScreenMode multiScreenMode = radioButton.Name switch
            {
                nameof(_radioButtonMirrorScreens) => MultiScreenMode.Mirror,
                nameof(_radioButtonSeparateScreens) => MultiScreenMode.Separate,
                nameof(_radioButtonSpanScreens) => MultiScreenMode.Span,
                _ => throw new IndexOutOfRangeException("Unexpected radio button."),
            };

            // Save it to the registry
            Preferences.MultiScreen = multiScreenMode;

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

            _tabControlScreens.TabPages.Clear();

            for (int tabNumber = 0; tabNumber < totalTabs; tabNumber++)
            {
                TabPage tab = new TabPage
                {
                    Text = $"Display {tabNumber + 1}{tabTextSuffix}" // Matches registry key name
                };

                var currentUserControl = new PrefsByScreenUserControl
                {
                    AutoSize = true,
                    BackColor = Color.White,
                    Dock = DockStyle.Fill,
                    Name = $"_prefsByScreenUserControl{tabNumber}",
                    TabIndex = 5
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

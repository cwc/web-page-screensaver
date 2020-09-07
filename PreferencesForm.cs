using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    public partial class PreferencesForm : Form
    {
        private PreferencesManager prefsManager = new PreferencesManager();

        // Need to initialize in advance to prevent crashes when retrieving screenUserControls by index (LoadValuesForTab or ReadBackValuesFromUI)
        private List<PrefsByScreenUserControl> screenUserControls = new List<PrefsByScreenUserControl>();

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            _checkBoxCloseOnMouseMovement.Checked = prefsManager.CloseOnActivity;
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

        private void LoadValuesForTab(int screenNum)
        {
            var currentPrefsUserControl = screenUserControls[screenNum];
            LoadUrlsForTabToControl(screenNum, currentPrefsUserControl);
            currentPrefsUserControl._numericUpDownSecondsToDisplay.Value = prefsManager.GetRotationIntervalByScreen(screenNum);
            currentPrefsUserControl._checkBoxShuffle.Checked = prefsManager.GetRandomizeFlagByScreen(screenNum);
        }

        private void ArrangeScreenTabs()
        {
            switch (prefsManager.MultiScreenMode)
            {
                case PreferencesManager.MultiScreenModeItem.Span:
                    RemoveExtraTabPages();
                    _tabControlScreens.TabPages[0].Text = "Composite Screen";
                    // Need to clear because we only expect one tab
                    screenUserControls.Clear();
                    screenUserControls.Add(_prefsByScreenUserControl);
                    LoadValuesForTab(0);
                    break;
                case PreferencesManager.MultiScreenModeItem.Mirror:
                    RemoveExtraTabPages();
                    _tabControlScreens.TabPages[0].Text = "Each Screen";
                    // Need to clear because we only expect one tab
                    screenUserControls.Clear();
                    screenUserControls.Add(_prefsByScreenUserControl);
                    LoadValuesForTab(0);
                    break;
                case PreferencesManager.MultiScreenModeItem.Separate:
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
                                screenUserControls.Add(prefsByScreenUserControl);
                                tabPage.Controls.Add(prefsByScreenUserControl);
                            }
                        }
                        else if (_tabControlScreens.TabPages.Count == 1)
                        {
                            tabPage = _tabControlScreens.TabPages[0];
                            // Clearing before adding prevents a crash when going from Separate to Mirror and back to Separate
                            screenUserControls.Clear();
                            screenUserControls.Add(_prefsByScreenUserControl);
                        }

                        if (tabPage == null)
                        {
                            throw new NullReferenceException("tabPage should not be null.");
                        }

                        LoadValuesForTab(i);
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
            switch (prefsManager.MultiScreenMode)
            {
                case PreferencesManager.MultiScreenModeItem.Span:
                    _radioButtonSpanScreens.Checked = true;
                    break;
                case PreferencesManager.MultiScreenModeItem.Mirror:
                    _radioButtonMirrorScreens.Checked = true;
                    break;
                case PreferencesManager.MultiScreenModeItem.Separate:
                    _radioButtonSeparateScreens.Checked = true;
                    break;
            }
        }

        private void SetMultiScreenModeFromButtonState()
        {
            if (_radioButtonSpanScreens.Checked)
            {
                prefsManager.MultiScreenMode = PreferencesManager.MultiScreenModeItem.Span;
            }
            else if (_radioButtonMirrorScreens.Checked)
            {
                prefsManager.MultiScreenMode = PreferencesManager.MultiScreenModeItem.Mirror;
            }
            else
            {
                prefsManager.MultiScreenMode = PreferencesManager.MultiScreenModeItem.Separate;
            }

            prefsManager.ResetEffectiveScreensList();
        }

        private void ReadBackValuesFromUI()
        {
            for (var i = 0; i < screenUserControls.Count; i++)
            {
                var currentPrefsUserControl = screenUserControls[i];
                List<string> urls = (from ListViewItem lvUrlsItem in currentPrefsUserControl._listViewURLs.Items
                    select lvUrlsItem.Text).ToList();
                prefsManager.SetUrlsForScreen(i, urls);
                prefsManager.SetRotationIntervalForScreen(i,
                    (int)currentPrefsUserControl._numericUpDownSecondsToDisplay.Value);
                prefsManager.SetRandomizeFlagForScreen(i, currentPrefsUserControl._checkBoxShuffle.Checked);
                prefsManager.CloseOnActivity = _checkBoxCloseOnMouseMovement.Checked;
            }
        }

        private void LoadUrlsForTabToControl(int screenNum, PrefsByScreenUserControl currentPrefsUserControl)
        {
            currentPrefsUserControl._listViewURLs.Items.Clear();

            var urls = prefsManager.GetUrlsByScreen(screenNum);

            foreach (var url in urls)
            {
                currentPrefsUserControl._listViewURLs.Items.Add(url);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                ReadBackValuesFromUI();
                prefsManager.SavePreferences();
            }

            base.OnClosed(e);
        }

        private void llProjectLocationUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Program.Webpage);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void anyMultiScreenModeButton_Click(object sender, EventArgs e)
        {
            ReadBackValuesFromUI();
            SetMultiScreenModeFromButtonState();
            ArrangeScreenTabs();
        }
    }
}

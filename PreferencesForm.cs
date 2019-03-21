using System;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Forms;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    using System.Collections.Generic;
    using System.Drawing;

    using global::Web_Page_Screensaver;

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
            cbCloseOnActivity.Checked = prefsManager.CloseOnActivity;
            if (Screen.AllScreens.Count() == 1)
            {
                multiScreenGroup.Enabled = false;
            }
            else
            {
                multiScreenGroup.Enabled = true;
            }
            SetMultiScreenButtonFromMode();
            ArrangeScreenTabs();
        }

        private void LoadValuesForTab(int screenNum)
        {
            var currentPrefsUserControl = screenUserControls[screenNum];
            LoadUrlsForTabToControl(screenNum, currentPrefsUserControl);
            currentPrefsUserControl.nudRotationInterval.Value = prefsManager.GetRotationIntervalByScreen(screenNum);
            currentPrefsUserControl.cbRandomize.Checked = prefsManager.GetRandomizeFlagByScreen(screenNum);
        }

        private void ArrangeScreenTabs()
        {
            switch (prefsManager.MultiScreenMode)
            {
                case PreferencesManager.MultiScreenModeItem.Span:
                    RemoveExtraTabPages();
                    screenTabControl.TabPages[0].Text = "Composite Screen";
                    // Need to clear because we only expect one tab
                    screenUserControls.Clear();
                    screenUserControls.Add(prefsByScreenUserControl1);
                    LoadValuesForTab(0);
                    break;
                case PreferencesManager.MultiScreenModeItem.Mirror:
                    RemoveExtraTabPages();
                    screenTabControl.TabPages[0].Text = "Each Screen";
                    // Need to clear because we only expect one tab
                    screenUserControls.Clear();
                    screenUserControls.Add(prefsByScreenUserControl1);
                    LoadValuesForTab(0);
                    break;
                case PreferencesManager.MultiScreenModeItem.Separate:
                    for (int i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        TabPage tabPage = null; 

                        if (i >= screenTabControl.TabPages.Count)
                        {
                            tabPage = new TabPage();
                            screenTabControl.TabPages.Add(tabPage);

                            if (i > 0)
                            {
                                var prefsByScreenUserControl = new PrefsByScreenUserControl
                                {
                                    Name = string.Format("prefsByScreenUserControl{0}", i + 1),
                                    Location = new Point(0, 0),
                                    Size = prefsByScreenUserControl1.Size,
                                    Anchor = prefsByScreenUserControl1.Anchor,
                                    BackColor = prefsByScreenUserControl1.BackColor
                                };
                                prefsByScreenUserControl.lvUrls.ContextMenuStrip =
                                    prefsByScreenUserControl1.ContextMenuStrip;
                                // No need to clear because we are re-adding the missing tabs
                                screenUserControls.Add(prefsByScreenUserControl);
                                tabPage.Controls.Add(prefsByScreenUserControl);
                            }
                        }
                        else if (screenTabControl.TabPages.Count == 1)
                        {
                            tabPage = screenTabControl.TabPages[0];
                            // Clearing before adding prevents a crash when going from Separate to Mirror and back to Separate
                            screenUserControls.Clear();
                            screenUserControls.Add(prefsByScreenUserControl1);
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
            while (screenTabControl.TabPages.Count > 1)
            {
                screenTabControl.TabPages.RemoveAt(screenTabControl.TabPages.Count - 1);
            }
        }

        private void SetMultiScreenButtonFromMode()
        {
            switch (prefsManager.MultiScreenMode)
            {
                case PreferencesManager.MultiScreenModeItem.Span:
                    spanScreensButton.Checked = true;
                    break;
                case PreferencesManager.MultiScreenModeItem.Mirror:
                    mirrorScreensButton.Checked = true;
                    break;
                case PreferencesManager.MultiScreenModeItem.Separate:
                    separateScreensButton.Checked = true;
                    break;
            }
        }

        private void SetMultiScreenModeFromButtonState()
        {
            if (spanScreensButton.Checked)
            {
                prefsManager.MultiScreenMode = PreferencesManager.MultiScreenModeItem.Span;
            }
            else if (mirrorScreensButton.Checked)
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
                List<string> urls = (from ListViewItem lvUrlsItem in currentPrefsUserControl.lvUrls.Items
                    select lvUrlsItem.Text).ToList();
                prefsManager.SetUrlsForScreen(i, urls);
                prefsManager.SetRotationIntervalForScreen(i,
                    (int)currentPrefsUserControl.nudRotationInterval.Value);
                prefsManager.SetRandomizeFlagForScreen(i, currentPrefsUserControl.cbRandomize.Checked);
                prefsManager.CloseOnActivity = cbCloseOnActivity.Checked;
            }
        }

        private void LoadUrlsForTabToControl(int screenNum, PrefsByScreenUserControl currentPrefsUserControl)
        {
            currentPrefsUserControl.lvUrls.Items.Clear();

            var urls = prefsManager.GetUrlsByScreen(screenNum);

            foreach (var url in urls)
            {
                currentPrefsUserControl.lvUrls.Items.Add(url);
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
            System.Diagnostics.Process.Start(llProjectLocationUrl.Text);
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

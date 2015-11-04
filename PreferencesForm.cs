using System;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Forms;

namespace pl.polidea.lab.Web_Page_Screensaver
{
    public partial class PreferencesForm : Form
    {
        public const string URL_PREF = "Url";
        public const string CLOSE_ON_ACTIVITY_PREF = "CloseOnActivity";
        public const string INTERVAL_PREF = "RotationInterval";

        public const string URL_PREF_DEFAULT = "https://www.google.com/trends/hottrends/visualize?nrow=5&ncol=5 https://screensaver.twingly.com/ http://map.ipviking.com/";
        public const string CLOSE_ON_ACTIVITY_PREF_DEFAULT = "True";
        public const string INTERVAL_PREF_DEFAULT = "30";
        private ContextMenuStrip urlsContextMenu;

        public PreferencesForm()
        {
            InitializeComponent();

            urlsContextMenu = new ContextMenuStrip();
            urlsContextMenu.Opening += UrlsContextMenu_Opening;

            var removeUrl = urlsContextMenu.Items.Add("Remove URL");
            removeUrl.Click += RemoveUrl_Click;

            lbUrls.ContextMenuStrip = urlsContextMenu;
            lbUrls.MouseDown += LbUrls_MouseDown;
        }

        private void UrlsContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lbUrls.SelectedItem == null)
            {
                e.Cancel = true;
            }
        }

        private void LbUrls_MouseDown(object sender, MouseEventArgs e)
        {
            var clickedIndex = lbUrls.IndexFromPoint(e.Location);
            lbUrls.SelectedIndex = lbUrls.IndexFromPoint(e.Location);
        }

        private void RemoveUrl_Click(object sender, EventArgs e)
        {
            if (lbUrls.SelectedItem != null)
            {
                lbUrls.Items.Remove(lbUrls.SelectedItem);
            }
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
            loadUrls(reg);
            cbCloseOnActivity.Checked = Boolean.Parse((string)reg.GetValue(CLOSE_ON_ACTIVITY_PREF, CLOSE_ON_ACTIVITY_PREF_DEFAULT));
            nudRotationInterval.Value = int.Parse((string)reg.GetValue(INTERVAL_PREF, INTERVAL_PREF_DEFAULT));
            reg.Close();
        }

        private void loadUrls(RegistryKey reg)
        {
            lbUrls.Items.Clear();

            var urls = ((string)reg.GetValue(URL_PREF, URL_PREF_DEFAULT)).Split(' ');
            
            foreach (var url in urls)
            {
                lbUrls.Items.Add(url);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
                saveUrls(reg);
                reg.SetValue(CLOSE_ON_ACTIVITY_PREF, cbCloseOnActivity.Checked);
                reg.SetValue(INTERVAL_PREF, nudRotationInterval.Value);
                reg.Close();
            }

            base.OnClosed(e);
        }

        private void saveUrls(RegistryKey reg)
        {
            var urls = String.Join(" ", lbUrls.Items.Cast<String>());
                       
            reg.SetValue(URL_PREF, urls);
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

        private void addUrlButton_Click(object sender, EventArgs e)
        {
            var url = tbUrlToAdd.Text;

            lbUrls.Items.Add(url);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Win32;
using System.Text;
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

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
            tbUrl.Text = (string)reg.GetValue(URL_PREF, URL_PREF_DEFAULT);
            cbCloseOnActivity.Checked = Boolean.Parse((string)reg.GetValue(CLOSE_ON_ACTIVITY_PREF, CLOSE_ON_ACTIVITY_PREF_DEFAULT));
            nudRotationInterval.Value = int.Parse((string)reg.GetValue(INTERVAL_PREF, INTERVAL_PREF_DEFAULT));
            reg.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
                reg.SetValue(URL_PREF, tbUrl.Text);
                reg.SetValue(CLOSE_ON_ACTIVITY_PREF, cbCloseOnActivity.Checked);
                reg.SetValue(INTERVAL_PREF, nudRotationInterval.Value);
                reg.Close();
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

    }
}

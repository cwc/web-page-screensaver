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
        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
            textBox1.Text = (string)reg.GetValue("Url", "http://www.polidea.pl");
            reg.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KEY);
                reg.SetValue("Url", textBox1.Text);
                reg.Close();
            }

            base.OnClosed(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

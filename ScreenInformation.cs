using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal class ScreenInformation
    {
        private struct SettingName
        {
            public const string ScreenNumber = "ScreenNumber";
            public const string Bounds = "Bounds";
            public const string IsPrimary = "IsPrimary";
            public const string URLs = "URLs";
            public const string RotationInterval = "IntervalRotation";
            public const string Shuffle = "Shuffle";
        }
        private struct SettingDefaultValue
        {
            public const int RotationInterval = 10;
            public const bool Shuffle = true;
            public const string URLsPrimaryScreen = "https://dotnet.microsoft.com/ https://code.visualstudio.com/";
        }

        public ScreenInformation(RegistryKey rootKey, int screenNumber, MultiScreenMode multiScreenMode)
        {
            RootKey = rootKey;

            Bounds = multiScreenMode switch
            {
                MultiScreenMode.Span => FindEnclosingRectangle(),
                MultiScreenMode.Mirror or MultiScreenMode.Separate => Screen.AllScreens[screenNumber].Bounds,
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };
        }

        public RegistryKey RootKey { get; private set; }

        public Rectangle Bounds { get; set; }

        public IEnumerable<string> URLs
        {
            get
            {
                string urlsString = RootKey.GetOrCreateValue(SettingName.URLs, SettingDefaultValue.URLsPrimaryScreen);
                return urlsString.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            }
        }

        public void UpdateURLs(IEnumerable<string> urls)
        {
            string urlsString = string.Join(' ', urls);
            RootKey.SetValue(SettingName.URLs, urlsString);
        }

        public int RotationInterval
        {
            get => int.Parse(RootKey.GetOrCreateValue(SettingName.RotationInterval, SettingDefaultValue.RotationInterval));
            set => RootKey.SetValue(SettingName.RotationInterval, value);
        }

        public bool Shuffle
        {
            get => bool.Parse(RootKey.GetOrCreateValue(SettingName.Shuffle, SettingDefaultValue.Shuffle));
            set => RootKey.SetValue(SettingName.Shuffle, value);
        }

        private static Rectangle FindEnclosingRectangle()
        {
            IEnumerable<Rectangle> bounds = Screen.AllScreens.Select(r => r.Bounds);

            return Rectangle.FromLTRB(
                bounds.Min(r => r.Left),
                bounds.Min(r => r.Top),
                bounds.Max(r => r.Right),
                bounds.Max(r => r.Bottom));
        }
    }
}

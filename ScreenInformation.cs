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
        private struct SettingValue
        {
            public const int RotationInterval = 30;
            public const bool Shuffle = true;
        }

        public ScreenInformation(RegistryKey rootKey, int screenNumber, MultiScreenMode multiScreenMode)
        {

            RootKey = rootKey;
            ScreenNumber = multiScreenMode switch
            {
                MultiScreenMode.Span => 0,
                MultiScreenMode.Mirror or MultiScreenMode.Separate => screenNumber,
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };

            IsPrimary = multiScreenMode switch
            {
                MultiScreenMode.Span or MultiScreenMode.Mirror => true,
                MultiScreenMode.Separate => Screen.AllScreens[screenNumber].Primary,
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };

            Bounds = multiScreenMode switch
            {
                MultiScreenMode.Span => FindEnclosingRectangle(),
                MultiScreenMode.Mirror or MultiScreenMode.Separate => Screen.AllScreens[screenNumber].Bounds,
                _ => throw new IndexOutOfRangeException("Unrecognized MultiScreenMode value.")
            };
        }

        public RegistryKey RootKey { get; private set; }

        public int ScreenNumber
        {
            get => int.Parse(RootKey.GetOrCreateValue(SettingName.ScreenNumber));
            set => RootKey.SetValue(SettingName.ScreenNumber, value);
        }
        public Rectangle Bounds { get; set; }

        public bool IsPrimary
        {
            get => bool.Parse(RootKey.GetOrCreateValue(SettingName.IsPrimary));
            set => RootKey.SetValue(SettingName.IsPrimary, value);
        }

        public List<string> URLs
        {
            get
            {
                string urlsString = RootKey.GetOrCreateValue(SettingName.URLs, string.Empty);
                return urlsString.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
            }
            set
            {
                string urlsString = string.Join(' ', value);
                RootKey.SetValue(SettingName.URLs, urlsString);
            }
        }
        public int RotationInterval
        {
            get => int.Parse(RootKey.GetOrCreateValue(SettingName.RotationInterval, SettingValue.RotationInterval));
            set => RootKey.SetValue(SettingName.RotationInterval, value);
        }
        public bool Shuffle
        {
            get => bool.Parse(RootKey.GetOrCreateValue(SettingName.Shuffle, SettingValue.Shuffle));
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

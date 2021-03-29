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
        private const string URLsName = "URLs";
        private const string RotationIntervalName = "IntervalRotation";
        private const string ShuffleName = "Shuffle";

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
            get => RootKey
                    .GetOrCreateValue(URLsName, "https://dotnet.microsoft.com/ https://code.visualstudio.com/" /* default */)
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            set => RootKey.SetValue(URLsName, string.Join(' ', value));
        }

        public int RotationInterval
        {
            get => int.Parse(RootKey.GetOrCreateValue(RotationIntervalName, 10 /* default */));
            set => RootKey.SetValue(RotationIntervalName, value);
        }

        public bool Shuffle
        {
            get => bool.Parse(RootKey.GetOrCreateValue(ShuffleName, true /* default */));
            set => RootKey.SetValue(ShuffleName, value);
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

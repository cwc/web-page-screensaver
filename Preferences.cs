using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal static class Preferences
    {
        private const string CloseOnMouseMovementName = "CloseOnMouseMovement";
        private const string MultiScreenModeName = "MultiScreenMode";

        private struct SettingDefaultValue
        {
            public const int RotationInterval = 30;
            public const bool Shuffle = false;
        }

        private const string KeyWebPageScreensaver = @"Software\WebPageScreensaver";

        private static RegistryKey RootKey => Registry.CurrentUser.GetOrCreateSubKey(KeyWebPageScreensaver);

        public static int ScreenCount => Screen.AllScreens.Length;

        public static MultiScreenMode MultiScreen
        {
            get => Enum.Parse<MultiScreenMode>(RootKey.GetOrCreateValue(MultiScreenModeName, MultiScreenMode.Separate /* default */));
            set => RootKey.SetValue(MultiScreenModeName, value);
        }

        public static bool CloseOnMouseMovement
        {
            get => bool.Parse(RootKey.GetOrCreateValue(CloseOnMouseMovementName, true /* default */));
            set => RootKey.SetValue(CloseOnMouseMovementName, value);
        }

        public static Dictionary<int, ScreenInformation> Screens
        {
            get
            {
                var screens = new Dictionary<int, ScreenInformation>();

                MultiScreenMode multiScreenMode = MultiScreen;
                for (int screenNumber = 0; screenNumber < ScreenCount; screenNumber++)
                {
                    string screenKeyName = $"Display{screenNumber + 1}"; // To match tab name
                    RegistryKey subKey = RootKey.GetOrCreateSubKey(screenKeyName);
                    var info = new ScreenInformation(subKey, screenNumber, multiScreenMode);
                    screens.Add(screenNumber, info);
                }

                return screens;
            }
        }
    }
}
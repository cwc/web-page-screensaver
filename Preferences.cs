using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    internal static class Preferences
    {
        #region Setting names and default values

        private struct SettingName
        {
            public const string ScreenCount = "ScreenCount";
            public const string CloseOnMouseMovement = "CloseOnMouseMovement";
            public const string MultiScreenMode = "MultiScreenMode";
            public const string RotationInterval = "RotationInterval";
            public const string Shuffle = "Shuffle";
            public const string Url = "Url";
        }

        private struct SettingDefaultValue
        {
            public const int ScreenCount = 1;
            public const bool CloseOnMouseMovement = true;
            public const MultiScreenMode MultiScreen = MultiScreenMode.Separate;
            public const int RotationInterval = 30;
            public const bool Shuffle = false;
            public const string URLsPrimaryScreen = "https://dotnet.microsoft.com/ https://code.visualstudio.com/";
        }

        #endregion

        #region Private fields

        private const string KeyWebPageScreensaver = @"Software\WebPageScreensaver";

        #endregion

        #region Properties

        private static RegistryKey RootKey => Registry.CurrentUser.GetOrCreateSubKey(KeyWebPageScreensaver);

        public static int ScreenCount => Screen.AllScreens.Length;

        public static MultiScreenMode MultiScreen
        {
            get => Enum.Parse<MultiScreenMode>(RootKey.GetOrCreateValue(SettingName.MultiScreenMode, SettingDefaultValue.MultiScreen));
            set => RootKey.SetValue(SettingName.MultiScreenMode, value);
        }

        public static bool CloseOnMouseMovement
        {
            get => bool.Parse(RootKey.GetOrCreateValue(SettingName.CloseOnMouseMovement, SettingDefaultValue.CloseOnMouseMovement));
            set => RootKey.SetValue(SettingName.CloseOnMouseMovement, value);
        }

        public static Dictionary<int, ScreenInformation> Screens
        {
            get
            {
                Dictionary<int, ScreenInformation> screens = new Dictionary<int, ScreenInformation>();

                MultiScreenMode multiScreenMode = MultiScreen;
                for (int screenNumber = 1; screenNumber <= ScreenCount; screenNumber++)
                {
                    string screenKeyName = $"Screen{screenNumber}";
                    RegistryKey subKey = RootKey.GetOrCreateSubKey(screenKeyName);
                    ScreenInformation info = new ScreenInformation(subKey, screenNumber, multiScreenMode);
                    screens.Add(screenNumber, info);
                }

                return screens;
            }
        }

        #endregion
    }
}
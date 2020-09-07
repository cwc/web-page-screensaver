using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WebPageScreensaver
{
    public class PreferencesManager
    {
        private const string MULTISCREEN_PREF = "MultiScreenMode";
        private const string URL_PREF = "Url";
        private const string INTERVAL_PREF = "RotationInterval";
        private const string RANDOMIZE_PREF = "RandomOrder";
        private const string CLOSE_ON_ACTIVITY_PREF = "CloseOnActivity";

        private const string SCREEN_SPECIFIC_PREF_NAME_FORMATSTRING = "{0}Screen{1}";

        private const string MULTISCREEN_PREF_DEFAULT = "Separate";
        private const string URL_PREF_PRIMARYSCREEN_DEFAULT = "https://dotnet.microsoft.com/ https://code.visualstudio.com/";
        private const string URL_PREF_NONPRIMARYSCREEN_DEFAULT = "";
        private const string INTERVAL_PREF_DEFAULT = "30";
        private const string RANDOMIZE_PREF_DEFAULT = "False";
        private const string CLOSE_ON_ACTIVITY_PREF_DEFAULT = "True";

        private static RegistryKey reg = Registry.CurrentUser.CreateSubKey(Program.KeyWebPageScreensaver);

        public PreferencesManager()
        {
            LoadPreferences();
        }

        private List<BasicScreenInfo>? _effectiveScreensListField;
        public List<BasicScreenInfo> EffectiveScreensList
        {
            get
            {
                if (_effectiveScreensListField == null)
                {
                    _effectiveScreensListField = new List<BasicScreenInfo>();
                    switch (MultiScreenMode)
                    {
                        case MultiScreenModeItem.Span:
                            Rectangle enclosingRect = FindEnclosingRect(Screen.AllScreens.Select(r => r.Bounds).ToList());
                            _effectiveScreensListField.Add(
                                new BasicScreenInfo { ScreenNum = 0, Bounds = enclosingRect, IsPrimary = true });
                            break;

                        case MultiScreenModeItem.Mirror:
                            for (int i = 0; i < Screen.AllScreens.Length; i++)
                            {
                                _effectiveScreensListField.Add(
                                    new BasicScreenInfo
                                    {
                                        ScreenNum = i,
                                        Bounds = Screen.AllScreens[i].Bounds,
                                        IsPrimary = true
                                    });
                            }
                            break;

                        case MultiScreenModeItem.Separate:
                            for (int i = 0; i < Screen.AllScreens.Length; i++)
                            {
                                _effectiveScreensListField.Add(
                                    new BasicScreenInfo
                                    {
                                        ScreenNum = i,
                                        Bounds = Screen.AllScreens[i].Bounds,
                                        IsPrimary = Screen.AllScreens[i].Primary
                                    });
                            }
                            break;
                    }
                }
                return _effectiveScreensListField;
            }
        }

        public void ResetEffectiveScreensList()
        {
            _effectiveScreensListField = null;
        }

        private int _realPrimaryScreenNumField = -1;
        private int RealPrimaryScreenNumber
        {
            get
            {
                if (_realPrimaryScreenNumField == -1)
                {
                    _realPrimaryScreenNumField = 0;
                    for (int i = 0; i < Screen.AllScreens.Length; i++)
                    {
                        if (!Screen.AllScreens[i].Primary) continue;
                        _realPrimaryScreenNumField = i;
                        break;
                    }
                }

                return _realPrimaryScreenNumField;
            }
        }

        public bool CloseOnActivity { get; set; }
        public MultiScreenModeItem MultiScreenMode { get; set; }
        public enum MultiScreenModeItem
        {
            Span,
            Mirror,
            Separate
        }

        public class BasicScreenInfo
        {
            public int ScreenNum { get; set; }
            public Rectangle Bounds { get; set; }
            public bool IsPrimary { get; set; }
        }

        // TODO: the URLs handling mostly works, but it is overcomplicted and there is a fundamental issue with ordering:
        // specifically, if the user has a single-screen view of what is actually stored as multiple screens underneath,
        // and they order a later-screen item before an earlier screen item, those items will still wind up in screen-
        // order whe reading back for single-screen view.
        // options: 1) retro-fit more ordering stuff onto screen URLS, 2) make the URLS list just one list again, and 
        // add another list that specifies which screen each URL is for. (i.e. rewrite URL list handling completely).
        // 2. is actually the better option.
        private List<List<string>> _urlsByScreen = new List<List<string>>();
        public List<string> GetUrlsByScreen(int screenNum)
        {
            int startAtScreenNum = MultiScreenMode == MultiScreenModeItem.Mirror ? 0 : screenNum;
            // special treatment for URLs for the 'last' effective screen
            // this can happen either due to actual screen removal as noted in the LoadUrlsAllScreens() method,
            // OR because we are in Span mode, making just one effective screen,
            // OR we want to treat multiple screens as one (mirror mode).
            if (MultiScreenMode == MultiScreenModeItem.Mirror || EffectiveScreensList.Count < _urlsByScreen.Count && startAtScreenNum == EffectiveScreensList.Count - 1)
            {
                // for the GET operation, the last effective screen has the URLS
                // for additional screens in prefs appended to it's list.
                List<string> urlsList = _urlsByScreen[startAtScreenNum];
                var urlsForRestOfScreens = _urlsByScreen.GetRange(startAtScreenNum + 1, _urlsByScreen.Count - startAtScreenNum - 1);
                foreach (var additionalScreenUrls in urlsForRestOfScreens)
                {
                    urlsList.AddRange(additionalScreenUrls);
                }
                return urlsList;
            }
            else
            {
                return _urlsByScreen[startAtScreenNum];
            }
        }
        public void SetUrlsForScreen(int screenNum, List<string> providedUrlsList)
        {
            int startAtScreenNum = MultiScreenMode == MultiScreenModeItem.Mirror ? 0 : screenNum;
            // special treatment for URLs for the 'last' effective screen
            // this can happen either due to physical screen changes as noted in the LoadUrlsAllScreens() method,
            // OR because we are in Span or Mirror mode, making just one effective screen.
            if (MultiScreenMode == MultiScreenModeItem.Mirror || EffectiveScreensList.Count < _urlsByScreen.Count && startAtScreenNum == EffectiveScreensList.Count - 1)
            {
                // For the SET operation, we want any URLS that came to the last effective screen
                // from later screens in prefs to go back where they came from rather than directly
                // to the screen number specified.
                // at the same time, we want any NEW urls to go to either the screenNum provided,
                // or to the primary screen if that is one of the screens in the ones we are considering.

                // we only care about Url lists from this screen up.
                // This screen, whatever it is, is always RELATIVE screen 0.
                var relativeScreenUrlsList =
                    _urlsByScreen.GetRange(startAtScreenNum, _urlsByScreen.Count - startAtScreenNum);
                // make a deep copy that we can manipulate independantly of the actual list.
                var originalsUnaccountedFor = relativeScreenUrlsList.Select(t => new List<string>(t)).ToList();
                // then delete all that actual entries in the actual set to fill in below.
                foreach (var urlsList in relativeScreenUrlsList)
                {
                    urlsList.RemoveRange(0, urlsList.Count);
                }

                int defaultRelativeScreenNumForNewUrls = Math.Max(0, RealPrimaryScreenNumber - startAtScreenNum);

                foreach (var url in providedUrlsList)
                {
                    // find where it exists in the unaccounted for lists
                    int relativeScreenNumForThisUrl;
                    for (relativeScreenNumForThisUrl = 0; relativeScreenNumForThisUrl < originalsUnaccountedFor.Count; relativeScreenNumForThisUrl++)
                    {
                        if (originalsUnaccountedFor[relativeScreenNumForThisUrl].Contains(url))
                        {
                            // remove from further consideration, and use this relative screen number
                            originalsUnaccountedFor[relativeScreenNumForThisUrl].Remove(url);
                            break;
                        }
                    }
                    if (relativeScreenNumForThisUrl == originalsUnaccountedFor.Count)
                    {
                        // not found - use default
                        relativeScreenNumForThisUrl = defaultRelativeScreenNumForNewUrls;
                    }

                    relativeScreenUrlsList[relativeScreenNumForThisUrl].Add(url);
                }
            }
            else
            // normal case for normal screen nums is MUCH simpler:
            {
                _urlsByScreen[screenNum] = providedUrlsList;
            }
        }

        private List<int>? _rotationIntervalsByScreen;
        public int GetRotationIntervalByScreen(int screenNum)
        {
            return _rotationIntervalsByScreen[TranslateScreenNumToScreenPrefNum(screenNum)];
        }
        public void SetRotationIntervalForScreen(int screenNum, int value)
        {
            _rotationIntervalsByScreen[TranslateScreenNumToScreenPrefNum(screenNum)] = value;
        }

        private List<bool>? _randomizeFlagByScreen;
        public bool GetRandomizeFlagByScreen(int screenNum)
        {
            return _randomizeFlagByScreen[TranslateScreenNumToScreenPrefNum(screenNum)];
        }
        public void SetRandomizeFlagForScreen(int screenNum, bool randomizeSetting)
        {
            _randomizeFlagByScreen[TranslateScreenNumToScreenPrefNum(screenNum)] = randomizeSetting;
        }

        private int TranslateScreenNumToScreenPrefNum(int screenNum)
        {
            // if the screen they're asking for is an effective primary,
            // then the actual set of prefs to use is the real primary screen's set,
            // regardless of the actual number they asked for.
            return EffectiveScreensList[screenNum].IsPrimary ? RealPrimaryScreenNumber : screenNum;
        }

        public void SavePreferences()
        {
            reg.SetValue(MULTISCREEN_PREF, MultiScreenMode);
            reg.SetValue(CLOSE_ON_ACTIVITY_PREF, CloseOnActivity);
            SaveUrlsAllScreens();
            SavePrefAllScreens(INTERVAL_PREF, _rotationIntervalsByScreen);
            SavePrefAllScreens(RANDOMIZE_PREF, _randomizeFlagByScreen);
            reg.Close();
        }

        private void LoadPreferences()
        {
            MultiScreenMode = (MultiScreenModeItem)Enum.Parse(typeof(MultiScreenModeItem), (string)reg.GetValue(MULTISCREEN_PREF, MULTISCREEN_PREF_DEFAULT));
            CloseOnActivity = bool.Parse((string)reg.GetValue(CLOSE_ON_ACTIVITY_PREF, CLOSE_ON_ACTIVITY_PREF_DEFAULT));
            _urlsByScreen = LoadUrlsAllScreens();
            _rotationIntervalsByScreen = LoadPrefAllScreens<int>(INTERVAL_PREF, INTERVAL_PREF_DEFAULT, INTERVAL_PREF_DEFAULT);
            _randomizeFlagByScreen = LoadPrefAllScreens<bool>(RANDOMIZE_PREF, RANDOMIZE_PREF_DEFAULT, RANDOMIZE_PREF_DEFAULT);
        }

        private List<List<string>> LoadUrlsAllScreens()
        {
            List<string> strings = LoadPrefAllScreens<string>(URL_PREF, URL_PREF_PRIMARYSCREEN_DEFAULT, URL_PREF_NONPRIMARYSCREEN_DEFAULT);
            var allUrls = strings.Select(stringValue => string.IsNullOrWhiteSpace(stringValue)
                                                     ? new List<string>()
                                                     : stringValue.Split(' ').ToList())
                                  .ToList();

            // special case for URLs, so that we don't lose any if/when the user physically removes a screen
            // (this happens frequently eg if you remote desktop to your machine, or you undock your laptop)
            // if there are more screens stored in the prefs than there are actual screens, append any extras.
            // actually dealing appropriately with the extra lists of URLs is handled by the GetUrlsByScreen()
            // and SetUrlsByScreen() methods.
            const string TempDefaultValue = "DEFAULT VALUE";
            int i = allUrls.Count;
            string nextScreenUrlsPrefResult = LoadPrefByScreen<string>(i, URL_PREF, TempDefaultValue, TempDefaultValue);
            while (nextScreenUrlsPrefResult != TempDefaultValue)
            {
                allUrls.Add(
                    string.IsNullOrWhiteSpace(nextScreenUrlsPrefResult)
                        ? new List<string>()
                        : nextScreenUrlsPrefResult.Split(' ').ToList());
                nextScreenUrlsPrefResult = LoadPrefByScreen<string>(++i, URL_PREF, TempDefaultValue, TempDefaultValue);
            }

            return allUrls;
        }

        private List<T> LoadPrefAllScreens<T>(string prefBaseName, string primaryScreenPrefDefaultValue, string nonPrimaryScreenPrefDefaultValue)
        {
            List<T> myList = new List<T>();
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                myList.Add(LoadPrefByScreen<T>(i, prefBaseName, primaryScreenPrefDefaultValue, nonPrimaryScreenPrefDefaultValue));
            }
            return myList;
        }

        private void SaveUrlsAllScreens()
        {
            SavePrefAllScreens(URL_PREF, _urlsByScreen.Select(urlList => string.Join(" ", urlList)).ToList());
        }

        private void SavePrefAllScreens<T>(string preferenceName, List<T> prefsList)
        {
            for (int i = 0; i < prefsList.Count(); i++)
            {
                reg.SetValue(ScreenSpecificPrefName(preferenceName, i), prefsList[i]);
            }
        }

        private T LoadPrefByScreen<T>(int screenNum, string prefBaseName, string primaryScreenPrefDefaultValue, string nonPrimaryScreenPrefDefaultValue)
        {
            string screenSpecificPrefEntryName = ScreenSpecificPrefName(prefBaseName, screenNum);
            object regValue = reg.GetValue(screenSpecificPrefEntryName);
            if (regValue == null)
            {
                // no screen-specific entry exists.
                // for backward compatibility, if the current tab is only one, or else for the primary screen only,
                // look for the non-screen-specific pref setting, and if found, move it from there.
                // This is a one-off preferences upgrade.

                if (Screen.AllScreens.Length == 1 || (screenNum < Screen.AllScreens.Length && Screen.AllScreens[screenNum].Primary))
                {
                    if (reg.GetValueNames().Contains(prefBaseName))
                    {
                        regValue = reg.GetValue(prefBaseName);
                        reg.DeleteValue(prefBaseName);
                        reg.SetValue(screenSpecificPrefEntryName, (T)Convert.ChangeType(regValue, typeof(T)));
                    }
                    else
                    {
                        regValue = (T)Convert.ChangeType(primaryScreenPrefDefaultValue, typeof(T));
                    }
                }
                else
                {
                    regValue = (T)Convert.ChangeType(nonPrimaryScreenPrefDefaultValue, typeof(T));
                }
            }

            return (T)Convert.ChangeType(regValue, typeof(T));
        }

        private static string ScreenSpecificPrefName(string prefBaseName, int screenNum)
        {
            return string.Format(SCREEN_SPECIFIC_PREF_NAME_FORMATSTRING, prefBaseName, screenNum);
        }

        private static Rectangle FindEnclosingRect(List<Rectangle> rectangles)
        {
            return Rectangle.FromLTRB(
                rectangles.Min(r => r.Left),
                rectangles.Min(r => r.Top),
                rectangles.Max(r => r.Right),
                rectangles.Max(r => r.Bottom));
        }
    }
}
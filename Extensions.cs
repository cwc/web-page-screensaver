using Microsoft.Win32;
using System;

namespace WebPageScreensaver
{
    public static class Extensions
    {
        public static RegistryKey GetOrCreateSubKey(this RegistryKey root, string subKeyName)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }
            if (string.IsNullOrWhiteSpace(subKeyName))
            {
                throw new ArgumentException(nameof(subKeyName));
            }

            RegistryKey? key = root.OpenSubKey(subKeyName, writable: true);
            if (key == null)
            {
                key = root.CreateSubKey(subKeyName, writable: true);
                if (key == null)
                {
                    throw new UnauthorizedAccessException($"Could not get/create key to registry: {subKeyName}");
                }
            }
            return key;
        }

        public static string GetOrCreateValue(this RegistryKey root, string valueName, object defaultValue)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }
            if (defaultValue == null)
            {
                throw new ArgumentNullException(nameof(defaultValue));
            }
            if (string.IsNullOrWhiteSpace(valueName))
            {
                throw new ArgumentNullException(nameof(valueName));
            }

            object? obj = root.GetValue(valueName);
            if (obj == null)
            {
                root.SetValue(valueName, defaultValue!.ToString());
                obj = root.GetValue(valueName);
                if (obj == null)
                {
                    throw new UnauthorizedAccessException($"Could not get/create the registry value: {valueName}");
                }
            }
            return obj!.ToString();
        }

        public static string GetOrCreateValue(this RegistryKey root, string valueName)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }
            if (string.IsNullOrWhiteSpace(valueName))
            {
                throw new ArgumentNullException(nameof(valueName));
            }

            object? obj = root.GetValue(valueName);
            if (obj == null)
            {
                throw new UnauthorizedAccessException($"Could not get/create the registry value: {valueName}");
            }
            return obj!.ToString();
        }
    }
}

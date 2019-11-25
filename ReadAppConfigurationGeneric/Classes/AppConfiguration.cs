using System;
using System.ComponentModel;
using System.Configuration;

namespace ReadAppConfigurationGeneric.Classes
{
    public class AppConfiguration
    {
        public static T ConfigSetting<T>(string settingName)
        {
            object value = ConfigurationManager.AppSettings[settingName];
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static T ParseGeneric<T>(string stringValue)
        {
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(stringValue);
        }
        public static T GetConfigSetting<T>(string stringValue)
        {
            return ParseGeneric<T>(ConfigurationManager.AppSettings[stringValue]);
        }

        public static T ConvertOrDefault<T>(string input) 
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                return (T)converter.ConvertFromString(input);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static bool TestMode => ConfigSetting<bool>("TestMode");
        public static bool TestMode1 => GetConfigSetting<bool>("TestMode");

        public static string DatabaseServer => ConfigurationManager.AppSettings["DatabaseServer"];
    }
}

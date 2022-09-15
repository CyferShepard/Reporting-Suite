using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Diagnostics;

namespace Productivity_Reporter
{

    class ConfigFile
    {
       /* public void Main(string[] args)
        {
            ReadAllSettings();
            ReadSetting("Setting1");
            ReadSetting("NotValid");
            AddUpdateAppSettings("NewSetting", "May 7, 2014");
            AddUpdateAppSettings("Setting1", "May 8, 2014");
            ReadAllSettings();
        }*/

        public void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Debug.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Debug.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Debug.WriteLine("Error reading app settings");
            }
        }

        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Error";
                Debug.WriteLine(result);
                return result;
               
            }
            catch (ConfigurationErrorsException)
            {
                Debug.WriteLine("Error reading app settings");
                return "Error";
            }
        }

        public void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Debug.WriteLine("Error writing app settings");
            }
        }
    }
}


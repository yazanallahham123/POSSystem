using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.Common
{
    class Settings
    {
        public static string connectionString() {
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder.DataSource = getSetting("server");
            builder.IntegratedSecurity = false;
            builder.MultipleActiveResultSets = true;
            
            if (getSetting("database") != "")
                builder.InitialCatalog = getSetting("database");
            else
                builder.InitialCatalog = "master";

            builder.UserID = getSetting("serverUser");
            builder.Password = getSetting("serverPassword");
            return builder.ConnectionString;
        }
        public static void saveSetting(string settingKey, string settingValue)
        {
            var path = System.Reflection.Assembly.GetEntryAssembly().Location;
            Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            var setting = config.AppSettings.Settings[settingKey];
            if (setting != null)
            {
                setting.Value = settingValue;
            }
            else
            {
                config.AppSettings.Settings.Add(settingKey, settingValue);
            }
            config.Save();
        }

        public static string getSetting(string settingKey)
        {
            try
            {
                var path = System.Reflection.Assembly.GetEntryAssembly().Location;
                Configuration config = ConfigurationManager.OpenExeConfiguration(path);
                if (config.AppSettings.Settings[settingKey] != null)
                    return config.AppSettings.Settings[settingKey].Value;
                else
                    return "";
            }
            catch
            {
                return "";
            }
        }
    }
}

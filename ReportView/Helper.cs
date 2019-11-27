using System.Configuration;

namespace ReportView
{
    public class Helper
    {
        private Configuration config;

        //helps to retrieve name of connection from APP.config
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public Helper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public void SaveConnectionString(string key, string value)
        {
            ConfigurationManager.RefreshSection("connectionStrings");

            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public void SaveLoginString(string key, string value)
        {

            config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
        }

        public static string LoginVal(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
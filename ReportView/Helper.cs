using System.Configuration;

namespace ReportView
{
    public class Helper
    {
        Configuration config;
        //helps to retrieve name of connection from APP.config
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public Helper()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        public void SaveConnectionString(string key,string value)
        {

            ConfigurationManager.RefreshSection("connectionStrings");

            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
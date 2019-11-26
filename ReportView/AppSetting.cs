using System.Configuration;

namespace ReportView
{
    internal class AppSetting
    {
        private Configuration config;

        
        public string GetConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;

        }

        public void SaveConnectionString(string key)
        {

        }
    }
}
using System.Configuration;

namespace ReportView
{
    internal class Helper
    {
        //helps to retrieve name of connection from APP.config
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
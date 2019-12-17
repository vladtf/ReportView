using Dapper;
using ReportView.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ReportView.Helpers
{
    internal class DataAcces
    {
        //Create a list of PERSONS retrieved from database
        public List<PersonModel> GetPeople()
        {
            //create a new CONNECTION and destroy it after closing {}

            //using (SqlConnection connection = new SqlConnection(ConfigHelper.CnnVal("work")))
            using (SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = work; Integrated Security = True; Connect Timeout = 60; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                //sql statemnt to select data
                //var output = connection.Query<Person>($"Select * from sakila.actor where last_name = '{lastName}'").ToList();
                try
                {
                    var output = connection.Query<PersonModel>("select * from [dbo].[employees];").ToList();
                    return output;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
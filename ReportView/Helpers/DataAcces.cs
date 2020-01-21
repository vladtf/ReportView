using Dapper;
using ReportView.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ReportView.Helpers
{
    internal class DataAcces
    {
        //Create a list of PERSONS retrieved from database
        public static async Task<IEnumerable<PersonModel>> GetPeople()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VTFData;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //create a new CONNECTION and destroy it after closing {}

            //using (SqlConnection connection = new SqlConnection(ConfigHelper.CnnVal("work")))
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //sql statemnt to select data
                //var output = connection.Query<Person>($"Select * from sakila.actor where last_name = '{lastName}'").ToList();
                try
                {
                    var output = await connection.QueryAsync<PersonModel>("select * from [dbo].[employees];");
                    return output as List<PersonModel>;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
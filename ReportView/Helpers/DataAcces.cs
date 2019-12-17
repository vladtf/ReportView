using Dapper;
using ReportView.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ReportView.Helpers
{
    internal class DataAcces
    {
        //Create a list of PERSONS retrieved from database
        public List<PersonModel> GetPeople()
        {
            //create a new CONNECTION and destroy it after closing {}
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigHelper.CnnVal("work")))
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
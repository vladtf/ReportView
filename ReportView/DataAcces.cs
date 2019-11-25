using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
namespace ReportView
{
    internal class DataAcces
    {
        //Create a list of PERSONS retrieved from database
        public List<Person> GetPeople()
        {
            //create a new CONNECTION and destroy it after closing {}
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("work")))
            {
                //sql statemnt to select data
                //var output = connection.Query<Person>($"Select * from sakila.actor where last_name = '{lastName}'").ToList();
                try
                {
                    var output= connection.Query<Person>("select * from [dbo].[employees];").ToList();
                    return output;
                }
                catch
                {
                    MessageBox.Show("No DataBase Connection");
                }

                return null;
            }
        }
    }
}
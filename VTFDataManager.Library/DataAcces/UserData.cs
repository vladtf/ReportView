using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTFDataManager.Library.Internal.DataAcces;
using VTFDataManager.Library.Models;

namespace VTFDataManager.Library.DataAcces
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAcces sql = new SqlDataAcces();

            var p = new { user_id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "VTFData");

            return output;
        }

        public static void RegisterUser(string Id,string FirstName,string LastName, string EmailAdress,int PhoneNumber)
        {
            SqlDataAcces sql = new SqlDataAcces();

            var p = new { user_id = Id, first_name = FirstName, last_name = LastName, email_adress = EmailAdress,  phone_number=PhoneNumber };

            sql.SaveData("dbo.spInsertNewUser", p, "VTFData");
        }

        public List<EventModel> GetEventsByMonth(EventLookupModel eventLookup)
        {
            SqlDataAcces sql = new SqlDataAcces();

            var p = new { month = eventLookup.date, status=eventLookup.status};

            var output = sql.LoadData<EventModel, dynamic>("dbo.spEventsLookup", p, "VTFData");

            return output;
        }
    }

}

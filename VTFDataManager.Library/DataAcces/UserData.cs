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

            var p = new { Id = Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "VTFData");

            return output;
        }
    }

}

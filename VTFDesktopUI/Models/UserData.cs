using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTFDesktopUI.Models
{
    public class UserData
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string CreatedDate { get; set; }

        public string FullInfo
        {
            get 
            { 
                string output = $"{FirstName} {LastName} {EmailAdress} {CreatedDate}";
                return output;
            }
        }


    }
}

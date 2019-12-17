namespace VTFDesktopUI.Models
{
    public class UserModel
    {
        public string user_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_adress { get; set; }
        public string phone_number { get; set; }
        public string verfied_status { get; set; }
        public string created_at { get; set; }

        public bool loged_In { get; set; }

        public string FullInfo
        {
            get
            {
                string output = $"{first_name} {last_name} {email_adress} {created_at}";
                return output;
            }
        }

        public string access_token { get; set; }
    }
}
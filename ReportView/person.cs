namespace ReportView
{
    public class Person
    {
        //stuff we want to get from database
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string department { get; set; }

        //get FullInfo to be displayed
        public string FullInfo
        {
            get
            {
                return $"{ first_name } { last_name } ({id})";
            }
        }
    }
}
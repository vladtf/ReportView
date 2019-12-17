using System;

namespace VTFDataManager.Library.Models
{
    public class EventModel
    {
        public string event_id { get; set; }
        public string event_name { get; set; }
        public string host_id { get; set; }
        public string short_description { get; set; }
        public string category_name { get; set; }
        public string date_event { get; set; }

        public string time_event
        {
            get
            {
                var output = DateTime.Parse(date_event).Hour;
                return output.ToString();
            }
        }

        public string price { get; set; }
        public string seats { get; set; }
        public string location_name { get; set; }
        public string adress { get; set; }
        public string host_first_name { get; set; }
        public string host_last_name { get; set; }

        //private bool isFollowed;

        //public bool IsFollowed
        //{
        //    get
        //    {
        //        return isFollowed;
        //    }
        //    set
        //    {
        //        SetProperty(ref isFollowed, value);
        //    }
        //}
    }
}
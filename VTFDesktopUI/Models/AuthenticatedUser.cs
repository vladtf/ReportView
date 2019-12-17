namespace VTFDesktopUI.Models
{
    public class AuthenticatedUser
    {
        public string access_token { get; set; }
        public string userName { get; set; }
        public bool loged_In { get; set; }
    }
}
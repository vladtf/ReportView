using System.Threading.Tasks;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        void GetUserInfo(string acces_token);
    }
}
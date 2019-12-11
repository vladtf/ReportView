using System;
using System.Threading.Tasks;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task<AuthenticatedUser> Register(string username, string password);

        void GetUserInfo(string acces_token);

        void GetEventsByMonth(string acces_token, string date, string status);
    }
}
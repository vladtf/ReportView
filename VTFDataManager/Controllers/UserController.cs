using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;
using VTFDataManager.Library.DataAcces;
using VTFDataManager.Library.Models;

namespace VTFDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId);
        }
    }
}
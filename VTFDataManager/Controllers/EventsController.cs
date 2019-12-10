using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using VTFDataManager.Library.DataAcces;
using VTFDataManager.Library.Models;

namespace VTFDataManager.Controllers
{
    [RoutePrefix("api/Events")]
    [Authorize]
    public class EventsController : ApiController
    {
        [Route("GetEventsByMonth")]
        [HttpPost]
        public List<EventModel> GetEventsByMonth(EventLookupModel eventLookup)
        {

            UserData data = new UserData();

            return data.GetEventsByMonth(eventLookup);
        }
    }
}

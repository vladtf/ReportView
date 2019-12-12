using Caliburn.Micro;
using System;
using VTFDesktopUI.Helpers;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.ViewModels
{
    public class EventsViewModel : Screen
    {
        private UserModel _user;
        private IAPIHelper _apiHelper;
        private EventModel _event;

        public EventsViewModel(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;

        }

        public UserModel User
        {
            get { return _user; }
            set { _user = value; }
        }


        public EventModel Event
        {
            get { return _event; }
            set 
            { 
                _event = value;

            }
        }


        protected override async void OnActivate()
        {
            //Event = await _apiHelper.GetEventsByMonth(_user.access_token, "10-10-2019", "upcoming");
        }

    }
}
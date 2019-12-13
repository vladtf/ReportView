using Caliburn.Micro;
using System;
using System.Windows;
using VTFDesktopUI.Helpers;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.ViewModels
{
    public class EventsViewModel : Screen
    {
        private UserModel _user;
        private IAPIHelper _apiHelper;
        private EventModel _event;

        public EventsViewModel(IAPIHelper aPIHelper,UserModel userModel)
        {
            _user = userModel;
            _apiHelper = aPIHelper;

        }

        public UserModel User
        {
            get { return _user; }
            set { _user.access_token = value.access_token; }
        }


        public EventModel Event
        {
            get { return _event; }
            set 
            { 
                _event = value;
                NotifyOfPropertyChange(() => Event);
            }
        }


        protected override async void OnActivate()
        {
            //Event = await _apiHelper.GetEventsByMonth(_user.access_token, "10-10-2019", "upcoming");
            try
            {
                Event = await _apiHelper.GetEventsByMonth(User.access_token, "10-10-2019", "upcoming");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
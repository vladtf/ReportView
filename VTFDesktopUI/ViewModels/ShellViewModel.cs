﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVM;
        private EventsViewModel _eventsVM;
        private UserModel _user;
        public ShellViewModel(UserModel userModel, EventsViewModel eventsViewModel, LoginViewModel loginVM)
        {
            _user = userModel;

            _loginVM = loginVM;

            _loginVM.User = User;

            _eventsVM = eventsViewModel;

            ActivateItem(_loginVM);
        }


        public UserModel User
        {
            get { return _user; }
            set 
            { 
                _user = value;
                NotifyOfPropertyChange(() => User);
                NotifyOfPropertyChange(() => _loginVM.User);
            }
        }
        
        public bool LogedIn
        {
            get
            {
                bool outpup = false;
                if(User.loged_In)
                {
                    outpup = true;
                    _eventsVM.User = User;
                    ActivateItem(_eventsVM);
                }
                return outpup;
            }
        }

        public async void Events()
        {
            _eventsVM.User = _loginVM.User;
            _eventsVM.Event = _loginVM.Event;
            ActivateItem(_eventsVM);
        }





    }
}

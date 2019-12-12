﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VTFDesktopUI.Helpers;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;
        private UserModel _user;
        public LoginViewModel(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;
        }
        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogin);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public string Password
        {
            get { return _password; }
            set { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogin);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }
        
        public bool IsErrorVisibile
        {
            get 
            {
                bool output=false;
                if(ErrorMessage?.Length>0)
                {
                    output = true;
                }
                return output;
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set 
            {

                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisibile);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }



        public bool CanLogin
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }


        public async Task Login()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Authenticate(UserName, Password);
                User = await _apiHelper.GetUserInfo(result.access_token);
                User.access_token = result.access_token;

                Event = await _apiHelper.GetEventsByMonth(result.access_token, "10-10-2019", "upcoming");

                Console.WriteLine(Event.Name);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        public bool CanRegister
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }
        public async Task Register()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Register(UserName, Password);


                MessageBox.Show("Successfully Registered!");

                Password = UserName = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }
        }

        public UserModel User
        {
            get { return _user; }
            set 
            { 
                _user = value;
                NotifyOfPropertyChange(() => User);
            }
        }

        private EventModel _event;

        public EventModel Event
        {
            get { return _event; }
            set { _event = value; }
        }


    }
}

using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using System.Windows;
using VTFDesktopUI.Helpers;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.ViewModels
{
    public class RegisterViewModel : Screen
    {
        private IAPIHelper _apiHelper;
        private string _username;
        private string _password;
        private string _confirmPassword;

        public RegisterViewModel(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;

                NotifyOfPropertyChange(() => ConfirmPassword);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;

                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;

                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;

                NotifyOfPropertyChange(() => PhoneNumber);
                NotifyOfPropertyChange(() => CanRegister);
            }
        }

        public bool IsErrorVisibile
        {
            get
            {
                bool output = false;
                if (ErrorMessage?.Length > 0)
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

        public bool CanRegister
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0 && ConfirmPassword?.Length > 0)
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
                RegisterUserModel registerViewModel = new RegisterUserModel
                {
                    UserName = UserName,
                    Password = Password,
                    ConfirmPassword = ConfirmPassword
                };
                var result = await _apiHelper.Register(registerViewModel);
                MessageBox.Show("Successfully Registered!");

                Password = UserName = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
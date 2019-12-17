using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VTFDesktopUI.Models;

namespace VTFDesktopUI.Helpers
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient apiClient;

        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];

            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri(api);
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("grant_type","password"),
                new KeyValuePair<string,string>("username",username),
                new KeyValuePair<string,string>("password",password)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<UserModel> GetUserInfo(string acces_token)
        {
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", acces_token);

            using (HttpResponseMessage response = await apiClient.GetAsync("/api/user"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<IEnumerable<UserModel>>();
                    UserModel userModel = result.FirstOrDefault();
                    userModel.loged_In = true;
                    return userModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<AuthenticatedUser> Register(RegisterUserModel registerUserModel)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("Email",registerUserModel.UserName),
                new KeyValuePair<string,string>("Password",registerUserModel.Password),
                new KeyValuePair<string,string>("ConfirmPassword",registerUserModel.ConfirmPassword)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("/api/Account/Register", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<EventModel> GetEventsByMonth(string acces_token, string date, string status)
        {
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", acces_token);

            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("date",date.ToString()),
                new KeyValuePair<string,string>("status",status)
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("api/events/GetEventsByMonth", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<IEnumerable<EventModel>>();
                    EventModel eventModel = result.FirstOrDefault();
                    return eventModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
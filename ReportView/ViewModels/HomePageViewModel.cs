using Caliburn.Micro;
using ReportView.Helpers;
using ReportView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportView.ViewModels
{
    public class HomePageViewModel : Screen
    {
        public HomePageViewModel()
        {
        }


        private BindableCollection<PersonModel> _people;

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { Set(ref _people, value); }
        }

        public async Task SearchPeople()
        {
            People = await DataAcces.GetPeople() as BindableCollection<PersonModel>;
        }

    }
}

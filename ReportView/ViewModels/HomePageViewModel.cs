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
            People = new BindableCollection<PersonModel>();

            #region Add people to list
            //People.Add(new PersonModel()
            //{
            //    department = "Department",
            //    email = "test@test.com",
            //    first_name = "First",
            //    last_name = "Second",
            //    id = "1",
            //    salary = "3555"
            //});
            //People.Add(new PersonModel()
            //{
            //    department = "Department",
            //    email = "test@test.com",
            //    first_name = "asd",
            //    last_name = "Secdgasgond",
            //    id = "1",
            //    salary = "3555"
            //});
            //People.Add(new PersonModel()
            //{
            //    department = "Department",
            //    email = "test@test.com",
            //    first_name = "asdf",
            //    last_name = "asdf",
            //    id = "1",
            //    salary = "3555"
            //});

            #endregion


        }


        private BindableCollection<PersonModel> _people;

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { Set(ref _people, value); }
        }

        public async Task SearchPeople()
        {
            var items = await DataAcces.GetPeople();

            foreach (var item in items)
            {
                People.Add(item);
            }

            Console.WriteLine("Done conversion");
        }

    }
}

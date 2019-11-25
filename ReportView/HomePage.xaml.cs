using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReportView
{
    
    public partial class HomePage : Page
    {
        private List<Person> people = new List<Person>();
        private List<PersonView> peopleView = new List<PersonView>();
        private MainWindow parent;
        public HomePage(MainWindow mainWindow)
        {
            this.parent = mainWindow;
            InitializeComponent();

            Search_Action();

            homePageStackPanel.Children.Clear();

            foreach (PersonView personView in peopleView)
            {
                homePageStackPanel.Children.Add(personView);
            }

        }

        private void Search_Action()
        {
            DataAcces db = new DataAcces();

            people = db.GetPeople();

            foreach(Person person in people)
            {
                PersonView personView = new PersonView(parent,person);
                peopleView.Add(personView);
            }

        }
    }
}

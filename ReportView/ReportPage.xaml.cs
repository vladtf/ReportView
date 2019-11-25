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
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        MainWindow parent;

        //stuff we want to get from database
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string salary { get; set; }

        private void FullInfo(Person person)
        {
            this.id = person.id;
            this.first_name = person.first_name;
            this.last_name = person.last_name;
            this.email = person.email;
            this.department = person.department;
            this.salary = person.salary;

            
        }
        public ReportPage(MainWindow mainWindow, Person person)
        {
            parent = mainWindow;

            FullInfo(person);

            InitializeComponent();

            idTextBlock.Text = id;
            emailTextBlock.Text = email;
            salaryTextBlock.Text = salary;
            dateTextBlock.Text = department;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parent.RemoveChild(this);
        }
    }
}

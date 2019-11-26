using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ReportView
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl
    {
        //stuff we want to get from database
        public string id { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string salary { get; set; }

        public string hire_date { get; set; }

        private void FullInfo(Person person)
        {
            this.id = person.id;
            this.first_name = person.first_name;
            this.last_name = person.last_name;
            this.email = person.email;
            this.department = person.department;
            this.salary = person.salary;
            this.hire_date = person.hire_date;
        }

        private MainWindow parent;
        private Person person;

        public PersonView(MainWindow mainWindow, Person person)
        {
            this.parent = mainWindow;
            this.person = person;

            FullInfo(person);

            InitializeComponent();

            this.lastNameTextBlock.Text = this.last_name;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            backgroundBorder.Opacity = 0.4;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            backgroundBorder.Opacity = 0.2;
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            nextBorder.Background = new SolidColorBrush(Colors.LightGray) { Opacity = 1 };
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            nextBorder.Background = new SolidColorBrush(Colors.LightGray) { Opacity = 0 };
        }

        private void backgroundBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                parent.NewReportPage(person);
        }

        private void nextBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.NewReportPage(person);
        }
    }
}
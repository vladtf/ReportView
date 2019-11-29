using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ReportView
{
    /// <summary>
    /// Interaction logic for personViewScroll.xaml
    /// </summary>
    public partial class personViewScroll : UserControl
    {
        //stuff we want to get from database
        public string id { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string salary { get; set; }

        public string hire_date { get; set; }

        //randomizer

        private Random r = new Random();

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

        public personViewScroll(MainWindow mainWindow, Person person)
        {
            this.parent = mainWindow;
            this.person = person;

            FullInfo(person);

            InitializeComponent();

            this.lastNameTextBlock.Text = this.last_name;

            personIcon.Foreground = RandomColor();
            personIcon.Text = SetDepartmentText(department);
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
            parent.NewReportPageView(person);
        }

        private void nextBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.CloseReportPage(this);
        }

        private Brush RandomColor()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),(byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            return brush;
        }

        private string SetDepartmentText(string text)
        {
            switch (text)
            {
                case "Accounting": return "📒";
                case "Business Development": return "📊 ";
                case "Engineering": return "⚙";
                case "Human Resources": return "👥";
                case "Legal": return "⚖️";
                case "Marketing": return "📢";
                case "Product Management": return "📦";
                case "Research and Development": return "🔬";
                case "Sales": return "💰";
                case "Services": return "🛠️";
                case "Support": return "📞";
                case "Training": return "☑️";
            }
            return null;
        }
    }
}
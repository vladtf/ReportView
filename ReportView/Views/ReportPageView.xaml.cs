using ReportView.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ReportView.Views
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPageView : UserControl
    {
        private ShellView parent;

        //stuff we want to get from database
        public string id { get; set; }

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string salary { get; set; }
        public string hire_date { get; set; }

        private void FullInfo(PersonModel person)
        {
            this.id = person.id;
            this.first_name = person.first_name;
            this.last_name = person.last_name;
            this.email = person.email;
            this.department = person.department;
            this.salary = person.salary;
            this.hire_date = person.hire_date;
        }

        public ReportPageView(ShellView mainWindow, PersonModel person)
        {
            parent = mainWindow;

            FullInfo(person);

            InitializeComponent();

            idTextBlock.Text = id;
            emailTextBlock.Text = email;
            salaryTextBlock.Text = salary;
            dateTextBlock.Text = hire_date;
            firstTextBlock.Text = first_name;
            lastTextBlock.Text = last_name;
            ICOTextBlock.Text = SetDepartmentText(department);
            departmentTextBlock.Text = department;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parent.RemoveChild(this);
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Border border = (Border)sender;
            if (border == secondCenterBorder)
                firsCenterBorder.Opacity = 1;
            else
                border.Opacity += 0.2;
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Border border = (Border)sender;

            if (border == secondCenterBorder)
                firsCenterBorder.Opacity = 0.8;
            else
                border.Opacity -= 0.2;
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
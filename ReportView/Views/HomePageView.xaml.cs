using ReportView.Helpers;
using ReportView.Models;
using ReportView.Views;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ReportView.Views

{
    public partial class HomePageView : UserControl
    {
        private List<PersonModel> people = new List<PersonModel>();
        private List<PersonView> peopleView = new List<PersonView>();
        private ShellView parent;

        public HomePageView(ShellView mainWindow)
        {
            this.parent = mainWindow;
            InitializeComponent();
        }

        private async Task Search_Action()
        {

            people = await DataAcces.GetPeople() as List<PersonModel>;

            //people = db.GetPeople();

            foreach (PersonModel person in people)
            {
                PersonView personView = new PersonView(parent, person);
                //peopleView.Add(personView);
            }
        }

        public async Task Initial_Search_Action()
        {
            people?.Clear();
            peopleView?.Clear();
            homePageStackPanel?.Children.Clear();
            try
            {
                await Search_Action();

                foreach (PersonView personView in peopleView)
                {
                    homePageStackPanel.Children.Add(personView);
                }

                parent.connectionStatus.Foreground = new SolidColorBrush(Colors.Green); parent.connectionICON.Foreground = new SolidColorBrush(Colors.Transparent);
            }
            catch { parent.connectionStatus.Foreground = new SolidColorBrush(Colors.Red); parent.connectionICON.Foreground = new SolidColorBrush(Colors.Red); }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Display_Selected();
        }

        private void Display_Selected()
        {
            homePageStackPanel.Children.Clear();
            if (textBox.Text == "") foreach (PersonView personView in peopleView) { homePageStackPanel.Children.Add(personView); }
            else
                foreach (PersonView personView in peopleView)
                {
                    if (Regex.IsMatch(personView.person.last_name.ToLower() + " ", $"{textBox.Text.ToLower()}+.")) homePageStackPanel.Children.Add(personView);
                }
        }

        private void Display_Selected_Department(string department)
        {
            homePageStackPanel.Children.Clear();
            foreach (PersonView personView in peopleView)
            {
                if (personView.person.department == department) homePageStackPanel.Children.Add(personView);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Display_Selected();
        }

        private async void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            await parent.Do_Login();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            PopupBox.IsPopupOpen = false;
            Display_Selected_Department(button.Tag.ToString());
        }
    }
}
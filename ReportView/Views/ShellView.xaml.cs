using ReportView.Helpers;
using ReportView.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ReportView.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        private HomePageView homePage;

        private List<ScrollView> peopleViewScrolls = new List<ScrollView>();

        public ShellView()
        {

            InitializeComponent();

            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;


            homePage = new HomePageView(this);
            homePage.Height = pageViewer.Height;

            pageViewer.Navigate(homePage);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                if (this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized;
                else
                    this.WindowState = WindowState.Normal;
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            ConfigHelper helper = new ConfigHelper();
            helper.SaveConnectionString("work", "");
            this.Close();
        }

        private void Minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                minimizeButton.Content = "🗗";
            }
            else
            {
                this.WindowState = WindowState.Normal;
                minimizeButton.Content = "🗖";
            }
        }

        public void RemoveChild(ReportPageView reportPage)
        {
            pageViewer.Content = homePage;
        }

        public void NewReportPage(PersonModel person)
        {
            ReportPageView reportPage = new ReportPageView(this, person);
            ScrollView personView = new ScrollView(this, person);
            allOpenedPages.Children.Add(personView);
            peopleViewScrolls.Add(personView);
            reportPage.Height = pageViewer.Height;
            pageViewer.Content = null;
            pageViewer.Content = reportPage;
        }

        public void NewReportPageView(PersonModel person)
        {
            ReportPageView reportPage = new ReportPageView(this, person);
            reportPage.Height = pageViewer.Height;
            pageViewer.Content = null;
            pageViewer.Content = reportPage;
        }

        public void CloseReportPage(ScrollView personViewScroll)
        {
            allOpenedPages.Children.Remove(personViewScroll);
            pageViewer.Content = homePage;
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            if (pageViewer.NavigationService.CanGoBack)
                pageViewer.NavigationService.GoBack();
        }

        private void goForward_Click(object sender, RoutedEventArgs e)
        {
            if (pageViewer.NavigationService.CanGoForward)
                pageViewer.NavigationService.GoForward();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            pageViewer.NavigationService.Navigate(homePage);

            while (pageViewer.CanGoBack)
                pageViewer.NavigationService.RemoveBackEntry();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            serverText.Items.Add(@"SKIPPER-9TUVD5O\VLADDB");
            serverText.Items.Add("work.database.windows.net");
            serverText.Items.Add(".");
            serverText.Items.Add("(local)");
            serverText.SelectedIndex = 0;

            databaseText.Items.Add("work");
            databaseText.SelectedIndex = 0;

            // The password character is an asterisk.
            passwordText.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordText.MaxLength = 14;

            //Set last login saved
            usernameText.Text = ConfigHelper.LoginVal("login");
        }

        private void connection_Click(object sender, RoutedEventArgs e)
        {
            Do_Login();
            PopupBox.IsPopupOpen = false;
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Do_Login();
        }

        public void Do_Login()
        {
            string connectionString = string.Format(@"Data Source={1};Initial Catalog=work;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False",
                serverText.Text, databaseText.Text, usernameText.Text, passwordText.Password);
            try
            {
                ConfigHelper helper = new ConfigHelper();
                helper.SaveConnectionString("work", connectionString);
                homePage.Initial_Search_Action();
                helper.SaveLoginString("login", usernameText.Text);
            }
            catch { }
        }
    }
}
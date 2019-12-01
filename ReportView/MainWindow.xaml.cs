using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
namespace ReportView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HomePage homePage;

        private List<personViewScroll> peopleViewScrolls = new List<personViewScroll>();
        public MainWindow()
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            InitializeComponent();

            homePage = new HomePage(this);
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
            Helper helper = new Helper();
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

        public void RemoveChild(ReportPage reportPage)
        {
            pageViewer.Content = homePage;
        }

        public void NewReportPage(Person person)
        {
            ReportPage reportPage = new ReportPage(this, person);
            personViewScroll personView = new personViewScroll(this, person);
            allOpenedPages.Children.Add(personView);
            peopleViewScrolls.Add(personView);
            reportPage.Height = pageViewer.Height;
            pageViewer.Content = null;
            pageViewer.Content = reportPage;
        }

        public void NewReportPageView(Person person)
        {
            ReportPage reportPage = new ReportPage(this, person);
            reportPage.Height = pageViewer.Height;
            pageViewer.Content = null;
            pageViewer.Content = reportPage;
        }

        public void CloseReportPage(personViewScroll personViewScroll)
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
            usernameText.Text = Helper.LoginVal("login");
        }

        private void connection_Click(object sender, RoutedEventArgs e)
        {
            Do_Login();
            PopupBox.IsPopupOpen = false;

        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            Do_Login();
        }

        public void Do_Login()
        {
            string connectionString = string.Format("Server=tcp:{0},1433;Initial Catalog={1};Persist Security Info=False;User ID={2};Password={3};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
                serverText.Text, databaseText.Text, usernameText.Text, passwordText.Password);
            try
            {
                Helper helper = new Helper();
                helper.SaveConnectionString("work", connectionString);
                homePage.Initial_Search_Action();
                helper.SaveLoginString("login", usernameText.Text);
            }
            catch { }
        }
    }
}
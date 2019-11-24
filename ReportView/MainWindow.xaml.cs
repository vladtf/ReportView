using System.Windows;
using System.Windows.Input;

namespace ReportView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HomePage HomePage = new HomePage();

        public MainWindow()
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            InitializeComponent();

            HomePage.Height = pageViewer.Height;
            pageViewer.Content = HomePage;

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
    }
}
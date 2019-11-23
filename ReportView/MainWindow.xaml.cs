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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomePage HomePage = new HomePage();
        public MainWindow()
        {
            InitializeComponent();

            HomePage.Height = pageViewer.Height;
            pageViewer.Content = HomePage;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
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
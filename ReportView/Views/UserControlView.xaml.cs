using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ReportView.Views
{
    /// <summary>
    /// Interaction logic for UserControlView.xaml
    /// </summary>
    public partial class UserControlView : UserControl
    {
        public UserControlView()
        {
            InitializeComponent();
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
    }
}
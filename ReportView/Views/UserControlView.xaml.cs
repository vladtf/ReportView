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

namespace ReportView.Views
{
    /// <summary>
    /// Interaction logic for UserControlView.xaml
    /// </summary>
    public partial class UserControlView : UserControl
    {
        private Random r = new Random();
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

        private Brush RandomColor()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
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

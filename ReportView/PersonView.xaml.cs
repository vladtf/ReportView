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
        private void FullInfo(Person person)
        {
            this.id = person.id;
            this.first_name = person.first_name;
            this.last_name = person.last_name;
            this.email = person.email;
            this.department = person.department;
        }

        public PersonView(Person person)
        {

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

        

          
    }
}

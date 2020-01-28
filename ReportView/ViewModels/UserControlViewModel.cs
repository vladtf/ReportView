using System.Windows;

namespace ReportView.ViewModels
{
    internal class UserControlViewModel
    {
        public UserControlViewModel()
        {
        }

        public void SelectedPerson()
        {
            MessageBox.Show("Clicked");
        }
    }
}
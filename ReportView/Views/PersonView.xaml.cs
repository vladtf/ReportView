﻿using ReportView.Models;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ReportView.Views
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : UserControl
    {
        private ShellView parent;

        //the person select
        public PersonModel person;

        public PersonView(ShellView mainWindow, PersonModel person)
        {
            this.parent = mainWindow;

            this.person = person;

            InitializeComponent();

            this.lastNameTextBlock.Text = $"{person.last_name} {person.first_name.Substring(0, 1)}. ";
            departmentTextBlock.Text = SetDepartmentText(person.department);
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

        private void backgroundBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            parent.NewReportPage(person);
        }

        private void nextBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.NewReportPage(person);
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
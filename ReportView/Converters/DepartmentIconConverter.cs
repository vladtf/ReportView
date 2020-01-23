using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ReportView.Converters
{
    public class DepartmentIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var department = value as string;

            switch (department)
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
            return "";

            //return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
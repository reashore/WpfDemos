using System;
using System.Globalization;
using System.Windows.Data;

namespace DataConverter
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime? dateTime = (DateTime?) value;
            return dateTime?.ToString("d");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueString = value as string;

            if (DateTime.TryParse(valueString, out var dateTime))
            {
                return dateTime;
            }

            throw new Exception("Cannot convert string to DateTime");
        }
    }
}

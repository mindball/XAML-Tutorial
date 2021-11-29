using System;
using System.Globalization;
using System.Windows.Data;

namespace DataBinding.IValueConverterDemo
{
    public class DateValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueAsString = value.ToString();
            string[] vs = valueAsString
                .Split(new string[] { "***" }, StringSplitOptions.RemoveEmptyEntries);

            int day = int.Parse(vs[0]);
            int month = int.Parse(vs[1]);
            int year = int.Parse(vs[2]);

            return new DateTime(year, month, day);
        }
    }
}

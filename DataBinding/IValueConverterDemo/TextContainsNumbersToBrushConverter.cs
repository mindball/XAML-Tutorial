using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;

namespace DataBinding.IValueConverterDemo
{
    public class TextContainsNumbersToBrushConverter : IValueConverter
    {
        public Brush NormalBrush { get; set; }

        public Brush HighlightBrush { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return this.NormalBrush;

            var text = value.ToString();
            bool result = text.Any(c => char.IsDigit(c));

            return result ? HighlightBrush : NormalBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

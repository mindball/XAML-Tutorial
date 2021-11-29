﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace DataBinding.IValueConverterDemo
{
    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(value.ToString().ToLower())
            {
                case "yes":
                case "oui":
                        return true;
                case "no":
                case "non":
                    return false;
                default: return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if ((bool)value == true)
                    return "yes";
                else
                    return "no";    
            }

            return "no";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBinding.IValueConverterDemo.GenericIValueConverter
{
    public abstract class ValueConverter<TSourceTarget> : ValueConverter<TSourceTarget, TSourceTarget> { }
    public abstract class ValueConverter<TSource, TTarget> : ValueConverter<TSource, TTarget, object> { }
    public abstract class ValueConverter<TSource, TTarget, TParameter> : IValueConverter
    {
        protected abstract TTarget Convert(
            TSource value, 
            Type targetType, 
            TParameter parameter, 
            CultureInfo culture);

        protected abstract TSource ConvertBack(
            TTarget value,
            Type targetType,
            TParameter paramater,
            CultureInfo culture);

        object IValueConverter.Convert(
            object value, 
            Type targetType, 
            object parameter, 
            CultureInfo culture)
        {
            if(value != null && !(value is TSource))
            {
                throw new InvalidCastException(string.Format(
                    "In order to use the generic IValueConverter you have to use the correct type." +
                    " The Passing type was {0} but the expected is {1}", 
                    value.GetType(), 
                    typeof(TSource)));
            }
            
            if(parameter != null && !(parameter is TParameter))
            {
                throw new InvalidCastException(string.Format(
                    "In order to use the generic IValueConverter you have to use the correct type " +
                    "as ConvertParameter.The passing type was {0} but the expected is {1}", 
                    parameter.GetType(), 
                    typeof(TParameter)));
            }

            return this.Convert((TSource)value, targetType, (TParameter)parameter, culture);
        }

        object IValueConverter.ConvertBack(
            object value, 
            Type targetType, 
            object parameter, 
            CultureInfo culture)
        {
            if(value != null && !(value is TTarget))
            {
                throw new InvalidCastException(string.Format(
                    "In order to use the generic IValueConverter you have to use the correct type. " +
                    "The passing type was {0} but the expected is {1}",
                    value.GetType(),
                    typeof(TTarget)));
            }

            if(parameter != null && !(parameter is TParameter))
            {
                throw new InvalidCastException(string.Format(
                   "In order to use the generic IValueConverter you have to use the correct type " +
                   "as ConvertParameter.The passing type was {0} but the expected is {1}",
                   parameter.GetType(),
                   typeof(TParameter)));
            }

            return this.ConvertBack((TTarget)value, targetType, (TParameter)parameter, culture);
        }
    }
}

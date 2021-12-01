using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataBinding.Validations
{
    public class UserNameValidationRule : ValidationRule
    {
        public int MinLegth => 4;

        public int MaxLegth => 20;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string objectAsString = (string)value;
            bool isValidUserName = objectAsString.Length >= this.MinLegth
                && objectAsString.Length <= this.MaxLegth;

            if (isValidUserName)
                return new ValidationResult(true, null);

            return new ValidationResult(false, $"Username should be between {this.MinLegth} and {this.MaxLegth} symbols");
        }
    }
}

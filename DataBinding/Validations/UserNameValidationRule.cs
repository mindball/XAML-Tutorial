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
        private int minLength;
        private int maxLength;
        public int MinLegth 
        {
            get => 2;
            set
            {
                this.minLength = value;
            }
        }

        public int MaxLegth
        {
            get => 20;
            set
            {
                this.maxLength = value;
            }
        }

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

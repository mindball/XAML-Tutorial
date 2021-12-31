using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigationAndEvents.EventsAndDelegate
{
    /// <summary>
    /// Interaction logic for ValueUC.xaml
    /// </summary>
    public partial class ValueUC : UserControl
    {
        private const int MaxValue = 100;
        private const int MinValue = 0;

        public delegate void OnMinThresHoldReached(object sender, RoutedEventArgs e);
        public event OnMinThresHoldReached MinThresHoldReached;

        public delegate void OnMaxThresHoldReached(object sender, RoutedEventArgs e);
        public event OnMaxThresHoldReached MaxThresHoldReached;

        public ValueUC()
        {
            InitializeComponent();
        }

        private void ValueLabel_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (TextBox)sender;
            var labelValue = ConvertFromStringToInt(textBox.Text);
            if(labelValue < MinValue)
            {
                textBox.Text = MinValue.ToString();
                MinThresHoldReached(sender, e);
            }
            else if (labelValue > MaxValue)
            {
                textBox.Text = MaxValue.ToString();
                MaxThresHoldReached(sender, e);
            }
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            var labelValue = ConvertFromStringToInt(ValueLabel.Text);
            var buttonValue = Math.Abs(ConvertFromStringToInt(((Button)sender).Content.ToString()));

            ValueLabel.Text = (labelValue + buttonValue).ToString();
        }

        private void Minus_Button_Click(object sender, RoutedEventArgs e)
        {
            var labelValue = ConvertFromStringToInt(ValueLabel.Text);
            var buttonValue = Math.Abs(ConvertFromStringToInt(((Button)sender).Content.ToString()));

            ValueLabel.Text = (labelValue - buttonValue).ToString();
        }

        private int ConvertFromStringToInt(string currentValue)
        {
            
            if (int.TryParse(currentValue, out int convertLabelValue))
            {
                return convertLabelValue;
            }

            return 0;
        }

    }
}

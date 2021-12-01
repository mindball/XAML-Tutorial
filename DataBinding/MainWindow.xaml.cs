using DataBinding.IntellitectDemo;
using DataBinding.IValueConverterDemo;
using DataBinding.Validations;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeForegroundOfButton(object sender, RoutedEventArgs e)
        {
            ChangeForegroundColorOfButton apl = new ChangeForegroundColorOfButton();
            apl.Show();
        }

        private void BindingDemo_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollectionDemo demo = new ObservableCollectionDemo();
            demo.Show();    
        }

        private void NotifyPropertyChanged_Click(object sender, RoutedEventArgs e)
        {
            NotifyPropertyChanged demo = new NotifyPropertyChanged();
            demo.Show();
        }

        private void Intelliteck_Click(object sender, RoutedEventArgs e)
        {
            Window1 demo = new Window1();
            demo.Show();
        }

        private void Converter_Click(object sender, RoutedEventArgs e)
        {
            ValueConvererDemo demo = new ValueConvererDemo();
            demo.Show();
        }

        private void SimpleConverter_Click(object sender, RoutedEventArgs e)
        {
            SimpleConvertedDemo demo = new SimpleConvertedDemo();
            demo.Show();
        }

        private void TextContainsNumbersToBrush_Click(object sender, RoutedEventArgs e)
        {
            TextContainsNumbersToBrush demo = new TextContainsNumbersToBrush();
            demo.Show();
        }

        private void Validation_Click(object sender, RoutedEventArgs e)
        {
            UserNameInput demo = new UserNameInput();
            demo.Show();
        }
    }
}

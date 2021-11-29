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
using System.Windows.Shapes;

namespace DataBinding.IValueConverterDemo
{
    /// <summary>
    /// Interaction logic for ValueConvererDemo.xaml
    /// </summary>
    public partial class ValueConvererDemo : Window
    {
        public ValueConvererDemo()
        {
            var car = new CarViewModel();
            this.DataContext = car;
            InitializeComponent();
        }
    }
}

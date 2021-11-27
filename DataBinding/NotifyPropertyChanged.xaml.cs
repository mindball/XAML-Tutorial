using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for NotifyPropertyChanged.xaml
    /// </summary>
    public partial class NotifyPropertyChanged : Window
    {
        private CarViewModel car;

        public NotifyPropertyChanged()
        {
            InitializeComponent();
            car = new CarViewModel();
            this.DataContext = car;
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            this.car.Model += "Changed";
        }

        private void ChangeCar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

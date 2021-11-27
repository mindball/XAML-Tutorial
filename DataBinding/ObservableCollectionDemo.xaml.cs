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
    /// Interaction logic for ObservableCollectionDemo.xaml
    /// </summary>
    public partial class ObservableCollectionDemo : Window
    {
        private readonly ObservableCollection<Car> cars;
        public ObservableCollectionDemo()
        {
            InitializeComponent();
            this.cars = new ObservableCollection<Car>();           
            this.DataContext = new { Cars = this.cars };           
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            this.cars.Add(new Car() { Manufacture = "Audi", Model = "S8"});
        }

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ChangeCar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

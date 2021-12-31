using Data;
using ShirtsModels;
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

namespace WorkShopShirt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext context ;
        public MainWindow()
        {
            InitializeComponent();
            this.context = new ApplicationDbContext();
            var shirts = this.context.Shirts.ToList();
            foreach (var children in shirts)
            {
                ListViewPanel.Items.Add(children.Model);
            }
        }

        private async void Save(object sender, RoutedEventArgs e)
        {
            var newShirt = this.context.Shirts.Add(new Shirt
            {
                Model = Model.Text,
                Manufacturer = Manufacture.Text,
                Price = decimal.Parse(Price.Text),
                Dirtiness = double.Parse(Dirty.Text)
            });

            await this.context.SaveChangesAsync();
            ListViewPanel.Items.Add(newShirt.Model);
        }
    }
}

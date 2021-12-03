using ChessBazar.ViewModels;
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

namespace ChessBazar.Views
{
    /// <summary>
    /// Interaction logic for GrandMasterView.xaml
    /// </summary>
    public partial class GrandMasterView : Page
    {
        public GrandMasterView()
        {
            InitializeComponent();
            this.DataContext = new GrandMasterViewModel();
        }

        private void NavigateToAdd(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GrandMasterAddView());
        }
    }
}

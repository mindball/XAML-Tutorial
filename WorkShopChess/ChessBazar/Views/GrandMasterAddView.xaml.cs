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
    /// Interaction logic for GrandMasterAddView.xaml
    /// </summary>
    public partial class GrandMasterAddView : Page
    {
        private GrandMasterAddViewModel viewModel;
        public GrandMasterAddView()
        {
            InitializeComponent();
            this.DataContext = this.viewModel = new GrandMasterAddViewModel();
        }
        

        private void SaveGM_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.Add();
        }
    }
}

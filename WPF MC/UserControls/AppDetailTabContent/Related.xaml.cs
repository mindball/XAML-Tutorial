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

namespace WPF_MC.UserControls.AppDetailTabContent
{
    /// <summary>
    /// Interaction logic for Related.xaml
    /// </summary>
    public partial class Related : UserControl
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;


        public Related()
        {
            InitializeComponent();
            AppsViewer5.AppClicked += CurrentApp_Clicked;
        }
        private void CurrentApp_Clicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}

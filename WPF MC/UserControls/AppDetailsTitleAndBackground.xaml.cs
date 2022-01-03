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

namespace WPF_MC.UserControls
{
    /// <summary>
    /// Interaction logic for AppDetailsTitleAndBackground.xaml
    /// </summary>
    public partial class AppDetailsTitleAndBackground : UserControl
    {
        public delegate void OnBackMainButtonPressed(AppDetailsTitleAndBackground sender, RoutedEventArgs e);
        public event OnBackMainButtonPressed BackMainButtonPressed;   

        public AppDetailsTitleAndBackground()
        {
            InitializeComponent();
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            BackMainButtonPressed(this, e);
        }
    }
}

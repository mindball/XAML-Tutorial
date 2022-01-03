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
using WPF_MC.UserControls;

namespace WPF_MC.Pages
{
    /// <summary>
    /// Interaction logic for AppDetails.xaml
    /// </summary>
    public partial class AppDetails : Page
    {
        public delegate void OnBackMainButtonPressed(AppDetailsTitleAndBackground sender, RoutedEventArgs e);
        public event OnBackMainButtonPressed BackMainButtonPressed;

        public AppDetails(AnApp appDetail)
        {
            InitializeComponent();

            AppDetailsTitleAndBackgroundUC.AppNameLabel.Content = appDetail.AppName;
            AppDetailsTitleAndBackgroundUC.AppImage.Source = appDetail.AppImageSource;

            AppDetailsTitleAndBackgroundUC.BackMainButtonPressed += AppDetailsTitleAndBackgroundUC_BackButtonClicked;
        }

        private void AppDetailsTitleAndBackgroundUC_BackButtonClicked(AppDetailsTitleAndBackground sender, RoutedEventArgs e)
        {
            BackMainButtonPressed(sender, e);
        }
    }
}

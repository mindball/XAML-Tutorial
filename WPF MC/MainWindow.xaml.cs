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
using WPF_MC.Pages;
using WPF_MC.UserControls;

namespace WPF_MC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main MainWindowsContentPage;
        private AppDetails AppDetailsContentPage;

        public MainWindow()
        {
            InitializeComponent();
            MainWindowsContentPage = new Main();
            MainWindowsContentPage.AppClicked += MainWindowContentPage_AppClicked;
        }
            

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetailsContentPage = new AppDetails(sender);
            AppDetailsContentPage.AppClicked += MainWindowContentPage_AppClicked;
            AppDetailsContentPage.BackMainButtonPressed += MyAppDetails_BackButtonClicked;
            MainWindowFrame.Content = AppDetailsContentPage;
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MainWindowsContentPage;
            //MainWindowFrame.Content = AppDetailsContentPage;
        }

        private void MyAppDetails_BackButtonClicked(AppDetailsTitleAndBackground sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
                MainWindowFrame.NavigationService.GoBack();
        }
    }       
}

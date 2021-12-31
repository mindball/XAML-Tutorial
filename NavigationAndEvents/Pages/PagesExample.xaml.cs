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

namespace NavigationAndEvents.Pages
{
    /// <summary>
    /// Interaction logic for PagesExample.xaml
    /// </summary>
    public partial class PagesExample : Window
    {
        public Page1 PageOne;
        public Page2 PageTwo;
        public Page3 PageThree;

        public PagesExample()
        {
            InitializeComponent();

            PageOne = new Page1();
            PageTwo = new Page2();            
            PageThree = new Page3();

            //Same
            PageThree.GoPage1 += Button_Click_1;
            PageThree.GoPage1 += GoPage1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = PageOne;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = PageTwo;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = PageThree;
        }

        private void Button_Click_Backward(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
                MainWindowFrame.NavigationService.GoBack();

        }

        private void Button_Click_Forward(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoForward)
                MainWindowFrame.NavigationService.GoForward();
        }

        private void GoPage1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = PageOne;
        }
    }
}


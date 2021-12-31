using NavigationAndEvents.EventsAndDelegate;
using NavigationAndEvents.Pages;
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

namespace NavigationAndEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void PageExaples(object sender, RoutedEventArgs e)
        {
            PagesExample wnd = new PagesExample();  
            wnd.Show(); 
        }

        private void EventAndDeleageExaples(object sender, RoutedEventArgs e)
        {
            EventsAndDelegates wnd = new EventsAndDelegates();
            wnd.Show();
        }
    }
}

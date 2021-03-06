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

namespace NavigationAndEvents.Pages
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public delegate void OnGoPage1ButtonClick(object sender, RoutedEventArgs e);
        public event OnGoPage1ButtonClick GoPage1;

        public Page3()
        {
            InitializeComponent();
        }

        private void ShowPageOne_Click(object sender, RoutedEventArgs e)
        {
            GoPage1(sender, e);
        }
    }
}

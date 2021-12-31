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

namespace NavigationAndEvents.EventsAndDelegate
{
    /// <summary>
    /// Interaction logic for EventsAndDelegates.xaml
    /// </summary>
    public partial class EventsAndDelegates : Window
    {
        public EventsAndDelegates()
        {
            InitializeComponent();
            ValueUController.MinThresHoldReached += MinThresHoldReached;
            ValueUController.MaxThresHoldReached += MaxThresHoldReached;
        }

        private void MaxThresHoldReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Max value reached");

        }

        private void MinThresHoldReached(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Min value reached");
        }

    }
}

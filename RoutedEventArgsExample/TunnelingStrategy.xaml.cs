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

namespace RoutedEventArgsExample
{
    /// <summary>
    /// Interaction logic for TunnelingStrategy.xaml
    /// </summary>
    public partial class TunnelingStrategy : Window
    {
        public TunnelingStrategy()
        {
            InitializeComponent();
        }

        private void OuterButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            DisplayLabel.Content += "Outer Button";
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayLabel.Content += "Inner Button";
        }
    }
}

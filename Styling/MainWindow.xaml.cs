using Styling.TriggersDemo;
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

namespace Styling
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

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            
            this.secondRect.Fill = (SolidColorBrush)this.Resources["brushResourceCustomColor"];
        }

        private void Trigers_Click(object sender, RoutedEventArgs e)
        {
            TriggersWPF tr = new TriggersWPF();
            tr.Show();
        }
    }
}

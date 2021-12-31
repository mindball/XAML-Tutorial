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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for CanvasWPF.xaml
    /// </summary>
    public partial class CanvasWPF : Window
    {
        public CanvasWPF()
        {
            InitializeComponent();
        }

        private void MoveLeft(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(Blue, Canvas.GetLeft(Blue) + 300);
        }
    }
}

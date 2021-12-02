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

namespace Styling.DataTriggersDemo
{
    /// <summary>
    /// Interaction logic for DataTriggersWPF.xaml
    /// </summary>
    public partial class DataTriggersWPF : Window
    {
        private bool isRed = true;
        public DataTriggersWPF()
        {
            InitializeComponent();
            this.DataContext = new { IsRed = isRed };
        }

        private void IsRed_Click(object sender, RoutedEventArgs e)
        {
            this.isRed = !isRed;
            this.DataContext = new { IsRed = isRed };
        }
    }
}

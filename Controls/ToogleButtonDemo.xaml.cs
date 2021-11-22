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

namespace Controls
{
    /// <summary>
    /// Interaction logic for ToogleButtonDemo.xaml
    /// </summary>
    public partial class ToogleButtonDemo : Window
    {
        private bool? isChecked;
        public ToogleButtonDemo()
        {
            InitializeComponent();
            MessageBox.Show(isChecked.ToString());
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (isChecked == null)
            {
                isChecked = false;
            }

            isChecked = !isChecked;
            MessageBox.Show(isChecked.ToString());
        }
    }
}

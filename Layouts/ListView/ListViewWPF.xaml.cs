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

namespace Layouts.ListView
{
    /// <summary>
    /// Interaction logic for ListViewWPF.xaml
    /// </summary>
    public partial class ListViewWPF : Window
    {
        public ListViewWPF()
        {
            InitializeComponent();
        }

        private void ListViews(object sender, RoutedEventArgs e)
        {
            var listViewItem = (ListViewItem)sender;
            MessageBox.Show(listViewItem.Content.ToString());


        }
    }
}

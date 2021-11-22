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

namespace Controls
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

        private void ShowToogleButton(object sender, RoutedEventArgs e)
        {
            ToogleButtonDemo form = new ToogleButtonDemo();
            form.Show();
        }

        private void ShowGridWithoutPosition(object sender, RoutedEventArgs e)
        {
            GridWithoutSpecificPositioning form = new GridWithoutSpecificPositioning();
            form.Show();
        }

        private void ShowGridWithPosition(object sender, RoutedEventArgs e)
        {
            GridWithSpecificPositioning form = new GridWithSpecificPositioning();
            form.Show();
        }

        private void ShowStackPanel(object sender, RoutedEventArgs e)
        {
            StackPanelPositioning form = new StackPanelPositioning();
            form.Show();
        }

        private void ShowGroupName(object sender, RoutedEventArgs e)
        {
            GroupNameWithStackPanel groupNameWithStackPanel = new GroupNameWithStackPanel();            
            groupNameWithStackPanel.Show();
        }

        private void ShowGroupBox(object sender, RoutedEventArgs e)
        {
            GroupBoxDemo groupBoxDemo = new GroupBoxDemo();
            groupBoxDemo.Show();
        }
    }
}

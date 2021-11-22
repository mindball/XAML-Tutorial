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
    /// Interaction logic for GroupNameWithStackPanel.xaml
    /// </summary>
    public partial class GroupNameWithStackPanel : Window
    {
        private RadioButton radioButton;
        public GroupNameWithStackPanel()
        {
            InitializeComponent();
        }

        private void SelectShoe(object sender, RoutedEventArgs e)
        {
            radioButton = sender as RadioButton;
            MessageBox.Show(radioButton.Content.ToString() + " is selected");
        }
    }
}

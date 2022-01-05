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

namespace WPF_MC.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Reviews.xaml
    /// </summary>
    public partial class Reviews : UserControl
    {
        public Reviews()
        {
            InitializeComponent();
            //TODO: Step 8: Clear the stack panel elements before adding new ones
            //Delete the StackPanel loaded method
            MainStackPanel.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                MainStackPanel.Children.Add(new Areview());
            }
            //Now you can also run the app and show them that the bug is fixed because
            //we clear the stack panel at the beginning
            //also because we moved it into the constructor it only gets called when
            //the object is first initialized, not every time it is loaded
            //It is still good practice to clear the stack panel though before adding
            //elements
        }
    }
}

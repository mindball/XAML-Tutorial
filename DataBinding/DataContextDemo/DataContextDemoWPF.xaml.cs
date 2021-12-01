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

namespace DataBinding.DataContextDemo
{
    /// <summary>
    /// Interaction logic for DataContextDemoWPF.xaml
    /// </summary>
    public partial class DataContextDemoWPF : Window
    {
        public DataContextDemoWPF()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}

using Controls.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for GroupBoxDemo.xaml
    /// </summary>
    public partial class GroupBoxDemo : Window
    {
        public GroupBoxDemo()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            TShirt model = new TShirt();
            model.Model = Model.Text.ToString();
            model.Manufacturer = Manufacture.Text.ToString();
            model.IsDirty = Dirty.IsChecked;
            model.Size = Size.Text.ToString();

            var jsonResult = JsonConvert.SerializeObject(model);

            using (StreamWriter writer = new StreamWriter("database.json"))
            {
                writer.Write(jsonResult);
            }
        }
    }
}

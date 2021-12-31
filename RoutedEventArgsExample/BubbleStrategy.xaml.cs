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

namespace RoutedEventArgsExample
{
    /// <summary>
    /// Interaction logic for BubbleStrategy.xaml
    /// </summary>
    public partial class BubbleStrategy : Window
    {
        public BubbleStrategy()
        {
            InitializeComponent();
            Button b2 = new Button();
            b2.Content = "Button 2";
            StP.Children.Add(b2);
            b2.AddHandler(Button.ClickEvent, new RoutedEventHandler(Onb2Clicked));
        }

        private void Onb2Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Buttton 2");
        }

        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "YesButton":
                    // do something here ...
                    break;
                case "NoButton":
                    // do something ...
                    break;
                case "CancelButton":
                    // do something ...
                    break;
            }
            e.Handled = true;
        }

        private void MakeButton(object sender, RoutedEventArgs e)
        {
            Button b4 = new Button();
            b4.Content = "New Button";
            // Associate event handler to the button. You can remove the event
            // handler using "-=" syntax rather than "+=".
            b4.Click += new RoutedEventHandler(Onb2Click);
            StP.Children.Insert(StP.Children.Count, b4);
            DockPanel.SetDock(b4, Dock.Top);
            text1.Text = "Now click the second button...";
            b3.IsEnabled = false;
        }



        void Onb2Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "New Button (b2) Was Clicked!!";
        }

        private void BorderClickHandler(object sender, RoutedEventArgs e)
        {
            BorderParrent.BorderBrush = Brushes.IndianRed;
        }

    }
}

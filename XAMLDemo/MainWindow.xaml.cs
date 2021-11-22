using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace XAMLDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();            
            doubleAnimation.From = 0;
            doubleAnimation.To = 360;
            
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            RotateTransform rotateTransform = new RotateTransform();
            MyButton.RenderTransform = rotateTransform;
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, doubleAnimation);

        }
    }
}

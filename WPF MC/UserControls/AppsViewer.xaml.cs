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

namespace WPF_MC.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        private List<AnApp> PresentedApps;
        public AppsViewer()
        {
            InitializeComponent();

            PresentedApps = new List<AnApp>();

            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 9; i++)
            {
                var anApp = new AnApp();
                PresentedApps.Add(anApp);
            }
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            //var firstAnAppItem = PresentedApps.First();
            //var widthOfOneApp = (int)firstAnAppItem.ActualWidth + 2 * (int)firstAnAppItem.Margin.Left;
            //AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset + 4 * widthOfOneApp);

            int widthOfOneApp = (int)PresentedApps.First().ActualWidth + 2 * (int)PresentedApps.First().Margin.Left;
            AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset - 4 * widthOfOneApp);
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            //var firstAnAppItem = PresentedApps.First();
            //var widthOfOneApp = firstAnAppItem.ActualWidth + 2 * firstAnAppItem.Margin.Left;
            //AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset + 4 * (int)widthOfOneApp);

            int widthOfOneApp = (int)PresentedApps.First().ActualWidth + 2 * (int)PresentedApps.First().Margin.Left;
            AppScrollViewer.ScrollToHorizontalOffset(AppScrollViewer.HorizontalOffset + 4 * widthOfOneApp);
        }

        private void AppScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            //the same
            //eventArg.Source = sender;
            eventArg.Source = this;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArg);

            //The same
            //if (!e.Handled)
            //{
            //    e.Handled = true;
            //    var e2 = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta) { RoutedEvent = UIElement.MouseWheelEvent };

            //    var parent = ((Control)sender).Parent as UIElement;
            //    parent.RaiseEvent(e2);

            //}
        }
    }
}

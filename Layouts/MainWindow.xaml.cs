using Layouts.ListView;
using Layouts.Panels;
using Layouts.TabControl;
using System.Windows;

namespace Layouts
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

        private void CanvasWPF(object sender, RoutedEventArgs e)
        {
            CanvasWPF canvas = new CanvasWPF();
            canvas.Show();
        }

        private void StackPanels(object sender, RoutedEventArgs e)
        {
            StackPanelWPF stackPanel = new StackPanelWPF();
            stackPanel.Show();
        }

        private void WrapPanels(object sender, RoutedEventArgs e)
        {
            Wrappanel wrapPanel = new Wrappanel();
            wrapPanel.Show();
        }

        private void Tabs(object sender, RoutedEventArgs e)
        {
            Tabs tabs = new Tabs();
            tabs.Show();
        }

        private void ListViews(object sender, RoutedEventArgs e)
        {
            ListViewWPF lv = new ListViewWPF();
            lv.Show();
        }
    }
}

using ChessBazar.Data;
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

namespace ChessBazar.Controls
{
    /// <summary>
    /// Interaction logic for ChessFigureView.xaml
    /// </summary>
    public partial class ChessFigureView : UserControl
    {
        public ChessFigureView()
        {
            InitializeComponent();
        }

        public ICommand DragInitEvent
        {
            get
            {
                return (ICommand)GetValue(DragInitEventProperty);
            }
            set
            {
                SetValue(DragInitEventProperty, value);
            }
        }

        public ICommand DragPushEvent
        {
            get
            {
                return (ICommand)GetValue(DragPushEventProperty);
            }
            set
            {
               SetValue(DragPushEventProperty, value);
            }
        }

        public static readonly DependencyProperty DragInitEventProperty =
            DependencyProperty.Register(
                "DragInitEvent",
                typeof(ICommand),
                typeof(ChessFigureView));

        public static readonly DependencyProperty DragPushEventProperty =
           DependencyProperty.Register(
               "DragPushEvent",
               typeof(ICommand),
               typeof(ChessFigureView));

        public static readonly DependencyProperty FigureProperty =
            DependencyProperty.Register(
                "Figure",
                typeof(ChessFigure),
                typeof(ChessFigureView));

        public ChessFigure Figure
        {
            get
            {
                return (ChessFigure)GetValue(FigureProperty);   
            }
            set
            {
                SetValue(FigureProperty, value);
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Figure.ToString());
        }

        private void DragInitHandler(object sender, MouseButtonEventArgs e)
        {
            DragInitEvent.Execute(Figure);   
        }

        private void DragPushHandler(object sender, MouseButtonEventArgs e)
        {
            DragPushEvent.Execute(Figure);          
        }
    }
}

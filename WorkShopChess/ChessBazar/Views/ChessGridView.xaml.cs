using Autofac;
using ChessBazar.ViewModels;
using System.Windows.Controls;

namespace ChessBazar.Views
{
    /// <summary>
    /// Interaction logic for ChessGridView.xaml
    /// </summary>
    public partial class ChessGridView : Page
    {        
        public ChessGridView()
        {            
            InitializeComponent();
            this.DataContext = Bootstraper.Container.Resolve<ChessGridViewModel>();
        }
    }
}

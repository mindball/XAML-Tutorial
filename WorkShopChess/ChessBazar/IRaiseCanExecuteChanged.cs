using System.Windows.Input;

namespace ChessBazar
{
    public interface IRaiseCanExecuteChanged : ICommand
    {
        /// <summary>
        /// Raise the <see cref="ICommand.CanExecuteChanged"/> event.
        /// </summary>
        void RaiseCanExecuteChanged();
    }
}

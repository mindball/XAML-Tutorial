using System;
using System.Windows.Input;

namespace DataBinding.IntellitectDemo
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> executeAction;
        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> executeAction)
        {
            this.executeAction = executeAction;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => this.executeAction(parameter);
    }
}

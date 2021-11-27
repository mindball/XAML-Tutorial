using System.Windows.Input;

namespace DataBinding.IntellitectDemo
{
    public class ViewModel : ViewModelBase
    {
        private string firstName;
        private readonly DelegateCommand _changeNameCommand;

        public ViewModel()
        {
            this._changeNameCommand = new DelegateCommand(OnChangeName);
        }

        public ICommand ChangeNameCommand => this._changeNameCommand;

        public string FirstName 
        {
            get => this.firstName;

            set => this.SetProperty(ref this.firstName, value);
        }

        private void OnChangeName(object commandParameter)
        {
           this.FirstName = "Walter";
        }
    }
}

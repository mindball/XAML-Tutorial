using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ChessBazar.ViewModels
{
    public class BaseNotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
            {
                var propArgs = new PropertyChangedEventArgs(prop);
                PropertyChanged(this, propArgs);
            }
        }
    }
}
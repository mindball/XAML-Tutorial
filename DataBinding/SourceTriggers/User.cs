using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBinding.SourceTriggers
{
    public class User : INotifyPropertyChanged
    {
        private string userName;
        private string password;
        private string email;

        public event PropertyChangedEventHandler PropertyChanged;

        public User()
        {
            this.UserName = "testname";
            this.Password = "secretPass";
            this.Email = "test@email.com";
        }

        public string UserName
        {
            get { return this.userName; }
            set 
            { 
                this.userName = value;
                this.OnProperyChanged();
            }
        }        

        public string Password
        {
            get { return this.password; }
            set 
            { 
                password = value;
                this.OnProperyChanged();
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
                this.OnProperyChanged();
            }
        }

        public void OnProperyChanged([CallerMemberName] string propName = "")
        {
            if (PropertyChanged != null)
            {
                var propertyChangedEventArgs = new PropertyChangedEventArgs(propName);
                PropertyChanged(this, propertyChangedEventArgs);
            }
        }
    }
}

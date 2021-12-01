using System.Windows;
using System.Windows.Controls;

namespace DataBinding.Validations
{
    /// <summary>
    /// Interaction logic for UserNameInput.xaml
    /// </summary>
    public partial class UserNameInput : Window
    {
        public UserNameInput()
        {
            InitializeComponent();
            var user = new User();
            this.DataContext = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Validation.GetHasError(this.InputUserName))
            {
                var errors = Validation.GetErrors(this.InputUserName);
                string errorMsg = (string)errors[0].ErrorContent;
                MessageBox.Show(errorMsg, "Error");
            }
        }
    }
}

namespace AcademySystem.WpfClient.ViewModels
{
    using System.Windows;

    using System.Windows.Input;

    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.WpfClient.Data;
    using System.Windows.Controls;

    public class UserRegisterFormViewModel : BaseVewModel, IPageViewModel
    {
        private ICommand registerCommand;

        public string Name
        {
            get
            {
                return "Register";
            }
        }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public ICommand Register
        {
            get
            {
                if (this.registerCommand == null)
                {
                    this.registerCommand = new RelayCommand(this.HandleRegisterCommand);
                }

                return this.registerCommand;
            }
        }
        
        private void HandleRegisterCommand(object parameter)
        {

            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;
            //var authenticationCode = this.GetSHA1HashData(password);
            //var rePasswordBox = parameter as PasswordBox;
            //var password = passwordBox.Password;

            DataPersister.RegisterUser("12312", "12312312", "12312312", "awdasdas", "asdasdasd");
        }
    }
}
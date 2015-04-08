namespace AcademySystem.WpfClient.ViewModels
{
    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.WpfClient.Data;
    using AcademySystem.WpfClient.Helpers;
    using System;
    using System.Windows.Controls;
    using System.Windows.Input;

    public class UserLoginFormViewModel : BaseVewModel, IPageViewModel
    {
        private ICommand loginCommand;

        public string Name
        {
            get
            {
                return "Login";
            }
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICommand Login
        {
            get
            {
                if (this.loginCommand == null)
                {
                    this.loginCommand = new RelayCommand(this.HandleLoginCommand);
                }

                return this.loginCommand;
            }
        }

        public event EventHandler<LoginSuccessArgs> LoginSuccess;

        private void HandleLoginCommand(object parameter)
        {
            //var passwordBox = parameter as PasswordBox;
            //var password = passwordBox.Password;
            //var authenticationCode = this.GetSHA1HashData(password);

            //var username = DataPersister.LoginUser(this.Username, authenticationCode);

            //if (!string.IsNullOrEmpty(username))
            //{
            //    this.RaiseLoginSuccess(username);
            //}
        }

        private string GetSHA1HashData(string data)
        {
            return "0123456789012345678901234567890123456789";
        }

        private void RaiseLoginSuccess(string username)
        {
            if (this.LoginSuccess != null)
            {
                this.LoginSuccess(this, new LoginSuccessArgs(username));
            }
        }
    }
}
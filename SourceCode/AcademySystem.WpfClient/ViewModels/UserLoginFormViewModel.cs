
namespace AcademySystem.WpfClient.ViewModels
{
    using System;
    using System.Windows.Input;
    using AcademySystem.WpfClient.Behavior;

    public class UserLoginFormViewModel : BaseVewModel
    {
        private ICommand loginCommand;
        private string message;

        public string Username { get; set; }

        public string Password { get; set; }

        public string Msg
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        public ICommand LoginCommand
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

        private void HandleLoginCommand(object parameter)
        {
            this.Msg = string.Format("Username: {0}, \nPassowrd: {1}", this.Username, this.Password);
        }
    }
}

namespace AcademySystem.WpfClient.ViewModels
{
    using System.Windows.Input;

    using AcademySystem.WpfClient.Behavior;

    public class UserRegisterFormViewModel : BaseVewModel
    {
        private ICommand registerCommand;
        private string message;

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        // For testing purposes
        public string Msg
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
                this.OnPropertyChanged("Msg");
            }
        }

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
            this.Msg = string.Format("Username: {0},\nEmail: {1},\nPassowrd: {2}", this.Username, this.Email, this.Password);
        }
    }
}
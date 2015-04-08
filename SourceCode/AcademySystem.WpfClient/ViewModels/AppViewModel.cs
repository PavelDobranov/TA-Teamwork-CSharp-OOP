namespace AcademySystem.WpfClient.ViewModels
{
    using System.Collections.Generic;
    using System.Windows.Input;
    
    using AcademySystem.WpfClient.Behavior;

    public class AppViewModel : BaseVewModel
    {
        private IPageViewModel currentViewModel;
        private ICommand changeViewModelCommand;
        private ICommand logoutCommand;
        private bool loggedInUser = false;

        public AppViewModel()
        {
        }

        public IPageViewModel CurrentViewModel
        {
            get
            {
                return this.currentViewModel;
            }
            set
            {
                this.currentViewModel = value;
                this.OnPropertyChanged("CurrentViewModel");
            }
        }

        public bool LoggedInUser
        {
            get
            {
                return this.loggedInUser;
            }
            set
            {
                this.loggedInUser = value;
                this.OnPropertyChanged("LoggedInUser");
            }
        }

        public UserRegisterFormViewModel UserRegisterFormVM { get; set; }

        public UserLoginFormViewModel UserLoginFormVM { get; set; }

        public List<IPageViewModel> ViewModels { get; set; }

        public ICommand ChangeViewModel
        {
            get
            {
                if (this.changeViewModelCommand == null)
                {
                    this.changeViewModelCommand = new RelayCommand(this.HandleChangeViewModelCommand);
                }

                return this.changeViewModelCommand;
            }
        }

        //public ICommand Logout
        //{
        //    get
        //    {
        //        if (this.logoutCommand == null)
        //        {
        //            this.logoutCommand = new RelayCommand(this.HandleLogoutCommand);
        //        }
        //        return this.logoutCommand;
        //    }
        //}

        //private void HandleLogoutCommand(object parameter)
        //{
        //    bool isUserLoggedOut = DataPersister.LogoutUser();
        //    if (isUserLoggedOut)
        //    {
        //        this.Username = string.Empty;
        //        this.LoggedInUser = false;
        //        this.HandleChangeViewModelCommand(this.LoginRegisterVM);
        //    }
        //}

        private void HandleChangeViewModelCommand(object parameter)
        {
            var newCurrentViewModel = parameter as IPageViewModel;
            this.CurrentViewModel = newCurrentViewModel;
        }

       

        //public void LoginSuccessful(object sender, LoginSuccessArgs e)
        //{
        //    this.Username = e.Username;
        //    this.LoggedInUser = true;
        //    this.HandleChangeViewModelCommand(this.ViewModels[0]);
        //}

        public string Username { get; set; }
    }
}
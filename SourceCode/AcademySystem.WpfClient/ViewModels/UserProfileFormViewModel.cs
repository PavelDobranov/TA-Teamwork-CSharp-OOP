namespace AcademySystem.WpfClient.ViewModels
{
    using System;
    using System.Windows.Input;
    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.Models;
    using System.Windows;

    public class UserProfileFormViewModel : BaseVewModel, IPageViewModel
    {
        private ICommand addPictureComand;

        public string Name
        {
            get
            {
                return "Profile";
            }
        }


        public ICommand AddPicture
        {
            get
            {
                if (this.addPictureComand == null)
                {
                    this.addPictureComand = new RelayCommand(this.HandleAddPictureCommand);
                }

                return this.addPictureComand;
            }
        }

        private void HandleAddPictureCommand(object parameter)
        {
            //TODO: using System.Windows;
            MessageBox.Show("Adding picture - Impossible!");
        }
    }
}

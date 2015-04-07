namespace AcademySystem.WpfClient.ViewModels
{
    using System;
    using System.Windows.Input;

    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.Models.Training;
    using AcademySystem.Models.Training.Contracts;

    public class CourseDetailsFormViewModel : BaseVewModel
    {
        private ICommand subscribeCommand;

        public ICommand Subscribe
        {
            get
            {
                if (this.subscribeCommand == null)
                {
                    this.subscribeCommand = new RelayCommand(this.HandleLoginCommand);
                }

                return this.subscribeCommand;
            }
        }

        private void HandleLoginCommand(object parameter)
        {

        }
    }
}

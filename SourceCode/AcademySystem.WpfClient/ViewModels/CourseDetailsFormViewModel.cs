namespace AcademySystem.WpfClient.ViewModels
{
    using System;
    using System.Windows.Input;

    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.Models.Training;
    using AcademySystem.Models.Training.Contracts;

    public class CourseDetailsFormViewModel : BaseVewModel, IPageViewModel
    {
        private ICommand subscribeCommand;

        public string Name
        {
            get
            {
                return "Course Details";
            }
        }

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

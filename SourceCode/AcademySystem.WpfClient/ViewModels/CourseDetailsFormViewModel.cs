namespace AcademySystem.WpfClient.ViewModels
{
    using System;
    using System.Windows.Input;
    
    using AcademySystem.WpfClient.Behavior;
    using AcademySystem.Models.Training;

    public class CourseDetailsFormViewModel : BaseVewModel
    {
        private ICommand subscribeCommand;

        public FreeCourse FreeCourse {get; set;}

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

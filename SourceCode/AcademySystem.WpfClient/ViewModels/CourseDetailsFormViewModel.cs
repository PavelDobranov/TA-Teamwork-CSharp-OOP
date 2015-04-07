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

        public ICourse Course { get; set; }

        public DateTime Date
        {
            get
            {
                return Course.StartDateTime.Date;
            }
        }

        public TimeSpan StartTime
        {
            get
            {
                return Course.StartDateTime.TimeOfDay;
            }
        }

        public TimeSpan EndTime
        {
            get
            {
                return Course.EndDateTime.TimeOfDay;
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

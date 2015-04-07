namespace AcademySystem.WpfClient.Behavior
{
    using System;
    using System.Windows.Input;

    public delegate bool CanExecuteDelegate(object parameter);
    public delegate void ExecuteDelegate(object parameter);

    public class RelayCommand : ICommand
    {
        private CanExecuteDelegate canExecute;
        private ExecuteDelegate execute;

        public RelayCommand(ExecuteDelegate execute)
            : this(null, execute)
        {
        }

        public RelayCommand(CanExecuteDelegate canExecute, ExecuteDelegate execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null)
            {
                return true;
            }

            return this.canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}

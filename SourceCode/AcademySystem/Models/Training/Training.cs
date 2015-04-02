namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;

    public abstract class Training : ITraining
    {
        private string name;
        private string category;
        private DateTime startDateTime;
        private DateTime endDateTime;

        public Training(string name, string category, DateTime start, DateTime end, int maxTrainingDuration)
        {
            this.Name = name;
            this.Category = category;

            if (start >= end)
            {
                throw new ArgumentException(
                    string.Format(
                        ErrorMessage.InvalidDurationMessage,
                        typeof(Training).GetProperty("StartDateTime").Name,
                        typeof(Training).GetProperty("EndDateTime").Name));
            }

            if (!Training.ValidTrainingDuration(start, end, maxTrainingDuration))
            {
                throw new ArgumentException(
                    string.Format(
                    ErrorMessage.InvalidDurationMessage, 
                    typeof(Training).GetProperty("StartDateTime").Name, 
                    typeof(Training).GetProperty("EndDateTime").Name));
            }

            this.StartDateTime = start;
            this.EndDateTime = end;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(Training).GetProperty("Name").Name));
                }

                this.name = value;
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(Training).GetProperty("Category").Name));
                }

                this.category = value;
            }
        }

        public DateTime StartDateTime
        {
            get
            {
                return this.startDateTime;
            }
            private set
            {
                this.startDateTime = value;
            }
        }

        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTime;
            }
            private set
            {
                this.endDateTime = value;
            }
        }

        private static bool ValidTrainingDuration(DateTime start, DateTime end, int maxTrainingHours)
        {
            TimeSpan duration = end - start;
            TimeSpan maxDuration = new TimeSpan(maxTrainingHours, 0, 0);

            bool isValid = true;

            if (duration > maxDuration)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}

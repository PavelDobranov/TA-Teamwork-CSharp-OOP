namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;

    public class Exercise : Training, IExercise 
    {
        public Exercise(string name, string category, DateTime startTime, DateTime endTime)
            :base(name, category)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Trainers = new List<ITrainer>();
        }

        public DateTime StartTime
        {
            get;
            set;
        }
        
        public DateTime EndTime
        {
            get;
            set;
        }

        public List<ITrainer> Trainers
        {
            get;
            private set;
        }

        public void AddTrainer(ITrainer trainer)
        {
            this.Trainers.Add(trainer);
        }
    }
}

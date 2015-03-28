namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;


    class Lecture : Training, ILecture
    {
        public Lecture(string name, string category, DateTime startTime, DateTime endTime, ITrainer trainer)
            : base(name, category)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Trainer = trainer;
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

        public ITrainer Trainer
        {
            get;
            set;
        }
    }
}

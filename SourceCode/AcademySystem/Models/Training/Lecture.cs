namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;


    public class Lecture : Training, ILecture
    {
        public Lecture(string name, string category, DateTime startTime, DateTime endTime, ITrainer trainer, IHomework homework)
            : base(name, category)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Trainer = trainer;
            this.Homework = homework;
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


        public IHomework Homework
        {
            get;
            set;
        }
    }
}

namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;


    public class Lecture : TrainingClass, ILecture
    {
        public Lecture(string name, string category, DateTime startTime, DateTime endTime, ITrainer trainer, IHomework homework)
            : base(name, category, startTime, endTime)
        {
            this.Trainer = trainer;
            this.Homework = homework;
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

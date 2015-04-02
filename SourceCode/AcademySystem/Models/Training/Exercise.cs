namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;

    public class Exercise : TrainingClass, IExercise
    {
        public Exercise(string name, string category, DateTime startTime, DateTime endTime)
            : base(name, category, startTime, endTime)
        {
            this.Trainers = new List<ITrainer>();
        }

        public List<ITrainer> Trainers
        {
            get;
            private set;
        }

        public void AddTrainer(ITrainer trainer)
        {
            if (trainer == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, trainer.GetType().Name));
            }

            this.Trainers.Add(trainer);
        }
    }
}

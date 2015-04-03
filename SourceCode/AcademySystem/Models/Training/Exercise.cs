namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;
    using AcademySystem.Humans;

    public class Exercise : TrainingClass, IExercise
    {
        private ICollection<ITrainer> trainers;

        public Exercise(string name, string category, DateTime startTime, DateTime endTime)
            : base(name, category, startTime, endTime)
        {
            this.trainers = new List<ITrainer>();
        }

        public ICollection<ITrainer> Trainers
        {
            get
            {
                List<ITrainer> deepCopy = new List<ITrainer>();

                foreach (var item in this.trainers)
                {
                    deepCopy.Add(item);
                }

                return deepCopy;
            }
        }

        public void AddTrainer(ITrainer trainer)
        {
            if (trainer == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, trainer.GetType().Name));
            }
            //TODO Deep copy probably
            this.trainers.Add(trainer);
        }
    }
}

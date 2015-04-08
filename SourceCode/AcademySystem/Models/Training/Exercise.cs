namespace AcademySystem.Models.Training
{
    using System;
    using System.Collections.Generic;
    using AcademySystem.Models.Humans.Contracts;
    using AcademySystem.Models.Training.Contracts;
    using System.Runtime.Serialization;

    [DataContract]
    public class Exercise : TrainingClass, IExercise
    {
        private ICollection<ITrainer> trainers;
        private ICollection<Task> tasks;

        public Exercise(string name, string category, DateTime startTime, DateTime endTime)
            : base(name, category, startTime, endTime)
        {
            this.trainers = new List<ITrainer>();
            this.tasks = new List<Task>();
        }

        [DataMember(Name = "trainers")]
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

        [DataMember(Name = "tasks")]
        public ICollection<Task> Tasks
        {
            get
            {
                List<Task> deepCopy = new List<Task>();

                foreach (var item in this.tasks)
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

        public void AddTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, task.GetType().Name));
            }
            //TODO Deep copy probably
            this.tasks.Add(task);
        }
    }
}

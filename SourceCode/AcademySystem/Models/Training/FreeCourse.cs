namespace AcademySystem.Models.Training
{
    using System;
    using System.Collections.Generic;

    using AcademySystem.Models.Training.Contracts;
    using System.Runtime.Serialization;

    [DataContract]
    public class FreeCourse : Training, ITraining, ICourse
    {
        private const int MaxTrainingDuration = 500;

        private ICollection<TrainingClass> trainingClasses;

        public FreeCourse(string name, string category, DateTime startDate, DateTime endDate, string description)
            : base(name, category, startDate, endDate, MaxTrainingDuration)
        {
            this.Description = description;

            this.trainingClasses = new List<TrainingClass>();
        }

        [DataMember(Name = "description")]
        public string Description { get; private set; }

        [DataMember(Name = "trainingClasses")]
        public ICollection<TrainingClass> TrainingClasses
        {
            get
            {
                List<TrainingClass> deepCopy = new List<TrainingClass>();

                foreach (var item in this.trainingClasses)
                {
                    deepCopy.Add(item);
                }

                return deepCopy;
            }
        }

        public void AddTrainingClass(TrainingClass trainingClass)
        {
            if (trainingClass == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, trainingClass.GetType().Name));
            }
            //TODO Deep copy
            this.trainingClasses.Add(trainingClass);
        }

        public void RemoveTrainingClass(TrainingClass trainingClass)
        {
            if (trainingClass == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, trainingClass.GetType().Name));
            }
            //TODO Deep copy
            this.trainingClasses.Remove(trainingClass);
        }
    }
}

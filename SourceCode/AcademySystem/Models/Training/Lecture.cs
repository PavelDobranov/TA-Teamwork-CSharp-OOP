namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using AcademySystem.Models.Humans.Contracts;
    using AcademySystem.Models.Training.Contracts;
    using System.Runtime.Serialization;

    [DataContract]
    public class Lecture : TrainingClass, ILecture
    {
        private ITrainer trainer;
        private IHomework homework;

        public Lecture(string name, string category, DateTime startTime, DateTime endTime, ITrainer trainer, IHomework homework)
            : base(name, category, startTime, endTime)
        {
            this.Trainer = trainer;
            this.Homework = homework;
        }

         [DataMember(Name = "trainer")]
        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(
                        string.Format(
                            ErrorMessage.NullObjectMessage, value.GetType().Name));
                }

                this.trainer = value;
            }
        }

         [DataMember(Name = "homework")]
        public IHomework Homework
        {
            get
            {
                return this.homework;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(
                        string.Format(
                            ErrorMessage.NullObjectMessage, value.GetType().Name));
                }

                this.homework = value;
            }
        }
    }
}

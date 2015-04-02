namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;
    using AcademySystem.Models.Training;

    public abstract class TrainingCourse : Training, ICourse
    {
        private const int MaxTrainingDuration = 500;

        public TrainingCourse(string name, string category, DateTime startDate, DateTime endDate, string description)
            : base(name, category, startDate, endDate, MaxTrainingDuration)
        {
            this.Description = description;
            this.Exercises = new List<IExercise>();
            this.Lectures = new List<ILecture>();
        }

        public List<IExercise> Exercises { get; private set; }

        public List<ILecture> Lectures { get; private set; }

        public string Description
        {
            get;
            private set;
        }

        public Mark Mark
        {
            get;
            set;
        }

        public void AddLecture(ILecture lectureToAdd)
        {
            if (lectureToAdd == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, lectureToAdd.GetType().Name));
            }

            this.Lectures.Add(lectureToAdd);
        }

        public void AddExercise(IExercise exerciseToAdd)
        {
            if (exerciseToAdd == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, exerciseToAdd.GetType().Name));
            }

            this.Exercises.Add(exerciseToAdd);
        }
    }
}

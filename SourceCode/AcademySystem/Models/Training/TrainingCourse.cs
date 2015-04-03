namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;
    using AcademySystem.Models.Training;

    public abstract class TrainingCourse : Training, ICourse
    {
        private const int MaxTrainingDuration = 500;

        private ICollection<IExercise> exercises;
        private ICollection<ILecture> lectures;

        public TrainingCourse(string name, string category, DateTime startDate, DateTime endDate, string description)
            : base(name, category, startDate, endDate, MaxTrainingDuration)
        {
            this.Description = description;

            this.exercises = new List<IExercise>();
            this.lectures = new List<ILecture>();
        }

        public ICollection<IExercise> Exercises 
        {
            get
            {
                List<IExercise> deepCopy = new List<IExercise>();

                foreach (var item in this.exercises)
                {
                    deepCopy.Add(item);
                }

                return deepCopy;
            }
        }

        public ICollection<ILecture> Lectures
        {
            get
            {
                List<ILecture> deepCopy = new List<ILecture>();

                foreach (var item in this.lectures)
                {
                    deepCopy.Add(item);
                }

                return deepCopy;
            }
        }

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
            //TODO Deep copy
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
            //TODO Deep Copy
            this.Exercises.Add(exerciseToAdd);
        }
    }
}

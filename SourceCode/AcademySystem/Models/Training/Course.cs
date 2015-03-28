namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;
    using AcademySystem.Models.Training;

    public class Course : Training, ICourse
    {
        public List<IExercise> Exercises { get; private set; }

        public List<ILecture> Lectures { get; private set; }

        public string Description
        {
            get;
            private set;
        }

        public DateTime StartDate
        {
            get;
            private set;
        }

        public DateTime EndDate
        {
            get;
            private set;
        }

        public void AddLecture(ILecture lectureToAdd)
        {
            this.Lectures.Add(lectureToAdd);
        }

        public void AddExercise(IExercise exerciseToAdd)
        {
            this.Exercises.Add(exerciseToAdd);
        }

        public decimal Price
        {
            get;
            private set;
        }
    }
}

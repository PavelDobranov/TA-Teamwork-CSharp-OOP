﻿namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using System.Collections.Generic;
    using AcademySystem.Models.Training;

    public abstract class Course : Training, ICourse
    {
        public Course(string name, string category, DateTime startDate, DateTime endDate, string description)
            : base(name, category)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
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
    }
}

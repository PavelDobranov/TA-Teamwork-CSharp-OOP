namespace AcademySystem.Models.Training
{
    using System;

    using AcademySystem.Models.Training.Contracts;

    public abstract class TrainingClass : Training, ITraining
    {
        private const int MaxTrainingHours = 8;

        public TrainingClass(string name, string category, DateTime start, DateTime end)
            : base(name, category, start, end, MaxTrainingHours)
        {
        }
    }
}


namespace AcademySystem.Models.Training
{
    using System;

    public abstract class TrainingClass : Training
    {
        private const int MaxTrainingHours = 8;

        public TrainingClass(string name, string category, DateTime start, DateTime end)
            : base(name, category, start, end, MaxTrainingHours)
        {
        }
    }
}

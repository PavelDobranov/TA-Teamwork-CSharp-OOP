namespace AcademySystem.Models.Training.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICourse : ITraining
    {
        string Description { get; }

        ICollection<TrainingClass> TrainingClasses { get; }
    }
}

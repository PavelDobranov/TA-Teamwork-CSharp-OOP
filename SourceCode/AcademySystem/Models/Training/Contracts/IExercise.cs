
namespace AcademySystem.Models.Training.Contracts
{
    using AcademySystem.Models.Humans.Contracts;
    using System;
    using System.Collections.Generic;

    public interface IExercise : ITraining
    {
        ICollection<ITrainer> Trainers { get; }
    }
}


namespace AcademySystem.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IExercise : ITraining
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        List<ITrainer> Trainers { get; }
    }
}

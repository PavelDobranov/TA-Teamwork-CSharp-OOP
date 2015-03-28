
namespace AcademySystem.Interfaces
{
    using System;
    using System.Collections.Generic;

    interface IExercise : IPayd
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        List<ITrainer> Trainers { get; }
    }
}

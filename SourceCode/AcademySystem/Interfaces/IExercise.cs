
namespace AcademySystem.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IExercise
    {
        List<ITrainer> Trainers { get; }
    }
}

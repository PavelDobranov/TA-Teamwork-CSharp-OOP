namespace AcademySystem.Interfaces
{
    using System;

    public interface ILecture : ITraining
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        ITrainer Trainer { get; }
    }
}

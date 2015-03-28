namespace AcademySystem.Interfaces
{
    using System;

    public interface ILecture : IPayd
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        ITrainer Trainer { get; }
    }
}

namespace AcademySystem.Interfaces
{
    using System;

    public interface ILecture
    {
        ITrainer Trainer { get; }
        IHomework Homework { get; }
    }
}

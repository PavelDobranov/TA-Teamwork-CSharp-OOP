namespace AcademySystem.Models.Training.Contracts
{
    using AcademySystem.Interfaces;
    using AcademySystem.Models.Humans.Contracts;
    using System;

    public interface ILecture
    {
        ITrainer Trainer { get; }

        IHomework Homework { get; }
    }
}

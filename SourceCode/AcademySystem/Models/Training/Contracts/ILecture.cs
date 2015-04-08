namespace AcademySystem.Models.Training.Contracts
{
    using AcademySystem.Models.Humans.Contracts;
    using System;

    public interface ILecture : ITraining
    {
        ITrainer Trainer { get; }

        Homework Homework { get; }
    }
}

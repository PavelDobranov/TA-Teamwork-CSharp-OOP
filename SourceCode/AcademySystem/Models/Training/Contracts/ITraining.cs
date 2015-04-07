namespace AcademySystem.Models.Training.Contracts
{
    using System;

    public interface ITraining
    {
        string Name { get; }

        string Category { get; }

        DateTime StartDateTime { get; }

        DateTime EndDateTime { get; }
    }
}
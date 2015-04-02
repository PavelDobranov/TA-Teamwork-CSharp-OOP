namespace AcademySystem.Interfaces
{
    using System;

    public interface ICourse : ITraining
    {
        string Description { get; }

        void AddLecture(ILecture lectureToAdd);
        void AddExercise(IExercise exerciseToAdd);
    }
}

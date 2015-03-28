namespace AcademySystem.Interfaces
{
    using System;

    public interface ICourse : IPayd
    {
        string Description { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }

        void AddLecture(ILecture lectureToAdd);
        void AddExercise(IExercise exerciseToAdd);
    }
}

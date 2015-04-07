namespace AcademySystem.Models.Humans.Contracts
{
    using System.Collections.Generic;

    using AcademySystem.Models.Training.Contracts;

    public interface IStudent : IHuman
    {
        int FacultyNumber { get; }

        ICollection<ICourse> Courses { get; }

        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}
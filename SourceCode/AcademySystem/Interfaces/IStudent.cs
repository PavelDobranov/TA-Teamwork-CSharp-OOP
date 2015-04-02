namespace AcademySystem.Interfaces
{
    using System.Collections.Generic;
    public interface IStudent : IUser
    {
        //properties
        int FacultyNumber { get; }

        ICollection<ICourse> ListOfCourses { get; }

        //methods
        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}

namespace AcademySystem.Interfaces
{
    using System.Collections.Generic;
    public interface ITrainer : IUser
    {
        //properties
        string Specialty { get; }

        string Webpage { get; }

        ICollection<ICourse> ListOfCourses { get; }

        //methods
        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}

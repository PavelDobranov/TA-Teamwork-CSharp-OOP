namespace AcademySystem.Interfaces
{
    using System.Collections.Generic;
    public interface ITrainer : IHuman
    {
        //properties
        string Specialty { get; }

        string Webpage { get; }

        ICollection<ICourse> listOfCourses { get; }

        //methods
        void AddCourse(ICourse course);

        void RemoveCourse(ICourse course);
    }
}

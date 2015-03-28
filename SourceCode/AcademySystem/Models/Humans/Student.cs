namespace AcademySystem.Humans
{
    using System;
    using System.Collections.Generic;
    
    using AcademySystem.Training;
    using AcademySystem.Interfaces;

    public class Student : Human, IStudent
    {
        private int facultyNumber;
        private ICollection<ICourse> courses;

        public Student(string firstName, string lastName, int age, string username, string email, string city,
                       Gender gender, int fn, ICollection<ICourse> courses)
            : base(firstName, lastName, age, username, email, city, gender)
        {
            this.FacultyNumber = fn;
            this.ListOfCourses = new List<ICourse>();
        }

        public int FacultyNumber { get; set; }

        ICollection<ICourse> ListOfCourses { get; set; }

        public void AddCourse(ICourse course)
        {
            this.ListOfCourses.Add(course);
        }

        public void RemoveCourse(ICourse course)
        {
            this.ListOfCourses.Remove(course);
        }
    }
}

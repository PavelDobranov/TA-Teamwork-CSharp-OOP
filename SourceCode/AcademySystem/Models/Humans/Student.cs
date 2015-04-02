namespace AcademySystem.Humans
{
    using System;
    using System.Collections.Generic;
    
    using AcademySystem.Models;
    using AcademySystem.Interfaces;

    public class Student : User, IStudent
    {
        // TO DELETE

        public Student(string firstName, string lastName, int age, string username, string email, string city,
                       Gender gender, int fn)
            : base(firstName, lastName, age, username, email, city, gender)
        {
            this.FacultyNumber = fn;
            this.ListOfCourses = new List<ICourse>();
        }

        public int FacultyNumber { get; set; }

        public ICollection<ICourse> ListOfCourses { get; set; }

        public void AddCourse(ICourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, course.GetType().Name));
            }

            this.ListOfCourses.Add(course);
        }

        public void RemoveCourse(ICourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(
                    string.Format(
                        ErrorMessage.NullObjectMessage, course.GetType().Name));
            }

            this.ListOfCourses.Remove(course);
        }
    }
}

namespace AcademySystem.Models.Humans
{
    using System;
    using System.Collections.Generic;

    using AcademySystem.Models.Humans.Contracts;
    using AcademySystem.Models.Training.Contracts;
    using System.Runtime.Serialization;
    [DataContract]
    public class Student : Human, IHuman, IStudent
    {
        private ICollection<ICourse> courses;

        public Student(string firstName, string lastName, int age, string city, Gender gender, int fn)
            : base(firstName, lastName, age, city, gender)
        {
            this.FacultyNumber = fn;
            this.courses = new List<ICourse>();
        }

        [DataMember(Name = "facultyNumber")]
        public int FacultyNumber { get; private set; }

        [DataMember(Name = "courses")]
        public ICollection<ICourse> Courses
        {
            get
            {
                // TODO: deep copy
                return new List<ICourse>(this.courses);
            }
        }

        public void AddCourse(ICourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(string.Format(ErrorMessage.NullObjectMessage, course.GetType().Name));
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(ICourse course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(string.Format(ErrorMessage.NullObjectMessage, course.GetType().Name));
            }

            this.Courses.Remove(course);
        }
    }
}

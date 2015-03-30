namespace AcademySystem.Humans
{
    using System;
    using System.Collections.Generic;

    using AcademySystem.Interfaces;

    public class Trainer : Human, ITrainer
    {
        //private ICollection<string> qualification;
        //private string description;
        //private string webPage;

        public Trainer(string firstName, string lastName, int age, string username, string email,
                    string city, Gender gender, string specialty, string webpage)
            : base(firstName, lastName, age, username, email, city, gender)
        {
            this.Specialty = specialty;
            this.Webpage = webpage;
        }

        public string Specialty { get; set; }

        public ICollection<string> Qualification { get; set; }

        public string Webpage { get; set; }


        public ICollection<ICourse> ListOfCourses { get; set; }

        //methods
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

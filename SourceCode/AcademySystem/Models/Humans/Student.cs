﻿namespace AcademySystem.Humans
{
    using System;
    using System.Collections.Generic;
    
    using AcademySystem.Training;
    using AcademySystem.Interfaces;

    public class Student : Human, IStudent
    {
        private int fN;
        private IEnumerable<Course> courses;

         public Student(string firstName, string lastName, int age, string username, string email, string city,
                        Gender gender, int fn, IEnumerable<Course> courses)
             : base(firstName, lastName, age, username, email, city, gender)
        {
            this.FN = fn;
            this.Courses = new List<Course>();
        }

         public int FN { get; set; }

         public List<Course> Courses { get; set; }
    }
}

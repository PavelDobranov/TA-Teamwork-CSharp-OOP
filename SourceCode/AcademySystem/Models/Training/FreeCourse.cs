
namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Interfaces;
    using AcademySystem.Training;

    public class FreeCourse : Course
    {
        public FreeCourse(string name, string category, DateTime start, DateTime end, string description)
            : base(name, category, start, end, description, 0)
        {
 
        }
    }
}

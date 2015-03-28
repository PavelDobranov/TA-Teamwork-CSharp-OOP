
namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Training;
    using AcademySystem.Interfaces;

    public class PaydCourse : Course , IPayd
    {
        public string Certificate { get;  private set; }

        
        public PaydCourse(string name, string category, DateTime start, DateTime end, string description, decimal price)
            : base(name, category, start, end, description, price)
        {
 
        }
    }
}

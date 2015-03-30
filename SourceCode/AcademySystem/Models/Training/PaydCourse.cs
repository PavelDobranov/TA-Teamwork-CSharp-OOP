
namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Models;
    using AcademySystem.Interfaces;

    public class PaydCourse : Course , IPayd
    {

        public PaydCourse(string name, string category, DateTime start, DateTime end, string description, decimal price)
            : base(name, category, start, end, description)
        {
            this.Price = price;
        }

        public decimal Price { get; private set; }      
        
        public string Certificate { get; set; }   
    }
}

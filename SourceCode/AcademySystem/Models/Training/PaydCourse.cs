﻿
namespace AcademySystem.Models.Training
{
    using System;
    using AcademySystem.Models;
    using AcademySystem.Interfaces;
    using AcademySystem.Models.Training.Contracts;

    public class PaydCourse : FreeCourse , IPayd
    {
        private decimal price;

        public PaydCourse(string name, string category, DateTime start, DateTime end, string description, decimal price)
            : base(name, category, start, end, description)
        {
            this.Price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format(
                            ErrorMessage.OutOfRangeMessage, this.Price.GetType().Name));
                }

                this.price = value;
            }
        }      
        
        public string Certificate { get; set; }   
    }
}

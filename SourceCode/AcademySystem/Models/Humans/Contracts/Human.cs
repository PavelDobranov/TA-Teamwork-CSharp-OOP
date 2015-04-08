namespace AcademySystem.Models.Humans.Contracts
{
    using System;
    using System.Runtime.Serialization;
    using AcademySystem.CustomException;

    [DataContract]
    public abstract class Human : IHuman
    {
        private static readonly int minAge = 0;
        private static readonly int maxAge = 150;

        private string firstName;
        private string lastName;
        private int age;
        private string city;

        protected Human(string firstName, string lastName, int age, string city, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        [DataMember(Name = "firstName")]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage, "FirstName"));
                }

                this.firstName = value;
            }
        }

        [DataMember(Name = "lasttName")]
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage, "LastName"));
                }

                this.lastName = value;
            }
        }

        [DataMember(Name = "age")]
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (this.age < minAge || this.age > maxAge)
                {
                    //Custom exception
                    throw new InvalidRangeException<int>(string.Format(ErrorMessage.InvalidRangeMessage, "Age", minAge, maxAge), minAge, maxAge);
                }

                this.age = value;
            }
        }

        [DataMember(Name = "city")]
        public string City
        {
            get
            {
                return this.city;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage, "City"));
                }

                this.city = value;
            }
        }

        [DataMember(Name = "gender")]
        public Gender Gender { get; set; }
    }
}

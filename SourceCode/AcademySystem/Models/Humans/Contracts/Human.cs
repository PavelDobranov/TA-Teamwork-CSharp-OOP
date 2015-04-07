namespace AcademySystem.Models.Humans.Contracts
{
    using System;

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
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage,"FirstName"));
                }

                this.firstName = value;
            }
        }

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
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage,"LastName"));
                }

                this.lastName = value;
            }
        }

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
                    throw new ArgumentNullException(string.Format(ErrorMessage.OutOfRangeMessage,minAge, maxAge));
                }

                this.age = value;
            }
        }

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
                    throw new ArgumentNullException(string.Format(ErrorMessage.NullOrEmptyPropertyMessage,"City"));
                }

                this.city = value;
            }
        }

        public Gender Gender { get; set; }
    }
}

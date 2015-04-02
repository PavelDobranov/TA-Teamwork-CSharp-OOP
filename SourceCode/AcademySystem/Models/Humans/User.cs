namespace AcademySystem.Humans
{
    using System;
    
    using AcademySystem.Interfaces;

    public class User : IUser
    {
        private static readonly int minAge = 0;
        private static readonly int maxAge = 150;

        private string firstName;
        private string lastName;
        private int age;
        private string username;
        private string email;
        private string city;

        public User(string firstName, string lastName, int age, string username, string email, string city, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Username = username;
            this.Email = email;
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
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage, 
                            typeof(User).GetProperty("FirstName").Name));
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
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(User).GetProperty("LastName").Name));
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
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.OutOfRangeMessage,
                            minAge, maxAge));
                }

                this.age = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(User).GetProperty("UserName").Name));
                }

                this.username = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(User).GetProperty("Email").Name));
                }

                this.email = value;
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
                    throw new ArgumentNullException(
                        string.Format(
                            ErrorMessage.NullOrEmptyPropertyMessage,
                            typeof(User).GetProperty("City").Name));
                }

                this.city = value;
            }
        }

        public Gender Gender { get; set; }
    }
}

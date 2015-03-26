namespace Academy.Humans
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private string username;
        private string email;
        private string city;


        public Human(string firstName, string lastName, int age, string username, string email, string city, Gender gender)
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
                //Exception
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
                //Exception
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
                //Exception
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
                //Exception
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
                //Exception
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
                //Exception
                this.city = value;
            }
        }

        public Gender Gender { get; set; }
    }
}

namespace AcademySystem.Humans
{
    using System;
    using System.Collections.Generic;

    using AcademySystem.Interfaces;

    public class Trainer : Human, ITrainer
    {
        private List<string> qualification;
        private string description;
        private string webPage;


        public Trainer(string firstName, string lastName, int age, string username, string email,
                    string city, Gender gender, string specialty, string webpage)
            : base(firstName, lastName, age, username, email, city, gender)
        {
            this.Specialty = specialty;
            this.WebPage = webPage;
        }

        public string Specialty { get; set; }

        public List<string> Qualification { get; set; }

        public string WebPage { get; set; }


        public string Webpage
        {
            get { throw new NotImplementedException(); }
        }
    }
}

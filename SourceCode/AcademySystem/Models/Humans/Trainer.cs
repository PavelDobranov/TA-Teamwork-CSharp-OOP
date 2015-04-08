namespace AcademySystem.Models.Humans
{
    using System.Collections.Generic;

    using AcademySystem.Models.Humans.Contracts;
    using System.Runtime.Serialization;
    [DataContract]
    public class Trainer : Human, IHuman, ITrainer
    {
        ICollection<string> qualifications;

        public Trainer(string firstName, string lastName, int age, string city, Gender gender,string webpage)
            : base(firstName, lastName, age, city, gender)
        {
            this.qualifications = new List<string>();
            this.Webpage = webpage;
        }
          [DataMember(Name = "qualifications")]
        public ICollection<string> Qualifications
        {
            get
            {
                return new List<string>(this.qualifications);
            }
        }

          [DataMember(Name = "webPage")]
        public string Webpage { get; set; }

        public void AddQualification(string qualification)
        {
            // TODO: validation
            this.qualifications.Add(qualification);
        }

        public void RemoveQualification(string qualification)
        {
            // TODO: validation
            this.qualifications.Remove(qualification);
        }
    }
}

namespace AcademySystem.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using AcademySystem.Models.Humans.Contracts;
    using System.Runtime.Serialization;
    [DataContract]
    public class User
    {
         [DataMember(Name = "userName")]
        public string Username { get; set; }

         [DataMember(Name = "email")]
        public string Email { get; set; }

         [DataMember(Name = "password")]
        public string Password { get; set; }

         [DataMember(Name = "human")]
        public IHuman Human { get; set; }

         [DataMember(Name = "roles")]
        public ICollection<string> roles { get; set; }
    }
}
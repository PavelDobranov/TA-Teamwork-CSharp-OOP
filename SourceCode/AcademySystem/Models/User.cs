namespace AcademySystem.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using AcademySystem.Models.Humans.Contracts;

    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        IHuman Human { get; set; }

        ICollection<string> roles { get; set; }
    }
}
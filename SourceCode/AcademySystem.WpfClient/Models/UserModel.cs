using System.Runtime.Serialization;

namespace AcademySystem.WpfClient.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "password")]
        public string AuthenticationCode { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "humanRole")]
        public string HumanRole { get; set; }

        [DataMember(Name = "humanID")]
        public string HumanID { get; set; }
    }
}
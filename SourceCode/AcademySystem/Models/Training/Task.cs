using System.Runtime.Serialization;
namespace AcademySystem.Models.Training
{
    [DataContract]
    public class Task
    {
         [DataMember(Name = "condition")]
        public string Condition { get; set; }

        [DataMember(Name = "input")]
        public string Input { get; set; }

        [DataMember(Name = "output")]
        public string Output { get; set; }
    }
}

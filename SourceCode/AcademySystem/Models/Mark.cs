
namespace AcademySystem.Models
{using System.Runtime.Serialization;

    [DataContract]
    public struct Mark
    {
         [DataMember(Name = "examPoints")]
        public int ExamPoints { get; set; }

         [DataMember(Name = "examMaxPoints")]
        public int ExamMaxPoints { get; set; }

         [DataMember(Name = "coursePoints")]
        public int CoursePoints { get; set; }

         [DataMember(Name = "courseTextMark")]
        public string CourseTextMark { get; set; }
    }
}
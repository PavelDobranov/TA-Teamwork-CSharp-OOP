
namespace AcademySystem.Models.Training
{
    using AcademySystem.Training;
    using AcademySystem.Interfaces;

    public class PaydCourse : Course , IPayd
    {
        public string Certificate { get;  private set; }
    }
}


namespace AcademySystem.Models.Training.Contracts
{
    public interface IPaydCourse : ICourse
    {
        decimal Price { get; }
    }
}

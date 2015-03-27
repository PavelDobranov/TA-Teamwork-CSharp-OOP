namespace AcademySystem.Interfaces
{
    public interface ITrainer : IHuman
    {
        string Specialty { get; }
        string Webpage { get; }
    }
}

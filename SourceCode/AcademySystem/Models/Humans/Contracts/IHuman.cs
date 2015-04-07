namespace AcademySystem.Models.Humans.Contracts
{
    using AcademySystem.Models.Humans;

    public interface IHuman
    {
        string FirstName { get; }

        string LastName { get; }

        int Age { get; }
        
        Gender Gender { get; }
    }
}

namespace AcademySystem.Models.Humans.Contracts
{
    using System.Collections.Generic;

    public interface ITrainer : IHuman
    {
        ICollection<string> Qualifications { get; }

        string Webpage { get; }

        void AddQualification(string qualification);

        void RemoveQualification(string qualification);
    }
}
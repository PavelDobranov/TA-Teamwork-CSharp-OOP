namespace AcademySystem.Interfaces
{
    using System;

    public interface IUser
    {
        string FirstName { get; }
        string LastName { get; }
        string Username { get; }
        string Email { get; }
    }
}

namespace AcademySystem.Interfaces
{
    using System;
    using System.Collections.Generic;
    using AcademySystem.Models.Training;

    public interface IHomework
    {
        DateTime Deadline { get; }
        ICollection<Task> ListOfTasks { get; }

        void AddTask(Task task);
        void RemoveTask(Task task);
    }
}

namespace AcademySystem.Models
{
    using System;
    using System.Collections.Generic;

    using AcademySystem.Models.Training;
    using System.Runtime.Serialization;

    [DataContract]
    public class Homework
    {
        public Homework(DateTime deadline)
        {
            this.Deadline = deadline;
        }

        [DataMember(Name = "deadline")]
        public DateTime Deadline
        {
            get;
            set;
        }

        [DataMember(Name = "listOfTasks")]
        public ICollection<Task> ListOfTasks
        {
            get;
            private set;
        }

        public void AddTask(Task task)
        {
            this.ListOfTasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.ListOfTasks.Remove(task);
        }
    }
}

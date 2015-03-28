namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;

    public abstract class Training : ITraining
    {
        public Training(string name, string category)
        {
            this.Name = name;
            this.Category = category;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Category
        {
            get;
            private set;
        }
    }
}

namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;

    public abstract class Training : ITraining 
    {

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

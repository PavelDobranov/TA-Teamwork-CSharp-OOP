namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;


    public class Exercise : Training, IExercise 
    {

        public DateTime StartTime
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime EndTime
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.Generic.List<ITrainer> Trainers
        {
            get { throw new NotImplementedException(); }
        }
    }
}

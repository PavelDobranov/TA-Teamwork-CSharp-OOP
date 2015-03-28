namespace AcademySystem.Training
{
    using System;
    using AcademySystem.Interfaces;


    class Lecture : Training, ILecture
    {

        public DateTime StartTime
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime EndTime
        {
            get { throw new NotImplementedException(); }
        }

        public ITrainer Trainer
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Price
        {
            get { throw new NotImplementedException(); }
        }
    }
}

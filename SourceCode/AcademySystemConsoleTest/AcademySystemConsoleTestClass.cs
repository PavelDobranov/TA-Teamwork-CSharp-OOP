namespace AcademySystemConsoleTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using AcademySystem.Humans;
    using AcademySystem.Interfaces;
    using AcademySystem.Models.Training;
    using AcademySystem.Models;

    public class AcademySystemConsoleTestClass
    {
        static void Main(string[] args)
        {
            // created for testing purposes
            Exercise somExercise = new Exercise("ExName", "Programing",
                                   new DateTime(2015, 03, 03, 12, 00, 00),
                                   new DateTime(2015, 03, 03, 16, 00, 00));
            Trainer someTrainer = new Trainer("Pesho","Ninov",29,"Peshkata","asdasdad@asd.bg","Sofiq",
                                                Gender.Male,"Programing","www.fff.bg");
            Lecture someLecture = new Lecture("LectName", "Programing",
                new DateTime(2015, 03, 04, 12, 00, 00),
                new DateTime(2015, 03, 04, 18, 00, 00), someTrainer, new Homework(new DateTime(2015, 04, 04, 18, 00, 00)));

            somExercise.AddTrainer(someTrainer);

            Student someSt = new Student("Goshko", "Gegov", 18, "mamamiq", "email", "Sofeto", Gender.Male, 121211221);
            FreeCourse someCourse = new FreeCourse("C#1", "Programing", new DateTime(2015, 03, 03),
                                   new DateTime(2015, 03, 23), "Description");
            someCourse.AddExercise(somExercise);
            someCourse.AddLecture(someLecture);

            someSt.AddCourse(someCourse);
        }
    }
}

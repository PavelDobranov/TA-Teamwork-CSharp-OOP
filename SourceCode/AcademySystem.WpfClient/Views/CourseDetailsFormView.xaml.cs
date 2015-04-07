using AcademySystem.Models.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademySystem.WpfClient.Views
{
    /// <summary>
    /// Interaction logic for CourseDetailsFormView.xaml
    /// </summary>
    public partial class CourseDetailsFormView : UserControl
    {
        public CourseDetailsFormView()
        {
            InitializeComponent();

            List<TrainingClass> TestCourcesList = new List<TrainingClass>();
            TestCourcesList.Add(new Exercise("Name1", "Cat1", DateTime.Now, DateTime.Now.AddHours(4)));
            TestCourcesList.Add(new Exercise("Name2", "Cat2", DateTime.Now, DateTime.Now.AddHours(4)));
            TestCourcesList.Add(new Exercise("Name3", "Cat3", DateTime.Now, DateTime.Now.AddHours(4)));
            TestCourcesList.Add(new Exercise("Name4", "Cat4", DateTime.Now, DateTime.Now.AddHours(4)));


            TestCourcesList.AddRange(TestCourcesList);
            TrainingClasses.ItemsSource = TestCourcesList;
                       
        }
    }
}

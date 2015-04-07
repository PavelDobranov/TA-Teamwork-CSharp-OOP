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

            //List<Training> TestCourcesList = new List<TrainingCou>();
            //TestCourcesList.Add(new FreeCourse("Name1", "Cat1", DateTime.Now, DateTime.Now.AddDays(1)));
            ////TestCourcesList.Add(new FreeCourse("Name2", "Cat1133", DateTime.Now, DateTime.Now.AddDays(1), "desc"));
            ////TestCourcesList.Add(new FreeCourse("Name3", "Cat23", DateTime.Now, DateTime.Now.AddDays(1), "descdescdescdescdesc"));
            ////TestCourcesList.Add(new FreeCourse("Name4", "Cat123", DateTime.Now, DateTime.Now.AddDays(1), "descdescdescdescdescdescdescdescdescdesc"));


            //TestCourcesList.AddRange(TestCourcesList);
            //TrainingClasses.ItemsSource = TestCourcesList;
                       
        }
    }
}

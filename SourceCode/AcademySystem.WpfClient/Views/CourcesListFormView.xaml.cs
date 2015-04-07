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

using AcademySystem.Models.Training;

namespace AcademySystem.WpfClient.Views
{
    /// <summary>
    /// Interaction logic for CourcesListFormView.xaml
    /// </summary>
    public partial class CourcesListFormView : UserControl
    {
        public CourcesListFormView()
        {
            InitializeComponent();
            List<Training> CourcesList = new List<Training>();

            #region testing
            List<Training> TestCourcesList = new List<Training>();
            TestCourcesList.Add(new FreeCourse("Name1", "Cat1", DateTime.Now, DateTime.Now.AddDays(1), "desc"));
            TestCourcesList.Add(new FreeCourse("Name2", "Cat1133", DateTime.Now, DateTime.Now.AddDays(1), "desc"));
            TestCourcesList.Add(new FreeCourse("Name3", "Cat23", DateTime.Now, DateTime.Now.AddDays(1), "desdescdesc"));
            TestCourcesList.Add(new PaydCourse("Name4", "Cat111123", DateTime.Now, DateTime.Now.AddDays(1), "descdesc",200m));

            CourcesList.AddRange(TestCourcesList);
            #endregion

            Cources.ItemsSource = CourcesList;
        }
    }
}

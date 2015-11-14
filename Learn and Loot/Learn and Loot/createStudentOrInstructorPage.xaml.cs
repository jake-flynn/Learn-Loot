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

namespace Learn_and_Loot
{
    /// <summary>
    /// Interaction logic for createStudentOrInstructorPage.xaml
    /// </summary>
    public partial class createStudentOrInstructorPage : Page
    {
        private Frame mFrame;

        public createStudentOrInstructorPage()
        {
            InitializeComponent();
        }

        public createStudentOrInstructorPage(Frame frame)
        {
            InitializeComponent();
            mFrame = frame;
        }

        private void btn_Student_Click(object sender, RoutedEventArgs e)
        {
            mFrame.Content = new StudentRegistrationPage();
        }

        private void btn_Instructor_Click(object sender, RoutedEventArgs e)
        {
            mFrame.Content = new InstructorRegistration();
        }
    }
}

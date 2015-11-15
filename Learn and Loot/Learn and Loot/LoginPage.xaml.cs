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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Frame mFrame; 
        public LoginPage()
        {
            InitializeComponent();
        }
        public LoginPage(Frame frame)
        {
            InitializeComponent();
            mFrame = frame;
        }

        private void btn_StudentLogin_Click(object sender, RoutedEventArgs e)
        {
            mFrame.Content = new StudentLoginPage(mFrame);
        }

        private void btn_InstructorLogin_Click(object sender, RoutedEventArgs e)
        {
            mFrame.Content = new InstructorLoginPage(mFrame);
        }
    }
}

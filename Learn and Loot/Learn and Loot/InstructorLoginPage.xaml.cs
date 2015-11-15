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
    /// Interaction logic for InstructorLoginPage.xaml
    /// </summary>
    public partial class InstructorLoginPage : Page
    {
        private Frame mFrame; 
        public InstructorLoginPage()
        {
            InitializeComponent();
        }
        public InstructorLoginPage(Frame frame)
        {
            InitializeComponent();
            mFrame = frame;
        }

        private void btn_InstructorLogin_Click(object sender, RoutedEventArgs e)
        {
            bool loginSuccess; 

            string userName = tbx_userName.Text;
            string password = pwd_password.Password;
            
            //InstructorLogin(userName, password);
            loginSuccess = true;

            if (loginSuccess)
            {
                mFrame.Content = new InstructorHomePage();
            }
        }
    }
}

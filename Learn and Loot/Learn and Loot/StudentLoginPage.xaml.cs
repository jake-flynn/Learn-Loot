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
    /// Interaction logic for StudentLoginPage.xaml
    /// </summary>
    /// private Frame mFrame;
    public partial class StudentLoginPage : Page
    {
        private Frame mFrame;
        public StudentLoginPage()
        {
            InitializeComponent();
        }
        public StudentLoginPage(Frame frame)
        {
            InitializeComponent();
            mFrame = frame;
        }

        private void btn_StudentLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = tbx_userName.Text;
            string password = pwd_password.Password;

            //StudentLogin(userName, password);
            
        }
    }
}

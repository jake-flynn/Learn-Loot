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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new GetStartedButtonPage(MainFrame, rec_background);
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Home.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            rec_background.Fill = imgBrush;
            
            
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new GetStartedButtonPage(MainFrame, rec_background);
            
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new LoginPage(MainFrame, rec_background); 
        }





    }
}

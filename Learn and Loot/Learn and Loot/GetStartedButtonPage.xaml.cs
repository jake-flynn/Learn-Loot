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
    /// Interaction logic for GetStartedButtonPage.xaml
    /// </summary>
    public partial class GetStartedButtonPage : Page
    {
        private Frame mFrame;
        private Rectangle rec_background;

        public GetStartedButtonPage()
        {
            InitializeComponent();
        }

        public GetStartedButtonPage(Frame frame, Rectangle rec_background)
        {
            InitializeComponent();
            mFrame = frame;
            ImageBrush imgBrush = new ImageBrush();
            BitmapImage image = new BitmapImage(new Uri(@"../../Images/Home.jpg", UriKind.RelativeOrAbsolute));
            imgBrush.ImageSource = image;
            rec_background.Fill = imgBrush;
            this.rec_background = rec_background;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //mFrame.Content = new TestPage();   
            mFrame.Content = new createStudentOrInstructorPage(mFrame, rec_background);
        }

       
    }
}

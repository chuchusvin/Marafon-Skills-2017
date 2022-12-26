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

namespace marafon_skills
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void richTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_becomeSponsor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("SponsorPage.xaml", UriKind.RelativeOrAbsolute));
        }



        private void Button_about_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

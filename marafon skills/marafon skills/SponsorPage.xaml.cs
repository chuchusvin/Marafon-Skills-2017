using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для SponsorPage.xaml
    /// </summary>
    public partial class SponsorPage : Page, INotifyPropertyChanged
    {
        private int donate = 50;

        public int donation 
        {
            get
            {
                return donate;
            }
            set
            {

            int temp = 0;
            int.TryParse(value.ToString(), out temp);
                donate = value;

                if (temp >= 10)
                {
                    donate = value;
                    PropertyChange("donation");
                }
            }
        }

        public SponsorPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void PropertyChange(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));

        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<RunnerInfo> runnerInfo = new List<RunnerInfo>();
            Util.db.Runner.ToList().ForEach(r => runnerInfo.Add(item: new RunnerInfo() { runner = r }));

            comboBox_runner.ItemsSource = runnerInfo;
            comboBox_runner.DisplayMemberPath = "info";
        }

        private void richTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_donation_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            donation += 10;
            PropertyChange("donation");
        }

        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            if(donation >= 20)
                donation -= 10;
            PropertyChange("donation");
        }
    }
}

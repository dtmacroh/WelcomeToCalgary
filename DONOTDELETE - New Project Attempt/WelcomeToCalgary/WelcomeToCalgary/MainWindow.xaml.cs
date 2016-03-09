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

namespace WelcomeToCalgary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttPoI_Click(object sender, RoutedEventArgs e)
        {
            PlacesOfInterest interest = new PlacesOfInterest();
            MainScroll.Children.Clear();
            MainScroll.Children.Add(interest);
        }

        private void buttCalInfo_Click(object sender, RoutedEventArgs e)
        {
            CalgaryInfo calgaryInfo = new CalgaryInfo();
            MainScroll.Children.Clear();
            MainScroll.Children.Add(calgaryInfo);
        }

        private void buttEvents_Click(object sender, RoutedEventArgs e)
        {
            EventsMain events = new EventsMain(MainScroll);
            MainScroll.Children.Clear();
            MainScroll.Children.Add(events);
        }

        private void buttLinks_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

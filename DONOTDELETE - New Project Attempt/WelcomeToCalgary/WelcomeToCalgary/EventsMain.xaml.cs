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
    /// Interaction logic for EventsMain.xaml
    /// </summary>
    public partial class EventsMain : UserControl
    {

        StackPanel mainScroll;
        public EventsMain(StackPanel scroll)
        {
            InitializeComponent();
            mainScroll = scroll;

        }

        private void ButtArea_Click(object sender, RoutedEventArgs e)
        {
            EventAreaSelect area = new EventAreaSelect(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(area);
        }

        private void ButtSearch_Click(object sender, RoutedEventArgs e)
        {
            EventCultureSelect culture = new EventCultureSelect(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(culture);
        }
    }
}

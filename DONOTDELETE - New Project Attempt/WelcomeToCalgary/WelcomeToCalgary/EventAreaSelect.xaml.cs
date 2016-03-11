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
    /// Interaction logic for AreaSelect.xaml
    /// </summary>
    public partial class EventAreaSelect : UserControl
    {
        StackPanel mainStack;
        public EventAreaSelect(StackPanel stack)
        {

            InitializeComponent(); mainStack = stack;
            scrollb.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void wsprings_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Easter Hunt";
                    Event.Details = "Welcome to the annual egg hunt, open for all ages. There will be a variety of treats hidden in" +
                    "the smallest corners of the field. " + "\n" + "Date & Time: April 5, 2016" + "\n" + "Location: Millow Park";
                }
                else
                {
                    Event.Title = "Petting Zoo";
                    Event.Details = "Come visit the latest petting zoo with your children to let them play with the tame animals" +
                                        "Date & Time: March 30, 2016"+ "\n" + "Location: Marshmellow Centre";
                }

                this.stacklist.Children.Add(Event);
            }

        }

        private void forest_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;

        }

        private void uni_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;

        }
    }
}

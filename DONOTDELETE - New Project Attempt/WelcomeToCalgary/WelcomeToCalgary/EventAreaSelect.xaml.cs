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
            stacklist.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Find the Eastern Eggs";
                    Event.Details = "Welcome to the annual egg hunt, open for all ages. There will be a variety of treats hidden in" +
                    "the smallest corners of the field. " + "\n" + "Date & Time: April 5, 2016 @ 12:30PM" + "\n" + "Location: Millow Park";
                }
                else
                {
                    Event.Title = "Zoolander";
                    Event.Details = "Come visit the latest petting zoo with your children to let them play with the tame animals.\n" +
                                        "Date & Time: March 30, 2016 @ 11AM"+ "\n" + "Location: Marshmellow Centre";
                }

                this.stacklist.Children.Add(Event);
            }

        }

        private void forest_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;
            stacklist.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Car Showoff";
                    Event.Details = "Come show off your car and compete in the annual contest. Special guest judge." +
                     "\n" + "Date & Time: May 1, 2016 @ 10AM" + "\n" + "Location: Lawson Shopping Mall";
                }
                else
                {
                    Event.Title = "Hot Dog Race";
                    Event.Details = "Enter your dog to race with other fellow dogs. Hot dogs offered at lunch.\n" +
                                        "Date & Time: April 30, 2016 @ 12PM" + "\n" + "Location: West Hill";
                }

                this.stacklist.Children.Add(Event);
            }

        }

        private void uni_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;
            stacklist.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Dance Off";
                    Event.Details = "Come compete in the 12HR dance marathon. Bring your partner and your best shoes." +
                     "\n" + "Date & Time: July 25, 2016 @ 9AM" + "\n" + "Location: Market Community Centre";
                }
                else
                {
                    Event.Title = "Roaring Dinos";
                    Event.Details = "Come support the local basketball teams as they compete as they become the very best.\n" +
                                        "Date & Time: July 30, 2016 @ 5PM" + "\n" + "Location: Unison Centre";
                }

                this.stacklist.Children.Add(Event);
            }

        }
    }
}

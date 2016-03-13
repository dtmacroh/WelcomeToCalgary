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
    /// Interaction logic for EventCultureSelect.xaml
    /// </summary>
    public partial class EventCultureSelect : UserControl
    {
        StackPanel mainStack;
        public EventCultureSelect(StackPanel stack)
        {
            InitializeComponent();
            mainStack = stack;
            scroll.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void spain_Selected(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;
            stackpanie.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Fandango";
                    Event.Details = "Attend a lesson with a partner and experience a famous dance of Spain." +
                     "\n" + "Date & Time: March 28, 2016" + "\n" + "Location: Hudson Community Centre, Brentwood";
                }
                else
                {                         
                    Event.Title = "Feast for the Beast";
                    Event.Details = "Feast on the delicious food offered by local food trucks with your tradition spain cuisine.\n" +
                                        "Date & Time:  May 22, 2016 @ 12PM" + "\n" + "Location: 12th Langdon Ave, Downtown";
                }

                this.stackpanie.Children.Add(Event);
            }

        }

        private void france_Selected(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;
            stackpanie.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Walking for the Cure";
                    Event.Details = "Participate in the upcoming marathon to raise money in hopes of curing cancer." +
                    "\n" + "Date & Time: May 6, 2016 @ 9AM" + "\n" + "Location: Easton Park, Temple";
                }
                else
                {
           
                    Event.Title = "Oui Oui Paintnight";
                    Event.Details = "Come drop by for the night and learn how to paint the Eiffel Tower.\n" +
                                        "Date & Time: June 5, 2016 @ 6PM" + "\n" + "Location: Louise Painthall, Kensington";
                }

                this.stackpanie.Children.Add(Event);
            }

        }

        private void japan_Selected(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;
            stackpanie.Children.Clear();
            for (int i = 0; i < 2; i++)
            {
                EventCreator Event = new EventCreator();
                if (i == 0)
                {
                    Event.Title = "Taekwondo Duo";
                    Event.Details = "The local dojo will be performing a beautiful performance with a special appearance by two upraising performers." +
                     "\n" + "Date & Time: February 28, 2016 @ 1PM" + "\n" + "Location: Frazer Park, Brentwood";
                }
                else
                {
                    Event.Title = "Dragon Dance";
                    Event.Details = "Participate in the annual dragon dance and experience the fiery moves. Bonfire and fireworks during the evening.\n " +
                                        "Date & Time: February 20, 2016 @ 4PM" + "\n" + "Location: Dragon City, Downtown";
                }

                this.stackpanie.Children.Add(Event);
            }

        }
    }
}

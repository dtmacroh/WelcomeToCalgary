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
		string oneRegSelect = "";
		
        StackPanel mainScroll;
        public EventsMain(StackPanel scroll)
        {
            InitializeComponent();
            mainScroll = scroll;
            AreaFilterPopup.Visibility = Visibility.Hidden;


        }

        private void filterArea_NE_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			
			 if (oneRegSelect == "NE")
			{
				buttNE_click.Opacity =0;
				oneRegSelect = "";
			}
			else
			{
				buttNE_click.Content = "NE selected";
				clearAreaButtOpac();
				buttNE_click.Opacity=80;
				oneRegSelect= "NE";
			}
			
			// TODO: Add event handler implementation here.
        }

        private void filterArea_SE_click(object sender, System.Windows.RoutedEventArgs e)
        {
			 if (oneRegSelect == "SE")
			{
				buttSE_click.Opacity =0;
				oneRegSelect = "";
			}
			else
			{
				buttSE_click.Content = "SE selected";
				clearAreaButtOpac();
				buttSE_click.Opacity=80;
				oneRegSelect= "SE";
			}
			
        }
		
		public void clearAreaButtOpac()
		{
			buttSE_click.Opacity=0;
			buttNE_click.Opacity=0;
			buttSW_click.Opacity=0;
			buttNW_click.Opacity=0;
		}

		private void filterArea_SW_click(object sender, System.Windows.RoutedEventArgs e)
		{
			 if (oneRegSelect == "SW")
			{
				buttSW_click.Opacity =0;
				oneRegSelect = "";
			}
			else
			{
				buttSW_click.Content = "SW selected";
				clearAreaButtOpac();
				buttSW_click.Opacity=80;
				oneRegSelect = "SW";
			}
			
		}

        private void filterArea_NW_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (oneRegSelect == "NW")
            {
                buttNW_click.Opacity = 0;
                oneRegSelect = "";
            }
            else
            {
                buttNW_click.Content = "NW selected";
                clearAreaButtOpac();
                buttNW_click.Opacity = 80;
                oneRegSelect = "NW";
            }
        }

            private void FilterApplied(object sender, RoutedEventArgs e)
          {
              CultureFilterPopup.Visibility = Visibility.Hidden;
              //CultureFilterPopup.Opacity = 0;
            if (CultureAS.IsSelected) //Asian
            {

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

                    this.EventsHolder.Children.Add(Event);
                }
            }
            else if (CultureEU.IsSelected) //Europe
            {
                CultureFilterPopup.Visibility = Visibility.Hidden;
                EventsBlock.Text = "woof";
            }
            else if (CultureAF.IsSelected) //Africa
            {
                CultureFilterPopup.Visibility = Visibility.Hidden;
                EventsBlock.Text = "moo";
            }
            else if (CultureSA.IsSelected) //South America
            {
                CultureFilterPopup.Visibility = Visibility.Hidden;
                EventsBlock.Text = "oink";
            }

        }
			// TODO: Add event handler implementation here.
		
 	
	
       /* Old code for Horizontal Version of prototype; please ignore
		
		
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
        }*/
    }
}

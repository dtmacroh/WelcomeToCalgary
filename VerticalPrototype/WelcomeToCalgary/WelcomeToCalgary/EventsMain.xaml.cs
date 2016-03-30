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

            private void CultureFilterApplied(object sender, RoutedEventArgs e)
          {
              this.EventsHolder.Children.Clear();

            if (CultureAS.IsSelected) //Asian
            {
                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();
               
                    if (i == 0)
                    {
                        Event.Title = "Dragon Boat Race & Festival";
                        Event.Date = "Date : August 13 & 14, 2016";
                        Event.Details = "The Calgary Dragon Boat Race & Festival is geared towards creating an unforgettable experience. The dragon boat competition illustrates camaraderie, teamwork and inspiration." +
                                           "Stemmed by a 2000-year-old Chinese legend, Dragon Boat Racing is still very active and remains a tradition to this day.";
                        Event.Location = "Location: North Glenmore Park \nAddress: 7305 Crowchild Tr. SW, Calgary, AB";
                        Event.Website = "Website: http://www.chinatowncalgary.com/dragonboat/index.html";
                    }
                    else
                    {
                        Event.Title = "Japanese Festival “Omatsuri”";
                        Event.Date = "Date : August 13, 2016";
                        Event.Details = "Now in its sixth year, the Calgary Japanese Festival “Omatsuri” will once again be held at the Bowness Community Centre. Adults and children of all ages are invited to join us on Saturday, August 13, 2016 from 11:00 am to 6:00 pm to" +
                                          "help us celebrate Japan, its people, and the Japanese Canadian populations of Calgary and around the country." +
                                         " “Omatsuri” is the Japanese term for a “traditional festival”. Visitors to the festival will be treated to authentic Japanese customs, presentations of traditional music, dance & song, martial arts demonstrations, and more! " +
                                         "There will be games and bouncy houses for the kids, galleries of local Japanese arts and crafts as well as several food kiosks featuring traditional Japanese cuisine. Don’t miss out on our fabulous sake tasting as well as our beer gardens! " +
                                         "We hope you will join us on August 13 to support the members of the Japanese Canadian Community as we celebrate our heritage, culture and traditions.";
                        Event.Location = "Location: Bowness Community Centre \nAddress: 7904 - 43rd Avenue NW Calgary, AB T3B 4B9";
                        Event.Website = "Website: http://calgaryjapanesefestival.com";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
            }
            else if (CultureEU.IsSelected) //Europe
            {
                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "Oktoberfest ";
                        Event.Date = "Date : September 23 & Saturday September 24, 2016";
                        Event.Details = "Calgary Oktoberfest is a celebration of local community and, of course, beer! We will be showcasing Oktoberfest brews from Germany and all of Calgary’s amazing craft brewers. " +
                                        "Throughout the night there is live music, including an authentic Oompah band, and great food! Enjoy both traditional and non-traditional fare from some of Calgary’s favourite restaurants. " +
                                        "This is a one-of-a-kind-event, which is quickly turning into Calgary’s newest tradition!This is an 18+ event. Be sure to bring a government issued ID.";
                        Event.Location = "Location: Upper BIG Four Building, Stampede Park \nAddress: 20 Roundup Way, Calgary AB";
                        Event.Website = "Website: http://www.albertabeerfestivals.com/events-services/calgary-oktoberfest/";
                    }
                    else
                    {
                        Event.Title = "The Green Tie Affair";
                        Event.Date = "Date : 12 March, 2016";
                        Event.Details = "It's the annual Green Tie Affair Dinner and Dance: 30th Anniversary edition.  Help celebrate 30 years of the Irish Cultural Society with dinner, music, guest speaker, Irish dance performance, "+
                                         "dancing, and general craic (Irish for fun). Cocktails at 6:30, Dinner at 7; entertainment and dancing afterwards. ";
                        Event.Location = "Location: Irish Cultural Centre, Bunratty Hall  \nAddress: 6452 35 Ave NW, Calgary, AB T3B 1S4";
                        Event.Website = "Website: https://www.eventbrite.ca/e/the-green-tie-affair-tickets-21241100704?aff=ebrowse";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
            }
            else if (CultureAF.IsSelected) //Africa
            {
                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "Afrikadey! Festival";
                        Event.Date = "Date : August 5 to Auguest 8, 2016";
                        Event.Details = "Foremost among these events is is the annual Afrikadey! Festival, a week-long celebration of the music, food, dance, theatre, film," +
                                        "literature and visual arts of Africa and her descendant cultures. These events take place at different venues all over the city with a final day of music on Prince's Island. Price $25-30";
                        Event.Location = "Location: Prince’s Island Park \nAddress: 698 Eau Claire Ave SW, Calgary, AB";
                        Event.Website = "Website: http://www.todocanada.ca/city/calgary/event/afrikadey-festival/";
                    }
                    else
                    {
                        Event.Title = "African Hunting Event ";
                        Event.Date = "Date : January 30 & January 31, 2016";
                        Event.Details = "With over 100,000 registered resident hunters in Alberta, it is clear that hunting runs deep within the outdoor culture of this province. "+
                                        "However many of these passionate sportsmen and women assume that a safari across the Atlantic would be outside of their means, a perception that we are changing by" + 
                                        "showcasing Africa’s and the rest of the world’s affordable hunting destinations." ;
                        Event.Location = "Location: The Coast Plaza Hotel & Conference Centre \nAddress:  1316 33 St NE, Calgary, AB T2A 6B6";
                        Event.Website = "Website: http://www.africanhuntinginfo.com/en/expos/calgary";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
            }
            else if (CultureSA.IsSelected) //South America
            {
                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "Fiestaval";
                        Event.Date = "Date : July 22, 23 and 24, 2016";
                        Event.Details = "Fiestaval is a free and family-oriented, multicultural arts and entertainment festival highlighting the Latin American Culture." +
                                        " It will take place in the heart of downtown Calgary at the Calgary Olympic Plaza on July 22, 23 and 24 2016." +
                                         "It is an opportunity to support Calgary’s Latin community while encouraging multiculturalism among all Calgarians.";
                        Event.Location = "Location: North Glenmore Park \nAddress: 7305 Crowchild Tr. SW, Calgary, AB";
                        Event.Website = "Website: http://www.chinatowncalgary.com/dragonboat/index.html";
                    }
                    else
                    {
                        Event.Title = "Japanese Festival “Omatsuri”";
                        Event.Date = "Date : August 13, 2016";
                        Event.Details = "Now in its sixth year, the Calgary Japanese Festival “Omatsuri” will once again be held at the Bowness Community Centre. Adults and children of all ages are invited to join us on Saturday, August 13, 2016 from 11:00 am to 6:00 pm to" +
                                          "help us celebrate Japan, its people, and the Japanese Canadian populations of Calgary and around the country." +
                                         " “Omatsuri” is the Japanese term for a “traditional festival”. Visitors to the festival will be treated to authentic Japanese customs, presentations of traditional music, dance & song, martial arts demonstrations, and more! " +
                                         "There will be games and bouncy houses for the kids, galleries of local Japanese arts and crafts as well as several food kiosks featuring traditional Japanese cuisine. Don’t miss out on our fabulous sake tasting as well as our beer gardens! " +
                                         "We hope you will join us on August 13 to support the members of the Japanese Canadian Community as we celebrate our heritage, culture and traditions.";
                        Event.Location = "Location: Bowness Community Centre \nAddress: 7904 - 43rd Avenue NW Calgary, AB T3B 4B9";
                        Event.Website = "Website: http://calgaryjapanesefestival.com";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
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

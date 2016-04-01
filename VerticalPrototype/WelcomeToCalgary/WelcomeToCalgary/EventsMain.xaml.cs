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
			createUpcomings();
			AreaApplyFilter.IsEnabled = false;
         
        }

        private void filterArea_NE_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			
			 if (oneRegSelect == "NE")
			{
				buttNE_click.Opacity =0;
				oneRegSelect = "";
				AreaApplyFilter.IsEnabled = false;
			}
			else
			{
				buttNE_click.Content = "NE selected";
				clearAreaButtOpac();
				buttNE_click.Opacity=80;
				oneRegSelect= "NE";
				AreaApplyFilter.IsEnabled = true;
			}
			
			// TODO: Add event handler implementation here.
        }

        private void filterArea_SE_click(object sender, System.Windows.RoutedEventArgs e)
        {
			 if (oneRegSelect == "SE")
			{
				buttSE_click.Opacity =0;
				oneRegSelect = "";
				AreaApplyFilter.IsEnabled = false;
			}
			else
			{
				buttSE_click.Content = "SE selected";
				clearAreaButtOpac();
				buttSE_click.Opacity=80;
				oneRegSelect= "SE";
				AreaApplyFilter.IsEnabled = true;
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
				AreaApplyFilter.IsEnabled = false;
			}
			else
			{
				clearAreaButtOpac();
				buttSW_click.Opacity=80;
				oneRegSelect = "SW";
				AreaApplyFilter.IsEnabled = true;
			}
			
		}

        private void filterArea_NW_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (oneRegSelect == "NW")
            {
                buttNW_click.Opacity = 0;
                oneRegSelect = "";
				AreaApplyFilter.IsEnabled = false;
            }
            else
            {
                buttNW_click.Content = "NW selected";
                clearAreaButtOpac();
                buttNW_click.Opacity = 80;
                oneRegSelect = "NW";
				AreaApplyFilter.IsEnabled = true;
            }
        }

            private void CultureFilterApplied(object sender, RoutedEventArgs e)
          {
			this.FreeEvents.IsChecked=false;
            this.EventsHolder.Children.Clear();
			this.ScrollEvents.ScrollToTop();

            if (CultureAS.IsSelected) //Asian
            {
                this.UpcomingBlock.Text = "ASIAN EVENTS";
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
                    this.UpcomingBlock.Text = "EUROPEAN EVENTS";
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "The Green Tie Affair";
                        Event.Date = "Date : 12 March, 2016";
                        Event.Details = "It's the annual Green Tie Affair Dinner and Dance: 30th Anniversary edition.  Help celebrate 30 years of the Irish Cultural Society with dinner, music, guest speaker, Irish dance performance, " +
                                         "dancing, and general craic (Irish for fun). Cocktails at 6:30, Dinner at 7; entertainment and dancing afterwards. ";
                        Event.Location = "Location: Irish Cultural Centre, Bunratty Hall  \nAddress: 6452 35 Ave NW, Calgary, AB T3B 1S4";
                        Event.Website = "Website: https://www.eventbrite.ca/e/the-green-tie-affair-tickets-21241100704?aff=ebrowse";
                    }
                    else
                    {
                        Event.Title = "Oktoberfest ";
                        Event.Date = "Date : September 23 & September 24, 2016";
                        Event.Details = "Calgary Oktoberfest is a celebration of local community and, of course, beer! We will be showcasing Oktoberfest brews from Germany and all of Calgary’s amazing craft brewers. " +
                                        "Throughout the night there is live music, including an authentic Oompah band, and great food! Enjoy both traditional and non-traditional fare from some of Calgary’s favourite restaurants. " +
                                        "This is a one-of-a-kind-event, which is quickly turning into Calgary’s newest tradition! This is an   18+ event. Be sure to bring a government issued ID.";
                        Event.Location = "Location: Upper BIG Four Building, Stampede Park \nAddress: 20 Roundup Way, Calgary AB";
                        Event.Website = "Website: http://www.albertabeerfestivals.com/events-services/calgary-oktoberfest/";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
            }
            else if (CultureAF.IsSelected) //Africa
            {
                this.UpcomingBlock.Text = "AFRICAN EVENTS";

                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "Afrikadey! Festival";
                        Event.Date = "Date : August 5 to Auguest 8, 2016";
                        Event.Details = "Foremost among these events is is the annual Afrikadey! Festival, a week-long celebration of the music, food, dance, theatre, film," +
                                        " literature and visual arts of Africa and her descendant cultures. These events take place at different venues all over the city with a final day of music on Prince's Island. Price $25-30";
                        Event.Location = "Location: Prince’s Island Park \nAddress: 698 Eau Claire Ave SW, Calgary, AB";
                        Event.Website = "Website: http://www.todocanada.ca/city/calgary/event/afrikadey-festival/";
                    }
                    else
                    {
                        Event.Title = "African Hunting Event ";
                        Event.Date = "Date : January 30 & January 31, 2017";
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
                this.UpcomingBlock.Text = "SOUTH AMERICAN EVENTS";

                for (int i = 0; i < 2; i++)
                {
                    EventCreator Event = new EventCreator();

                    if (i == 0)
                    {
                        Event.Title = "Fiestaval";
                        Event.Date = "Date : July 22, 23 and 24, 2016";
                        Event.Details = "Fiestaval is a free and family-oriented, multicultural arts and entertainment festival highlighting the Latin American Culture." +
                                        " It will take place in the heart of downtown Calgary at the Calgary Olympic Plaza on July 22, 23 and 24 2016." +
                                         " It is an opportunity to support Calgary’s Latin community while encouraging multiculturalism among all Calgarians.";
                        Event.Location = "Location: Calgary Olympic Plaza \nAddress: 228 8 Ave SE, Calgary, AB T2P 2M5";
                        Event.Website = "Website: http://fiestaval.ca/calgary/";
                    }
                    else
                    {
                        Event.Title = "Brazilian Heat";
                        Event.Date = "Date : August 22, 2016";
                        Event.Details = "This family-friendly event is a celebration of Brazilian culture. Spend the evening watching local and international artists performing"+
                                        " Brazilian music and dance, such as capoeira. This is sure to be a high-energy, colourful evening. ";
                        Event.Location = "Location: Hillhurst Sunnyside Community Centre  \nAddress: 1320 5 Ave. N.W. Calgary , AB";
                        Event.Website = "Website: http://www.brazilian-heat.com/";
                    }

                    this.EventsHolder.Children.Add(Event);
                }
            }

        }

            private void AgeFilterApplied(object sender, RoutedEventArgs e)
            {
				this.FreeEvents.IsChecked=false;
                this.EventsHolder.Children.Clear();
				this.ScrollEvents.ScrollToTop();

                if (AgeKid.IsSelected)
                {
                    this.UpcomingBlock.Text = "EVENTS FOR KIDS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {                        
                            Event.Title = "Crafting / Story time";
                            Event.Date = "Date : April 27, 2016";
                            Event.Details = "Amazearts kids art studio hosts a free craft and storytime for kids aged 3-5 years old every Wednesday morning 10-10.45am. " +
                                            "It’s a fun way to spend a cold winter morning! Space is limited. Register Online";
                            Event.Location = "Location: Amazearts Studios  \nAddress: #207, 11625 Elbow Drive SW Calgary, AB T2W 1G8";
                            Event.Website = "Website: http://www.amazearts.com/";
                        }
                        else
                        {
                            Event.Title = "Race for Kids";
                            Event.Date = "Date : May 28, 2016";
                            Event.Details = "Part scavenger hunt. Part adventure race. 100% fun! Join in the fun on Saturday, May 28, 2016 for the fifth annual Capital" +
                                            " One Race for Kids in support of Boys and Girls Clubs of Calgary! Teams of four adults compete in a series of 10 checkpoint challenges " +
                                             "in a race to the finish line. Challenges are not based on athletic prowess or mental superiority; rather, they are designed for having a blast! " +
                                            "A post-race celebration including food, prizes and entertainment will be held at the finish line. Grown-ups play. Kids win.";
                            Event.Location = "Location: Boys And Girls Clubs Of Calgary \nAddress: 731 13 Ave NE, Calgary, AB T2E";
                            Event.Website = "Website: http://www.raceforkids.ca/calgary";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }
                else if (AgeYA.IsSelected)
                {
                    this.UpcomingBlock.Text = "EVENTS FOR YOUNG ADULTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Mix and Mingle at Hudson's";
                            Event.Date = "Date : March 25, 2016";
                            Event.Details = "Please come to Hudson's Taphouse on 5th Street for a night of socializing, dancing and good times. I will reserve a table under Young Adults " +
                                            "once I know the general number of people that will be attending. I would love to see the people who joined us for the pub crawl again at this event, if they can make it. Cheers";
                            Event.Location = "Location: Hudson's Canadian Taphouse \nAddress: 601 12 Ave SW, Calgary, AB T2R 1H1";
                            Event.Website = "Website: http://www.meetup.com/Young-Adults/events/229599743/s";
                        }
                        else
                        {
                            Event.Title = "Karaoke at the Bootleggers Sports Bar";
                            Event.Date = "Date : June 9, 2016";
                            Event.Details = "Karaoke starts at 9 ish. It is by far my favorite Karaoke place. The place itself is really nice and the Karaoke playlist includes songs from the albums released in 2015. " +
                                            "I suggest to meetup at 9-9:30pm. There is no obligation to sing but I really encourage everyone to get on the mic and sing. I personally love country music but this crowd " +
                                            "includes pretty much every style. Feel free to bring up guests.";
                            Event.Location = "Location: Bootleggers Sports Bar  \nAddress: 3444 32 Ave NE, Calgary, AB T1Y 6G8";
                            Event.Website = "Website: http://www.meetup.com/Young-Adults/events/227808090/";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }
                else if (AgeAdult.IsSelected)
                {
                    this.UpcomingBlock.Text = "EVENTS FOR ADULTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Zoogala";
                            Event.Date = "Date : April 25, 2016";
                            Event.Details = "The Calgary Zoo's annual fundraising event is a great excuse to party. This adult-only fiesta features a live band and dancing, performances, interactive entertainment, food, wine and " +
                                            "cocktail sampling, and a unique silent auction. Dress to the theme and win prizes!";
                            Event.Location = "Location: Calgary Zoo \nAddress: 1300 Zoo Road Calgary  AB  T2M 4R8";
                            Event.Website = "Website: http://www.calgaryzoo.com/";
                        }
                        else
                        {
                            Event.Title = "Blended!";
                            Event.Date = "Date : May 28, 2016";
                            Event.Details = "Blended spirits and classic wine blends - a delicious and magical combination that has created some of the finest liquids in the world. " +
                                            "Learn why blends have captured our hearts here at VR Wine. We'll be pouring our best blends! " +
                                             "As always, this is a complimentary wine tasting. Feel free to drop by anytime from 1pm - 4pm. Cheers!";
                            Event.Location = "Location: VR Wine  \nAddress: 8561 8A Avenue Southwest, Calgary, AB T3H 0V5";
                            Event.Website = "Website: http://www.vrwine.com";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }
                else if (AgeSenior.IsSelected)
                {
                    this.UpcomingBlock.Text = "EVENTS FOR SENIORS";

                    for (int i = 0; i < 2; i++)
                    {

                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Saturday Dances";
                            Event.Date = "Date : March 2 & March 4, 2016";
                            Event.Details = "Come out to the Centre on the 2nd & 4th Saturday of the month and dance the night away. $12 includes a light snack with a cash bar. " +
                                            "Doors open at 6:30pm and Dance starts at 7:30.";
                            Event.Location = "Location: Confederation Park 55+ Activity Centre \nAddress: 2212 13 Street NW, Calgary, Alberta T2M 4P7";
                            Event.Website = "Website: http://confedpark55plus.ca/blog/saturday-dances-in-march";
                        }
                        else
                        {
                            Event.Title = "Wine & Cheese";
                            Event.Date = "Date : April 2, 2016";
                            Event.Details = "Enjoy a variety of wines, beers, cheeses and games. Door prizes will be drawn at the end of the evening. We hope to see you there!";
                            Event.Location = "Location: Banff Trail Community Association  \nAddress: 2115 20 AVE, Calgary, AB";
                            Event.Website = "Website: http://banfftrailcommunity.ca/";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }


            }

            private void AreaFilterApplied(object sender, RoutedEventArgs e)
            {
                this.EventsHolder.Children.Clear();
				this.FreeEvents.IsChecked = false;
				this.ScrollEvents.ScrollToTop();

                if (oneRegSelect == "NE")
                {
                    this.UpcomingBlock.Text = "CALGARY NORTHEAST EVENTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Morning Spiritual Sumba";
                            Event.Date = "Date : February 18, 2016";
                            Event.Details = "Get your Spiritual Warrior Groove going on for the day. What a way to get a positive vibration and set an intention. Dance as gentle or as wild as you wish to " +
                                            "beautiful new age music. Class ends with a meditation. Only $13 online or $15 drop-in cash, correct change only";
                            Event.Location = "Location: Bridgeland Riverside Community \nAddress: 917 Centre Ave NE, Calgary, Alberta T2E 0C6";
                            Event.Website = "Website: https://www.facebook.com/events/178202145871880/";
                        }
                        else
                        {
                            Event.Title = "Supertrain";
                            Event.Date = "Date : April 16 & April 17, 2016";
                            Event.Details = "Calgary Model Railway Society presents Canada's Biggest and Best annual Model Train Show. Over 70,000 sq ft of operating model railroad layouts, displays, " +
                                            "hobby shops, model manufacturers, railroad art, photos, clinics and live demos for beginners, ride-on trains, Garden railroads, Lionel, Lego, Thomas, Children's Play Area, and much more. " +
                                            "Free Parking or take the CTrain to SUPERTRAIN (Saddletowne Station). adult - $10. youth (6-12) - $5. under 6 - free." +
                                            " Bring a non-perishable food donation for the Calgary Food Bank and receive a dollar off admission";
                            Event.Location = "Location: Genesis centre  \nAddress: 7555 Falconridge Blvd NE, Calgary, Alberta  T3J 0C9 ";
                            Event.Website = "Website: http://www.supertrain.ca/";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }
                else if (oneRegSelect == "NW")
                {
                    this.UpcomingBlock.Text = "CALGARY NORTHWEST EVENTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "CCAG Spring Art Show and Sale";
                            Event.Date = "Date :  April 9, 2016";
                            Event.Details = "The Calgary Creative Arts Guild is hosting our Annual Spring Show & Sale on April 9, 2016 at the Montgomery Community Centre, 5003 16 Ave NW from 10am to 4pm. " +
                                                "Featuring original works from over 20 local artists, the event will provide refreshments, door prizes and a raffle draw for an original framed watercolour painting." +
                                                " Admission is free. Donations to the Veteran's Food Bank gratefully accepted.";
                            Event.Location = "Location: Montgomery Community Centre \nAddress: 5003 16 Ave NW Calgary, AB T3B 0N2";
                            Event.Website = "Website: http://www.chatterblock.com/events/215795/ccag-spring-art-show-and-sale/";
                        }
                        else
                        {
                            Event.Title = "The Fibre Shindig";
                            Event.Date = "Date : April 16 , 2016";
                            Event.Details = "All things Fibre! Hand dyed, artisan made - yarn, knitting, embroidery, crochet, felting, spinning, fibre, tools, pottery, ceramics, fine art, jewellery, hand designed and sewn items. " + 
                                            "Come and meet Alberta's best fibre artists and artisans. ";
                            Event.Location = "Location: Hillhurst Sunnyside Community Centre  \nAddress: 1320 5 Ave. N.W. Calgary , AB";
                            Event.Website = "Website: https://www.fibreshindig.com/";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }

                }
                else if (oneRegSelect == "SE")
                {
                    this.UpcomingBlock.Text = "CALGARY SOUTHEAST EVENTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Bearspaw Spring Art & Craft Sale and Market";
                            Event.Date = "Date : April 30 to May 1 , 2016";
                            Event.Details = "Local artists, photographers, woodworkers, soap makers, jewellers, painters, ceramic artists, knitters, crafters as well as local small businesses come together for the first annual Spring Art Sale and Market! ";
                            Event.Location = "Location: B & P Cycle & Sports \nAddress: 1717-52st SE Calgary, AB T2A 1V1";
                            Event.Website = "Website: https://www.facebook.com/events/1674840002770147/";
                        }
                        else
                        {
                            Event.Title = "Walk to Fight Arthritis";
                            Event.Date = "Date : June 5 , 2016";
                            Event.Details = "The Walk to Fight Arthritis is the signature event of the Arthritis Society. It is a 1km or 5km fun-filled family event that unites "+
                                            "communities in supporting the nearly 4.5 million Canadians living with Arthritis. The annual Walk will take place in 23 communities across Canada. "+
                                            "The money raised throughout the Walk helps fun research, advocacy and solutions to improve the quality of life for those living with arthritis and their families."+
                                            " To register as a participant or as a volunteer go online. ";
                            Event.Location = "Location: Fish Creek Provincial Park  \nAddress: 15979 Bow Bottom Trail SE, Calgary, AB T2P 0Y8";
                            Event.Website = "Website: http://walktofightarthritis.ca/";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }

                }
                else if (oneRegSelect == "SW")
                {
                    this.UpcomingBlock.Text = "CALGARY SOUTHWEST EVENTS";

                    for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                            Event.Title = "Square Dancing & Lessons";
                            Event.Date = "Date :  March 1 to April 18, 2016";
                            Event.Details = "Square dancing every Monday @ 8-10 PM (except Dec. 21 & 28) beginning Sep. 21 at Sunalta Community Hall, 1627-10th Ave. SW. $5 per dancer. " +
                                            "Three free lessons for new dancers from 7:00 to 8:30 PM Mondays Sep. 21, 28 & Oct. 5; same location. No experience or partner required.";
                            Event.Location = "Location: Calgary Olympic Plaza \nAddress: 228 8 Ave SE, Calgary, AB T2P 2M5";
                            Event.Website = "Website: http://www.chatterblock.com/events/198604/square-dancing-lessons/";
                        }
                        else
                        {
                            Event.Title = "Jayman BUILT MS Walk";
                            Event.Date = "Date : Jun 12, 2016";
                            Event.Details = "Join thousands of Calgarians for the 25th Annual Jayman BUILT MS Walk as we walk together to end MS. The Jayman BUILT MS Walk is more than a Walk, " +
                                            "it’s a movement to end MS, and we need your help! Walk with us and 2000 of your closest friends on June 12, 2016 at Prince’s Island Park. Help us find a cure." +
                                            " Help us bring hope to those living with MS. Every step matters.";
                            Event.Location = "Location: Prince's Island Park  \nAddress: 698 Eau Claire Ave SW, Calgary, AB";
                            Event.Website = "Website: http://mssoc.convio.net/site/TR?fr_id=4943&pg=entry";
                        }

                        this.EventsHolder.Children.Add(Event);
                    }
                }
            }

            private void FreeFilterApplied(object sender, System.Windows.RoutedEventArgs e)
            {
				this.EventsHolder.Children.Clear();
				this.ScrollEvents.ScrollToTop();
                this.UpcomingBlock.Text = "FREE ATTENDANCE EVENTS";

            	for (int i = 0; i < 2; i++)
                    {
                        EventCreator Event = new EventCreator();

                        if (i == 0)
                        {
                              Event.Title = "Walk to Fight Arthritis";
                            Event.Date = "Date : June 5 , 2016";
                            Event.Details = "The Walk to Fight Arthritis is the signature event of the Arthritis Society. It is a 1km or 5km fun-filled family event that unites "+
                                            "communities in supporting the nearly 4.5 million Canadians living with Arthritis. The annual Walk will take place in 23 communities across Canada. "+
                                            "The money raised throughout the Walk helps fun research, advocacy and solutions to improve the quality of life for those living with arthritis and their families."+
                                            " To register as a participant or as a volunteer go online. ";
                            Event.Location = "Location: Fish Creek Provincial Park  \nAddress: 15979 Bow Bottom Trail SE, Calgary, AB T2P 0Y8";
                            Event.Website = "Website: http://walktofightarthritis.ca/";
							
                        }
                        else
                        {
                            Event.Title = "Jayman BUILT MS Walk";
                            Event.Date = "Date : Jun 12, 2016";
                            Event.Details = "Join thousands of Calgarians for the 25th Annual Jayman BUILT MS Walk as we walk together to end MS. The Jayman BUILT MS Walk is more than a Walk, " +
                                            "it’s a movement to end MS, and we need your help! Walk with us and 2000 of your closest friends on June 12, 2016 at Prince’s Island Park. Help us find a cure." +
                                            " Help us bring hope to those living with MS. Every step matters.";
                            Event.Location = "Location: Prince's Island Park  \nAddress: 698 Eau Claire Ave SW, Calgary, AB";
                            Event.Website = "Website: http://mssoc.convio.net/site/TR?fr_id=4943&pg=entry";
                        }

                        this.EventsHolder.Children.Add(Event);
					
                    }
					
            }

            private void FreeUnchecked(object sender, System.Windows.RoutedEventArgs e)
            {
				this.EventsHolder.Children.Clear();
				this.ScrollEvents.ScrollToTop();
            	createUpcomings();
                this.UpcomingBlock.Text = "UPCOMING EVENTS";

            }
			
			private void createUpcomings()
			{
				this.EventsHolder.Children.Clear();
				this.ScrollEvents.ScrollToTop();
                this.UpcomingBlock.Text = "UPCOMING EVENTS";
				 for (int i = 0; i < 6; i++)
            {
                EventCreator Event = new EventCreator();

                if (i == 0)
                {
                     
                     Event.Title = "Square Dancing & Lessons";
                     Event.Date = "Date :  March 1 to April 18, 2016";
                     Event.Details = "Square dancing every Monday @ 8-10 PM (except Dec. 21 & 28) beginning Sep. 21 at Sunalta Community Hall, 1627-10th Ave. SW. $5 per dancer. " +
                                     "Three free lessons for new dancers from 7:00 to 8:30 PM Mondays Sep. 21, 28 & Oct. 5; same location. No experience or partner required.";
                     Event.Location = "Location: Calgary Olympic Plaza \nAddress: 228 8 Ave SE, Calgary, AB T2P 2M5";
                     Event.Website = "Website: http://www.chatterblock.com/events/198604/square-dancing-lessons/";
                }
                else if(i == 1)
                {
                    Event.Title = "Wine & Cheese";
                    Event.Date = "Date : April 2, 2016";
                    Event.Details = "Enjoy a variety of wines, beers, cheeses and games. Door prizes will be drawn at the end of the evening. We hope to see you there!";
                    Event.Location = "Location: Banff Trail Community Association  \nAddress: 2115 20 AVE, Calgary, AB";
                    Event.Website = "Website: http://banfftrailcommunity.ca/";
                }
                else if (i == 2)
                {
                    Event.Title = "CCAG Spring Art Show and Sale";
                    Event.Date = "Date :  April 9, 2016";
                    Event.Details = "The Calgary Creative Arts Guild is hosting our Annual Spring Show & Sale on April 9, 2016 at the Montgomery Community Centre, 5003 16 Ave NW from 10am to 4pm. " +
                                                "Featuring original works from over 20 local artists, the event will provide refreshments, door prizes and a raffle draw for an original framed watercolour painting." +
                                                " Admission is free. Donations to the Veteran's Food Bank gratefully accepted.";
                    Event.Location = "Location: Montgomery Community Centre \nAddress: 5003 16 Ave NW Calgary, AB T3B 0N2";
                    Event.Website = "Website: http://www.chatterblock.com/events/215795/ccag-spring-art-show-and-sale/";
                }
                else if (i == 3)
                {
                    Event.Title = "Supertrain";
                    Event.Date = "Date : April 16 & April 17, 2016";
                    Event.Details = "Calgary Model Railway Society presents Canada's Biggest and Best annual Model Train Show. Over 70,000 sq ft of operating model railroad layouts, displays, " +
                                    "hobby shops, model manufacturers, railroad art, photos, clinics and live demos for beginners, ride-on trains, Garden railroads, Lionel, Lego, Thomas, Children's Play Area, and much more. " +
                                    "Free Parking or take the CTrain to SUPERTRAIN (Saddletowne Station). adult - $10. youth (6-12) - $5. under 6 - free." +
                                    " Bring a non-perishable food donation for the Calgary Food Bank and receive a dollar off admission";
                    Event.Location = "Location: Genesis centre  \nAddress: 7555 Falconridge Blvd NE, Calgary, Alberta  T3J 0C9 ";
                }
                else if (i == 4)
                {
                    Event.Title = "The Fibre Shindig";
                    Event.Date = "Date : April 16 , 2016";
                    Event.Details = "All things Fibre! Hand dyed, artisan made - yarn, knitting, embroidery, crochet, felting, spinning, fibre, tools, pottery, ceramics, fine art, jewellery, hand designed and sewn items. " +
                                     "Come and meet Alberta's best fibre artists and artisans. ";
                    Event.Location = "Location: Hillhurst Sunnyside Community Centre  \nAddress: 1320 5 Ave. N.W. Calgary , AB";
                    Event.Website = "Website: https://www.fibreshindig.com/";
                }
                else if (i == 5)
                {
                    
                    Event.Title = "Zoogala";
                    Event.Date = "Date : April 25, 2016";
                    Event.Details = "The Calgary Zoo's annual fundraising event is a great excuse to party. This adult-only fiesta features a live band and dancing, performances, interactive entertainment, food, wine and " +
                                           "cocktail sampling, and a unique silent auction. Dress to the theme and win prizes!";
                    Event.Location = "Location: Calgary Zoo \nAddress: 1300 Zoo Road Calgary  AB  T2M 4R8";
                    Event.Website = "Website: http://www.calgaryzoo.com/";
                }
                else if (i == 6)
                {
                    Event.Title = "Crafting / Story time";
                    Event.Date = "Date : April 27, 2016";
                    Event.Details = "Amazearts kids art studio hosts a free craft and storytime for kids aged 3-5 years old every Wednesday morning 10-10.45am. " +
                                    "It’s a fun way to spend a cold winter morning! Space is limited. Register Online";
                    Event.Location = "Location: Amazearts Studios  \nAddress: #207, 11625 Elbow Drive SW Calgary, AB T2W 1G8";
                    Event.Website = "Website: http://www.amazearts.com/";
                }
                   
            

                this.EventsHolder.Children.Add(Event);
            }
				
			}
			
    }
}

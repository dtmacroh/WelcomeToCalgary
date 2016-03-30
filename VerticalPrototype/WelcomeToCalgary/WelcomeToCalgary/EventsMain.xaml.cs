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
				buttNW_click.Opacity =0;
				oneRegSelect = "";
			}
			else
			{
				buttNW_click.Content = "NW selected";
				clearAreaButtOpac();
				buttNW_click.Opacity=80;
				oneRegSelect = "NW";
			}
			// TODO: Add event handler implementation here.
		}
 	
	
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

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
    /// Interaction logic for PlacesOfInterest.xaml
    /// </summary>
    public partial class PlacesOfInterest : UserControl
    {
        Panel frameX;
        public PlacesOfInterest()
        {
            InitializeComponent();
        }
        private void buttPoITrending_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoITrending newPage = new PoITrending();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoIRestaurants_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoIRestaurant newPage = new PoIRestaurant();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoIRecreational_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoIRecreation newPage = new PoIRecreation();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoINature_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoINature newPage = new PoINature();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoISports_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoISports newPage = new PoISports();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoIArts_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoIArts newPage = new PoIArts();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }

        private void buttPoIReligion_Click(object sender, RoutedEventArgs e)
        {
            frameX = (this.Parent as Panel);
            PoIReligion newPage = new PoIReligion();
            frameX.Children.Clear();
            frameX.Children.Add(newPage);
        }
    }
}

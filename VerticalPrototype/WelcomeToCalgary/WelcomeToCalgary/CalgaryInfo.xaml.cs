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
    /// Interaction logic for CalgaryInfo.xaml
    /// </summary>
    public partial class CalgaryInfo : UserControl
    {
        StackPanel mainScroll;
        public CalgaryInfo(StackPanel scroll)
        {
            InitializeComponent();
            mainScroll = scroll;
        }
        public void ButtHistory_Click(object sender, RoutedEventArgs e)
        {
            CIHistory area = new CIHistory(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(area);
        }
        public void ButtCulture_Click(object sender, RoutedEventArgs e)
        {
            CICulture area = new CICulture(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(area);
        }
        public void ButtSports_Click(object sender, RoutedEventArgs e)
        {
            CISports area = new CISports(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(area);
        }
        public void ButtTop10_Click(object sender, RoutedEventArgs e)
        {
            CITop10 area = new CITop10(mainScroll);
            mainScroll.Children.Clear();
            mainScroll.Children.Add(area);
        }
    }
}

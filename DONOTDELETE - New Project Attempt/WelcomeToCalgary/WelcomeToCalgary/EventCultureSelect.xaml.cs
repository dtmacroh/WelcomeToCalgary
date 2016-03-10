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

        }

        private void france_Selected(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;

        }

        private void japan_Selected(object sender, RoutedEventArgs e)
        {
            scroll.Visibility = Visibility.Visible;

        }
    }
}

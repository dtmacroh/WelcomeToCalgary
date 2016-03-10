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
    /// Interaction logic for UsefulLinks.xaml
    /// </summary>
    public partial class UsefulLinks : UserControl
    {
        private StackPanel MainScroll;

        public UsefulLinks()
        {
            InitializeComponent();
        }

        public UsefulLinks(StackPanel scroll)
        {
            // TODO: Complete member initialization
            MainScroll = scroll;
        }
    }
}

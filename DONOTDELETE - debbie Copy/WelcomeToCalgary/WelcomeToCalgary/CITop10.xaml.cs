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
    /// Interaction logic for CITop10.xaml
    /// </summary>
    public partial class CITop10 : UserControl
    {
        StackPanel mainScroll;
        public CITop10(StackPanel scroll)
        {
            InitializeComponent();
            mainScroll = scroll;
        }
    }
}

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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Email thispage1 = new Email();
        Page2 thispage2 = new Page2();
        Page3 thispage3 = new Page3();
        public MainWindow()
        {
            InitializeComponent();

            StackPanel1.Children.Add(thispage1);

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Children.Clear();
            StackPanel1.Children.Add(thispage1);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Children.Clear();
            StackPanel1.Children.Add(thispage2);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Children.Clear();
            StackPanel1.Children.Add(thispage3);
        }
    }
}

﻿using System;
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
    /// Interaction logic for AreaSelect.xaml
    /// </summary>
    public partial class EventAreaSelect : UserControl
    {
        StackPanel mainStack;
        public EventAreaSelect(StackPanel stack)
        {

            InitializeComponent(); mainStack = stack;
            scrollb.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void wsprings_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;

        }

        private void forest_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;

        }

        private void uni_Selected(object sender, RoutedEventArgs e)
        {
            scrollb.Visibility = Visibility.Visible;

        }
    }
}

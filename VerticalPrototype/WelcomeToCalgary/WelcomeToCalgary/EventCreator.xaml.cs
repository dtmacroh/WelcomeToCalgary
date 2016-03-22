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
    /// Interaction logic for EventCreator.xaml
    /// </summary>
    public partial class EventCreator : UserControl
    {
        public string title;
        public string Title
        {
            get { return title; }
            set 
            {
                title = value;
                this.EventTitle.Text = this.title; 
            
            }
        }

        public string details;
        public string Details
        {
            get { return details; }
            set
            {
                details = value;
                this.EventsDetails.Text = this.details;
            }
        }

        public EventCreator()
        {
            InitializeComponent();
        }

       
    }
}

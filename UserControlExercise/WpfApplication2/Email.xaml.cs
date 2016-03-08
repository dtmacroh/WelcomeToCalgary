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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : UserControl
    {
        private string sender;
        public string Sender
        {
            get { return sender; }
            set {
                  sender = value;
                  this.SenderText.Content = this.sender;
                }
        }

        private string body;
        public string Body
        { 
            get { return body; }
            set { body = value;
                  this.MessageText.Content = this.body; }
        }

        public Email()
        {
            InitializeComponent();
        }

        private void CloseEmail(object sender, MouseButtonEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}

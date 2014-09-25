using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestSilverlightApp.ServiceReference1;

namespace TestSilverlightApp
{
    public partial class Home : Page
    {
        public Home()
        {
            MessageServiceClient client = new MessageServiceClient();
            InitializeComponent();
            client.ListCompleted += client_ListCompleted;
            client.ListAsync();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        void client_ListCompleted(object sender, ListCompletedEventArgs e)
        {
            dgMessage.ItemsSource = e.Result;
        }
    }
}
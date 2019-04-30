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
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RallyLK.Controllers
{
    public partial class ViewSelectedRally : PhoneApplicationPage
    {
        public ViewSelectedRally()
        {
            InitializeComponent();
            name.Text = (App.Current as App).detail[0];
            Date.Text = (App.Current as App).detail[1];
            Time.Text = (App.Current as App).detail[2] + "  Minutes";
            Distance.Text = (App.Current as App).detail[3] + "  Kilometers";
        }

        private void sectors_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Do you prefer map for pointing sectors?", "Add Sectors", MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.OK)
            {
                MessageBox.Show("This Feature will be coming as Premium Version");
            }
            else 
            {
                NavigationService.Navigate(new Uri("/Controllers/ManualSectors.xaml", UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Do you prefer map for pointing checkpoints?", "Add Checkpoints", MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.OK)
            {
                MessageBox.Show("This Feature will be coming as Premium Version");
            }
            else
            {
                NavigationService.Navigate(new Uri("/Controllers/ManualCheckpoints.xaml", UriKind.Relative));
            }
        }

        private void summary_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Controllers/Summary.xaml", UriKind.Relative));
        }
    }
}
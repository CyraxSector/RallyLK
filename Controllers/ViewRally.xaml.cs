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
    public partial class ViewRally : PhoneApplicationPage
    {
        public ViewRally()
        {
            InitializeComponent();
            listbox.ItemsSource = (App.Current as App).decs; 
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            string[] rallydetails = new string[] { (App.Current as App).decs[listbox.SelectedIndex].Name, (App.Current as App).decs[listbox.SelectedIndex].Date.ToLongDateString(), (App.Current as App).decs[listbox.SelectedIndex].Duration.ToString(), (App.Current as App).decs[listbox.SelectedIndex].Distance.ToString() };
            (App.Current as App).detail = rallydetails;
            NavigationService.Navigate(new Uri("/Controllers/ViewSelectedRally.xaml", UriKind.Relative));
        }
    }
}
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
    public partial class ManualSectors : PhoneApplicationPage
    {
        public ManualSectors()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            var textbox = new TextBox()

            {
                Width = 440,
                Text = "Sector",
                FontFamily = new FontFamily("Century Gothic"),
                TextAlignment = TextAlignment.Center,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.Blue),
                IsReadOnly = true,                               
            };

            list.Items.Add(textbox); 
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to save the Sectors?", "RallyLK", MessageBoxButton.OKCancel);
        }
    }
}
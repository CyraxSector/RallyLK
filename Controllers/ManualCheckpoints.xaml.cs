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
    public partial class ManualCheckpoints : PhoneApplicationPage
    {
        public ManualCheckpoints()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            var textbox = new TextBox()

            {
                Width = 440,
                Text = "CheckPoint",
                FontFamily = new FontFamily("Century Gothic"),
                TextAlignment = TextAlignment.Center,
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.Blue),
                IsReadOnly = true,
            };

            list.Items.Add(textbox); 
        }
    }
}
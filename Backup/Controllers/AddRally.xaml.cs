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
using System.ComponentModel;
using RallyLK.Model;
using System.Collections.ObjectModel;

namespace RallyLK.Controllers
{
    public partial class AddRally : PhoneApplicationPage, INotifyPropertyChanged 
    {
        public AddRally()
        {
            InitializeComponent();
            rallyDB = new RallyDataContext(RallyDataContext.DBConnectionString);
            this.DataContext = this; 
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        private RallyDataContext rallyDB; 
        private ObservableCollection<Rallys> rallyItems;
        public ObservableCollection<Rallys> RallyItems 
        {
            get
            {
                return rallyItems;
            }
            set
            {
                if (rallyItems != value)
                {
                    rallyItems = value;
                    NotifyPropertyChanged("RallyItems");
                }
            }
        }         

        private void Add_Click(object sender, EventArgs e)
        {
            Rallys rallyToAdd = new Rallys
            {
                Name = name.Text,
                Date = this.date.Value.Value,
                Duration = Int32.Parse(duration.Text),
                Distance = Int32.Parse(distance.Text),                
            };
            
            rallyDB.rallys.InsertOnSubmit(rallyToAdd);
            rallyDB.SubmitChanges();

            var rallys = from r in rallyDB.rallys select r;
            RallyItems = new ObservableCollection<Rallys>(rallys);
            List<Rallys> myList = new List<Rallys>(rallys);
            (App.Current as App).decs = myList;
        }
    }
}
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace RallyLK.Model
{
    [Table]
    public class Rallys : INotifyPropertyChanged 
    {
        private string name;
        [Column]
        public string Name 
        {
            get 
            {
                return name;
            }
            set 
            {
                NotifyPropertyChanged("Name");
                name = value;
            }
        }

        private DateTime date;
        [Column]
        public DateTime Date 
        {
            get 
            {
                return date;
            }
            set 
            {
                NotifyPropertyChanged("Date");
                date = value;
            }
        }

        private int id;
        [Column(IsPrimaryKey = true,
            CanBeNull = false,
            IsDbGenerated = true,
            DbType = "INT NOT NULL Identity",
            AutoSync = AutoSync.OnInsert)]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                NotifyPropertyChanged("Id");
                id = value;
            }
        }

        private int duration;
        [Column]
        public int Duration 
        {
            get 
            {
                return duration;
            }
            set 
            {
                NotifyPropertyChanged("Duration");
                duration = value;
            }
        }

        private int distance;
        [Column]
        public int Distance 
        {
            get 
            {
                return distance;
            }
            set 
            {
                NotifyPropertyChanged("Distance");
                distance = value;
            }
        }
               
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }        
    }
}

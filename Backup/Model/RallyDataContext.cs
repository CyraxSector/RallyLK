﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Data.Linq;

namespace RallyLK.Model
{
    public class RallyDataContext : DataContext
    {
        public static string DBConnectionString = "Data Source=isostore:/Rallys.sdf";
          public RallyDataContext(string connectionString)
                : base(connectionString)
           {
           }   
              public Table<Rallys> rallys; 
    }
}

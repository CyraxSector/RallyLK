﻿#pragma checksum "H:\Windows phone\BeeHex_Technologies\RallyLK\Controllers\ViewSelectedRally.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94B2BAECFEC11E1D460909DA8246252E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RallyLK.Controllers {
    
    
    public partial class ViewSelectedRally : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock name;
        
        internal System.Windows.Controls.TextBlock Date;
        
        internal System.Windows.Controls.TextBlock Time;
        
        internal System.Windows.Controls.TextBlock Distance;
        
        internal System.Windows.Controls.Button sectors;
        
        internal System.Windows.Controls.Button summary;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RallyLK;component/Controllers/ViewSelectedRally.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.name = ((System.Windows.Controls.TextBlock)(this.FindName("name")));
            this.Date = ((System.Windows.Controls.TextBlock)(this.FindName("Date")));
            this.Time = ((System.Windows.Controls.TextBlock)(this.FindName("Time")));
            this.Distance = ((System.Windows.Controls.TextBlock)(this.FindName("Distance")));
            this.sectors = ((System.Windows.Controls.Button)(this.FindName("sectors")));
            this.summary = ((System.Windows.Controls.Button)(this.FindName("summary")));
        }
    }
}


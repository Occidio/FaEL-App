﻿#pragma checksum "C:\Users\Bamford\Documents\Alex's\Dropbox\FaEL App\FaEL\FaEL\MapPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1983A9ACBD6486BA5DF0A7DE203A48C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
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


namespace FaEL {
    
    
    public partial class MapPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBlock statusTextBlock;
        
        internal System.Windows.Controls.Button trackMe;
        
        internal Microsoft.Phone.Controls.Maps.Map myMap;
        
        internal System.Windows.Controls.Button updateButton;
        
        internal System.Windows.Controls.Button helpBut;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FaEL;component/MapPage.xaml", System.UriKind.Relative));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.statusTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("statusTextBlock")));
            this.trackMe = ((System.Windows.Controls.Button)(this.FindName("trackMe")));
            this.myMap = ((Microsoft.Phone.Controls.Maps.Map)(this.FindName("myMap")));
            this.updateButton = ((System.Windows.Controls.Button)(this.FindName("updateButton")));
            this.helpBut = ((System.Windows.Controls.Button)(this.FindName("helpBut")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
        }
    }
}


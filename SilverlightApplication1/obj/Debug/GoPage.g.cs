﻿#pragma checksum "C:\Users\Patrick\Documents\Visual Studio 2010\Projects\TimePractice\SilverlightApplication1\GoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0F0A521F9D3616863FEB31548056DD41"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SilverlightApplication1 {
    
    
    public partial class GoPage : System.Windows.Controls.Page {
        
        internal System.Windows.Media.Animation.Storyboard Storyboard1;
        
        internal System.Windows.Media.Animation.Storyboard Storyboard2;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle timerTarget;
        
        internal System.Windows.Controls.TextBlock textBlockSD;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.TextBlock textBlockQuestion;
        
        internal System.Windows.Controls.TextBlock textBlockAnswer;
        
        internal System.Windows.Controls.TextBlock textBlockInfo;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightApplication1;component/GoPage.xaml", System.UriKind.Relative));
            this.Storyboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard1")));
            this.Storyboard2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Storyboard2")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.timerTarget = ((System.Windows.Shapes.Rectangle)(this.FindName("timerTarget")));
            this.textBlockSD = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockSD")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.textBlockQuestion = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockQuestion")));
            this.textBlockAnswer = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockAnswer")));
            this.textBlockInfo = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockInfo")));
        }
    }
}


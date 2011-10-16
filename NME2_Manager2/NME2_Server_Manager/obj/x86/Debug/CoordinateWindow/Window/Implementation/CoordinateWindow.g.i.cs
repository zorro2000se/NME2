﻿#pragma checksum "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "58F5D7CA1E65FAE411B1D780F5093820"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.1
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GMap.NET.WindowsPresentation;
using NME2_Server_Manager.Converter;
using NME2_Server_Manager.Dto;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NME2_Server_Manager.CoordinateWindow.Window.Implementation {
    
    
    /// <summary>
    /// CoordinateWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CoordinateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GMap.NET.WindowsPresentation.GMapControl map;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ZoomSlider;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLat;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLon;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccept;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgProjection;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackCoordinateProjection;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHeading;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDistance;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/NME2_Server_Manager;component/coordinatewindow/window/implementation/coordinatew" +
                    "indow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.map = ((GMap.NET.WindowsPresentation.GMapControl)(target));
            return;
            case 2:
            this.ZoomSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 46 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
            this.ZoomSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ZoomSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtLat = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
            this.txtLat.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtLatTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtLon = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
            this.txtLon.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtLonTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAccept = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\..\CoordinateWindow\Window\Implementation\CoordinateWindow.xaml"
            this.btnAccept.Click += new System.Windows.RoutedEventHandler(this.btnAccept_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgProjection = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.stackCoordinateProjection = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.txtHeading = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtDistance = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


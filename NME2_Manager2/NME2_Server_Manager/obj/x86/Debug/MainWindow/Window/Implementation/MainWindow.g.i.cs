﻿#pragma checksum "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CA66FCAC8B1E9B17017FCBB7423C6CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.1
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NME2_Server_Manager.Converter;
using NME2_Server_Manager.Nme2Ws;
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


namespace NME2_Server_Manager.MainWindow.Window.Implementation {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 217 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMission;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveMission;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefreshAll;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstMissions;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveMission;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMissionObject;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveMissionObject;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextBox;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox centerLatTextBox;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowMapMissionLat;
        
        #line default
        #line hidden
        
        
        #line 355 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox centerLonTextBox;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowMapMissionLon;
        
        #line default
        #line hidden
        
        
        #line 386 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rangeTextBox;
        
        #line default
        #line hidden
        
        
        #line 403 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox activeTextBox;
        
        #line default
        #line hidden
        
        
        #line 418 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid missionObjectDataGrid;
        
        #line default
        #line hidden
        
        
        #line 422 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn activeColumn1;
        
        #line default
        #line hidden
        
        
        #line 426 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn headingColumn;
        
        #line default
        #line hidden
        
        
        #line 430 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn latColumn;
        
        #line default
        #line hidden
        
        
        #line 434 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn lonColumn;
        
        #line default
        #line hidden
        
        
        #line 438 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn name;
        
        #line default
        #line hidden
        
        
        #line 470 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSimObjects;
        
        #line default
        #line hidden
        
        
        #line 484 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox objectActiveTextBox;
        
        #line default
        #line hidden
        
        
        #line 499 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox latTextBox;
        
        #line default
        #line hidden
        
        
        #line 503 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowMapObjectLat;
        
        #line default
        #line hidden
        
        
        #line 528 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lonTextBox;
        
        #line default
        #line hidden
        
        
        #line 532 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowMapObjectLon;
        
        #line default
        #line hidden
        
        
        #line 557 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox headingTextBox;
        
        #line default
        #line hidden
        
        
        #line 572 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox altitudeTextBox;
        
        #line default
        #line hidden
        
        
        #line 587 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox onGroundTextBox;
        
        #line default
        #line hidden
        
        
        #line 602 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pitchTextBox;
        
        #line default
        #line hidden
        
        
        #line 617 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bankTextBox;
        
        #line default
        #line hidden
        
        
        #line 632 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yawTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/NME2_Server_Manager;component/mainwindow/window/implementation/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
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
            
            #line 12 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            ((NME2_Server_Manager.MainWindow.Window.Implementation.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAddMission = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnAddMission.Click += new System.Windows.RoutedEventHandler(this.BtnNewMissionClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRemoveMission = ((System.Windows.Controls.Button)(target));
            
            #line 225 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnRemoveMission.Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnRefreshAll = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnRefreshAll.Click += new System.Windows.RoutedEventHandler(this.btnRefreshAll_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstMissions = ((System.Windows.Controls.ListBox)(target));
            
            #line 255 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.lstMissions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSaveMission = ((System.Windows.Controls.Button)(target));
            
            #line 275 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnSaveMission.Click += new System.Windows.RoutedEventHandler(this.ButtonClick3);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAddMissionObject = ((System.Windows.Controls.Button)(target));
            
            #line 280 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnAddMissionObject.Click += new System.Windows.RoutedEventHandler(this.BtnAddMissionObjectClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnRemoveMissionObject = ((System.Windows.Controls.Button)(target));
            
            #line 284 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnRemoveMissionObject.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteMissionObjectClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.nameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.centerLatTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.btnShowMapMissionLat = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnShowMapMissionLat.Click += new System.Windows.RoutedEventHandler(this.btnShowMapMission_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.centerLonTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.btnShowMapMissionLon = ((System.Windows.Controls.Button)(target));
            
            #line 361 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnShowMapMissionLon.Click += new System.Windows.RoutedEventHandler(this.btnShowMapMission_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.rangeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.activeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.missionObjectDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 420 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.missionObjectDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MissionObjectDataGridSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 21:
            this.activeColumn1 = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 22:
            this.headingColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 23:
            this.latColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 24:
            this.lonColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 25:
            this.name = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 26:
            this.cmbSimObjects = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 27:
            this.objectActiveTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.latTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.btnShowMapObjectLat = ((System.Windows.Controls.Button)(target));
            
            #line 505 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnShowMapObjectLat.Click += new System.Windows.RoutedEventHandler(this.BtnShowMapObjectClick);
            
            #line default
            #line hidden
            return;
            case 30:
            this.lonTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.btnShowMapObjectLon = ((System.Windows.Controls.Button)(target));
            
            #line 534 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            this.btnShowMapObjectLon.Click += new System.Windows.RoutedEventHandler(this.BtnShowMapObjectClick);
            
            #line default
            #line hidden
            return;
            case 32:
            this.headingTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 33:
            this.altitudeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 34:
            this.onGroundTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.pitchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 36:
            this.bankTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 37:
            this.yawTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 65 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShowMap_Click);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 129 "..\..\..\..\..\..\MainWindow\Window\Implementation\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnShowMap_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


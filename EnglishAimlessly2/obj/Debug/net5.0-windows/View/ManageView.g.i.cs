﻿#pragma checksum "..\..\..\..\View\ManageView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9878C6923E3723C6D5FB39BC89688102316BD6E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EnglishAimlessly2.UserControls;
using EnglishAimlessly2.View;
using EnglishAimlessly2.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EnglishAimlessly2.View {
    
    
    /// <summary>
    /// ManageView
    /// </summary>
    public partial class ManageView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTogether;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWordName;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstView;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderMain;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGroupSettings;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderDetails;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\View\ManageView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EnglishAimlessly2;V0.5.0.0;component/view/manageview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ManageView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\View\ManageView.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAddTogether = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\View\ManageView.xaml"
            this.btnAddTogether.Click += new System.Windows.RoutedEventHandler(this.btnAddTogether_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\View\ManageView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtWordName = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\..\View\ManageView.xaml"
            this.txtWordName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtWordName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.borderMain = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.btnGroupSettings = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\..\View\ManageView.xaml"
            this.btnGroupSettings.Click += new System.Windows.RoutedEventHandler(this.btnGroupSettings_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.borderDetails = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\..\..\View\ManageView.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


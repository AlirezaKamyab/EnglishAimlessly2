﻿#pragma checksum "..\..\..\..\View\MainMenuView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD29EFB223985EC6DD29AF75F53DC017F4701B07"
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
    /// MainMenuView
    /// </summary>
    public partial class MainMenuView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGroupName;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstView;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderMain;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPractice;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnManager;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\View\MainMenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGroupSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/EnglishAimlessly2;V0.1.0.0;component/view/mainmenuview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainMenuView.xaml"
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
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\MainMenuView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\View\MainMenuView.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtGroupName = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\..\View\MainMenuView.xaml"
            this.txtGroupName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtGroupName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstView = ((System.Windows.Controls.ListView)(target));
            
            #line 106 "..\..\..\..\View\MainMenuView.xaml"
            this.lstView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.borderMain = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.btnPractice = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\..\..\View\MainMenuView.xaml"
            this.btnPractice.Click += new System.Windows.RoutedEventHandler(this.btnPractice_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnManager = ((System.Windows.Controls.Button)(target));
            
            #line 208 "..\..\..\..\View\MainMenuView.xaml"
            this.btnManager.Click += new System.Windows.RoutedEventHandler(this.btnManager_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnGroupSettings = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\..\..\View\MainMenuView.xaml"
            this.btnGroupSettings.Click += new System.Windows.RoutedEventHandler(this.btnGroupSettings_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


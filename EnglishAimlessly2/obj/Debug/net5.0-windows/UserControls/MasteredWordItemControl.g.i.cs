#pragma checksum "..\..\..\..\UserControls\MasteredWordItemControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB1CF9F1A7497222312B58391DA3EDBDB6F8356F"
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
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace EnglishAimlessly2.UserControls {
    
    
    /// <summary>
    /// MasteredWordItemControl
    /// </summary>
    public partial class MasteredWordItemControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnControl;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run txtName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run txtType;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run txtPoints;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EnglishAimlessly2;V1.0.1.0;component/usercontrols/masteredworditemcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnControl = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\UserControls\MasteredWordItemControl.xaml"
            this.btnControl.Click += new System.Windows.RoutedEventHandler(this.btnControl_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.progress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 4:
            this.txtName = ((System.Windows.Documents.Run)(target));
            return;
            case 5:
            this.txtType = ((System.Windows.Documents.Run)(target));
            return;
            case 6:
            this.txtPoints = ((System.Windows.Documents.Run)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


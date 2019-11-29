﻿#pragma checksum "..\..\PersonView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F1D42F684ACA32B78143E04DFB0AAF1F0479506972A997724B95B48FBC95BE75"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ReportView;
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


namespace ReportView {
    
    
    /// <summary>
    /// PersonView
    /// </summary>
    public partial class PersonView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border backgroundBorder;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock departmentTextBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lastNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border nextBorder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ReportView;component/personview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\PersonView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Grid_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\PersonView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Grid_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backgroundBorder = ((System.Windows.Controls.Border)(target));
            
            #line 17 "..\..\PersonView.xaml"
            this.backgroundBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backgroundBorder_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.departmentTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 19 "..\..\PersonView.xaml"
            this.departmentTextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backgroundBorder_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lastNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 21 "..\..\PersonView.xaml"
            this.lastNameTextBlock.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backgroundBorder_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nextBorder = ((System.Windows.Controls.Border)(target));
            
            #line 25 "..\..\PersonView.xaml"
            this.nextBorder.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            
            #line 25 "..\..\PersonView.xaml"
            this.nextBorder.MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave);
            
            #line default
            #line hidden
            
            #line 25 "..\..\PersonView.xaml"
            this.nextBorder.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.nextBorder_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 25 "..\..\PersonView.xaml"
            this.nextBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backgroundBorder_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


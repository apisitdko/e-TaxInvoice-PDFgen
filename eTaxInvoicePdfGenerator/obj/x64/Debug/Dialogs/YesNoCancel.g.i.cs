﻿#pragma checksum "..\..\..\..\Dialogs\YesNoCancel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1897B1894A16B40712A9540AF67A0D42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using eTaxInvoicePdfGenerator.Dialogs;


namespace eTaxInvoicePdfGenerator.Dialogs {
    
    
    /// <summary>
    /// YesNoCancel
    /// </summary>
    public partial class YesNoCancel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Dialogs\YesNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock msgLb;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Dialogs\YesNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button yesBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Dialogs\YesNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button noBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Dialogs\YesNoCancel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/eTaxInvoicePdfGenerator;component/dialogs/yesnocancel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\YesNoCancel.xaml"
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
            
            #line 8 "..\..\..\..\Dialogs\YesNoCancel.xaml"
            ((eTaxInvoicePdfGenerator.Dialogs.YesNoCancel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.msgLb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.yesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Dialogs\YesNoCancel.xaml"
            this.yesBtn.Click += new System.Windows.RoutedEventHandler(this.yesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.noBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Dialogs\YesNoCancel.xaml"
            this.noBtn.Click += new System.Windows.RoutedEventHandler(this.noBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Dialogs\YesNoCancel.xaml"
            this.cancelBtn.Click += new System.Windows.RoutedEventHandler(this.cancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


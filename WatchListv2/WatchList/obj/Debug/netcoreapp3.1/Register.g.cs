﻿#pragma checksum "..\..\..\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298A9ED269C530A0EFA26BD813052797E0898B95"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using WatchList;


namespace WatchList {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Registo_username;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Registo_password;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Registo_password_show;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPass;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Registo_email;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.14.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WatchList;component/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.14.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 48 "..\..\..\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Registo_username = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\..\Register.xaml"
            this.Registo_username.GotFocus += new System.Windows.RoutedEventHandler(this.Empty_Username);
            
            #line default
            #line hidden
            
            #line 81 "..\..\..\Register.xaml"
            this.Registo_username.LostFocus += new System.Windows.RoutedEventHandler(this.Fill_Username);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Registo_password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 109 "..\..\..\Register.xaml"
            this.Registo_password.GotFocus += new System.Windows.RoutedEventHandler(this.Empty_Password);
            
            #line default
            #line hidden
            
            #line 110 "..\..\..\Register.xaml"
            this.Registo_password.LostFocus += new System.Windows.RoutedEventHandler(this.Fill_Password);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Registo_password_show = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnPass = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\Register.xaml"
            this.btnPass.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDown);
            
            #line default
            #line hidden
            
            #line 137 "..\..\..\Register.xaml"
            this.btnPass.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Registo_email = ((System.Windows.Controls.TextBox)(target));
            
            #line 167 "..\..\..\Register.xaml"
            this.Registo_email.GotFocus += new System.Windows.RoutedEventHandler(this.Empty_Email);
            
            #line default
            #line hidden
            
            #line 168 "..\..\..\Register.xaml"
            this.Registo_email.LostFocus += new System.Windows.RoutedEventHandler(this.Fill_Email);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 183 "..\..\..\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 184 "..\..\..\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\RandomPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A56CEC1A83F1BBC46715EFF0000A1C1986FA2B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SafeCenter;
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


namespace SafeCenter {
    
    
    /// <summary>
    /// RandomPassword
    /// </summary>
    public partial class RandomPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost DialogHost;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menuBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Count;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordGenerate;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Copy3;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox lowercase;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox uppercase;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox numbers;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox specialChars;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button generate;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\RandomPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock result;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SafeCenter;component/randompassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RandomPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\RandomPassword.xaml"
            ((SafeCenter.RandomPassword)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 3:
            this.menuBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\RandomPassword.xaml"
            this.menuBtn.Click += new System.Windows.RoutedEventHandler(this.menuOpen);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_exit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\RandomPassword.xaml"
            this.btn_exit.Click += new System.Windows.RoutedEventHandler(this.exitApp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Count = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\RandomPassword.xaml"
            this.Count.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Count_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\RandomPassword.xaml"
            this.Count.GotFocus += new System.Windows.RoutedEventHandler(this.Count_GotFocus);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\RandomPassword.xaml"
            this.Count.LostFocus += new System.Windows.RoutedEventHandler(this.Count_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordGenerate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Copy3 = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\RandomPassword.xaml"
            this.Copy3.Click += new System.Windows.RoutedEventHandler(this.copyMessage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lowercase = ((System.Windows.Controls.CheckBox)(target));
            
            #line 56 "..\..\..\RandomPassword.xaml"
            this.lowercase.Checked += new System.Windows.RoutedEventHandler(this.lowercase_Checked);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\RandomPassword.xaml"
            this.lowercase.Unchecked += new System.Windows.RoutedEventHandler(this.lowercase_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.uppercase = ((System.Windows.Controls.CheckBox)(target));
            
            #line 57 "..\..\..\RandomPassword.xaml"
            this.uppercase.Checked += new System.Windows.RoutedEventHandler(this.uppercase_Checked);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\RandomPassword.xaml"
            this.uppercase.Unchecked += new System.Windows.RoutedEventHandler(this.uppercase_Unchecked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.numbers = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\..\RandomPassword.xaml"
            this.numbers.Checked += new System.Windows.RoutedEventHandler(this.numbers_Checked);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\RandomPassword.xaml"
            this.numbers.Unchecked += new System.Windows.RoutedEventHandler(this.numbers_Unchecked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.specialChars = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\..\RandomPassword.xaml"
            this.specialChars.Checked += new System.Windows.RoutedEventHandler(this.specialChars_Checked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\RandomPassword.xaml"
            this.specialChars.Unchecked += new System.Windows.RoutedEventHandler(this.specialChars_Unchecked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.generate = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\RandomPassword.xaml"
            this.generate.Click += new System.Windows.RoutedEventHandler(this.generate_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.result = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


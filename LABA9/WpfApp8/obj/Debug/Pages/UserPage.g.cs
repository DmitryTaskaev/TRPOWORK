﻿#pragma checksum "..\..\..\Pages\UserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2C3071AFA846FA512F94BEF6E1BD7699FC9EE1CF9E54D5A2F29DBB97798ABBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp8.Pages;


namespace WpfApp8.Pages {
    
    
    /// <summary>
    /// UserPage
    /// </summary>
    public partial class UserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StatusTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker LastLoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeProperties;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckProperties;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveProperties;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp8;component/pages/userpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UserPage.xaml"
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
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\Pages\UserPage.xaml"
            this.NameTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StatusTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\Pages\UserPage.xaml"
            this.StatusTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Status_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LastLoginTextBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.ChangeProperties = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\UserPage.xaml"
            this.ChangeProperties.Click += new System.Windows.RoutedEventHandler(this.ChangePropertiesButton);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CheckProperties = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Pages\UserPage.xaml"
            this.CheckProperties.Click += new System.Windows.RoutedEventHandler(this.CheckPropertiesButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SaveProperties = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\UserPage.xaml"
            this.SaveProperties.Click += new System.Windows.RoutedEventHandler(this.SavePropertiesButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


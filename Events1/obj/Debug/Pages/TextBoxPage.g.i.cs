﻿#pragma checksum "..\..\..\Pages\TextBoxPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A1EA318A71CB36B0627C9528E90FA96031ED5F2538410A294FE135CD3716621"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Events1.Pages;
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


namespace Events1.Pages {
    
    
    /// <summary>
    /// TextBoxPage
    /// </summary>
    public partial class TextBoxPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Pages\TextBoxPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventsTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\TextBoxPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowPropertiesCheckBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\TextBoxPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OutputTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Events1;component/pages/textboxpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TextBoxPage.xaml"
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
            this.EventsTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Pages\TextBoxPage.xaml"
            this.EventsTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.EventsTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Pages\TextBoxPage.xaml"
            this.EventsTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.EventsTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Pages\TextBoxPage.xaml"
            this.EventsTextBox.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.EventsTextBox_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowPropertiesCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.OutputTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

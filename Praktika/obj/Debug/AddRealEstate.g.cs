﻿#pragma checksum "..\..\AddRealEstate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9B7DC824355C968BA9A699A4AD72D10F3DEC434F3626E6DEF18FE621E47F100"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Praktika;
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


namespace Praktika {
    
    
    /// <summary>
    /// AddRealEstate
    /// </summary>
    public partial class AddRealEstate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 119 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_CityTextBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_StreetTextBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_HouseTextBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_NumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DistrictComboBox;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\AddRealEstate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Praktika;component/addrealestate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddRealEstate.xaml"
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
            this.Address_CityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Address_StreetTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Address_HouseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Address_NumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DistrictComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 131 "..\..\AddRealEstate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

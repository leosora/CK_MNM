﻿#pragma checksum "..\..\..\GiaoDien\ViTriWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4519C056F18135E6D7F3F83221176B7B805A5415817566B01FB584B842E7326"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyThuVien.GiaoDien;
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


namespace QuanLyThuVien.GiaoDien {
    
    
    /// <summary>
    /// ViTriWindow
    /// </summary>
    public partial class ViTriWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmavitri;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttenke;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbmakhu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoThem;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoSua;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoXoa;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnthuchien;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\GiaoDien\ViTriWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgViTri;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyThuVien;component/giaodien/vitriwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GiaoDien\ViTriWindow.xaml"
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
            
            #line 8 "..\..\..\GiaoDien\ViTriWindow.xaml"
            ((QuanLyThuVien.GiaoDien.ViTriWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtmavitri = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txttenke = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbmakhu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.rdoThem = ((System.Windows.Controls.RadioButton)(target));
            
            #line 40 "..\..\..\GiaoDien\ViTriWindow.xaml"
            this.rdoThem.Click += new System.Windows.RoutedEventHandler(this.RdoThem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rdoSua = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\GiaoDien\ViTriWindow.xaml"
            this.rdoSua.Click += new System.Windows.RoutedEventHandler(this.RdoSua_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdoXoa = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\..\GiaoDien\ViTriWindow.xaml"
            this.rdoXoa.Click += new System.Windows.RoutedEventHandler(this.RdoXoa_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnthuchien = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\GiaoDien\ViTriWindow.xaml"
            this.btnthuchien.Click += new System.Windows.RoutedEventHandler(this.Btnthuchien_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgViTri = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\GiaoDien\ViTriWindow.xaml"
            this.dgViTri.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgViTri_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


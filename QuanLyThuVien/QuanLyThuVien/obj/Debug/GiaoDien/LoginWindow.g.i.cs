// Updated by XamlIntelliSenseFileGenerator 12/27/2021 9:01:36 AM
#pragma checksum "..\..\..\GiaoDien\LoginWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "476963197229E447E294C7C51EBC9B579D12E45357F9ED45287B188DF92B771C"
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


namespace QuanLyThuVien.GiaoDien
{


    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttaikhoan;

#line default
#line hidden


#line 20 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;

#line default
#line hidden


#line 25 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ckbthuthu;

#line default
#line hidden


#line 27 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ckbdocgia;

#line default
#line hidden


#line 31 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btndangnhap;

#line default
#line hidden


#line 34 "..\..\..\GiaoDien\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btntrolai;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyThuVien;component/giaodien/loginwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\GiaoDien\LoginWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 10 "..\..\..\GiaoDien\LoginWindow.xaml"
                    ((QuanLyThuVien.GiaoDien.LoginWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.txttaikhoan = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.txtID = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.ckbthuthu = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 5:
                    this.ckbdocgia = ((System.Windows.Controls.RadioButton)(target));
                    return;
                case 6:
                    this.btndangnhap = ((System.Windows.Controls.Button)(target));

#line 31 "..\..\..\GiaoDien\LoginWindow.xaml"
                    this.btndangnhap.Click += new System.Windows.RoutedEventHandler(this.Btndangnhap_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.btntrolai = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\..\GiaoDien\LoginWindow.xaml"
                    this.btntrolai.Click += new System.Windows.RoutedEventHandler(this.Btntrolai_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.PasswordBox txtmatkhau;
    }
}


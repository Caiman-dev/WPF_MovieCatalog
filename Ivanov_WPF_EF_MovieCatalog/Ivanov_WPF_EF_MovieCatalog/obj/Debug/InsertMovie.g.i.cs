﻿#pragma checksum "..\..\InsertMovie.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD3239FEDA31B7C3CC3D53D9E5CE27D1607F78D4877162DDFE3B7937311FB906"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ivanov_WPF_EF_MovieCatalog;
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


namespace Ivanov_WPF_EF_MovieCatalog {
    
    
    /// <summary>
    /// InsertMovie
    /// </summary>
    public partial class InsertMovie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Ivanov_WPF_EF_MovieCatalog.InsertMovie AddMovieWindow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTB;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearTB;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox budgetTB;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryTB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTB;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertB;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelB;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\InsertMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image movieImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Ivanov_WPF_EF_MovieCatalog;component/insertmovie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsertMovie.xaml"
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
            this.AddMovieWindow = ((Ivanov_WPF_EF_MovieCatalog.InsertMovie)(target));
            return;
            case 2:
            
            #line 11 "..\..\InsertMovie.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.titleTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\InsertMovie.xaml"
            this.titleTB.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.titleTB_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.yearTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\InsertMovie.xaml"
            this.yearTB.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.yearTB_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.budgetTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\InsertMovie.xaml"
            this.budgetTB.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.budgetTB_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.countryTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\InsertMovie.xaml"
            this.countryTB.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.countryTB_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.descriptionTB = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\InsertMovie.xaml"
            this.descriptionTB.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.descriptionTB_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.insertB = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\InsertMovie.xaml"
            this.insertB.Click += new System.Windows.RoutedEventHandler(this.insertB_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.clearB = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\InsertMovie.xaml"
            this.clearB.Click += new System.Windows.RoutedEventHandler(this.clearB_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cancelB = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\InsertMovie.xaml"
            this.cancelB.Click += new System.Windows.RoutedEventHandler(this.cancelB_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.movieImage = ((System.Windows.Controls.Image)(target));
            
            #line 93 "..\..\InsertMovie.xaml"
            this.movieImage.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.movieImage_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


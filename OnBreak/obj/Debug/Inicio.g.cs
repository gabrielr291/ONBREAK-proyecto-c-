﻿#pragma checksum "..\..\Inicio.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F01A93EDBB4EC1C6EDF921C74CC87F42D8AFAC0F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls;
using OnBreak;
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
using System.Windows.Interactivity;
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


namespace OnBreak {
    
    
    /// <summary>
    /// Inicio
    /// </summary>
    public partial class Inicio : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarCl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListarCl;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox1;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarCon;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Inicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnListarCon;
        
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
            System.Uri resourceLocater = new System.Uri("/OnBreak;component/inicio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Inicio.xaml"
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
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.btnAgregarCl = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Inicio.xaml"
            this.btnAgregarCl.Click += new System.Windows.RoutedEventHandler(this.btnAgregarCl_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnListarCl = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Inicio.xaml"
            this.btnListarCl.Click += new System.Windows.RoutedEventHandler(this.btnListarCl_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.groupBox1 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.btnAgregarCon = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Inicio.xaml"
            this.btnAgregarCon.Click += new System.Windows.RoutedEventHandler(this.btnAgregarCon_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnListarCon = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Inicio.xaml"
            this.btnListarCon.Click += new System.Windows.RoutedEventHandler(this.btnListarCon_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 33 "..\..\Inicio.xaml"
            ((MahApps.Metro.Controls.Tile)(target)).Click += new System.Windows.RoutedEventHandler(this.Volver);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\..\view\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "552DA8EDE5647A0114816CBFACB314B6935FB7EE67C74A01FA3051B5E41EAD5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DataGridView;
using RootLibrary.WPF.Localization;
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


namespace DataGridView {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Datos;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellidos;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEdad;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarPersona;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMostrarInforme;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBotonesAbajo;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\view\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridPersonas;
        
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
            System.Uri resourceLocater = new System.Uri("/DataGridView;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\MainWindow.xaml"
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
            
            #line 9 "..\..\..\view\MainWindow.xaml"
            ((DataGridView.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Datos = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtApellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtEdad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnAgregarPersona = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\view\MainWindow.xaml"
            this.btnAgregarPersona.Click += new System.Windows.RoutedEventHandler(this.btnAgregarPersona_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMostrarInforme = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\view\MainWindow.xaml"
            this.btnMostrarInforme.Click += new System.Windows.RoutedEventHandler(this.btnMostrarInforme_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.gridBotonesAbajo = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\view\MainWindow.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\view\MainWindow.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dataGridPersonas = ((System.Windows.Controls.DataGrid)(target));
            
            #line 67 "..\..\..\view\MainWindow.xaml"
            this.dataGridPersonas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridPersonas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


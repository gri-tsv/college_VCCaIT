#pragma checksum "..\..\Seller.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "150B2BE72DD372DEA95F7D43B0A48A2505C889DD43FB64A8FC296AE284242608"
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
using wpf_cSharpcorner_Login_Registration_Process;


namespace wpf_cSharpcorner_Login_Registration_Process {
    
    
    /// <summary>
    /// Seller
    /// </summary>
    public partial class Seller : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SellerTextBlock;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewOrderText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewClientText;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewOrderTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddOrderButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewClientTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewServiceTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Seller.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NewServiceText;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_cSharpcorner_Login_Registration_Process;component/seller.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Seller.xaml"
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
            this.SellerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.NewOrderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.NewClientText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.NewOrderTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Seller.xaml"
            this.AddOrderButton.Click += new System.Windows.RoutedEventHandler(this.AddOrderButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NewClientTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NewServiceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.NewServiceText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


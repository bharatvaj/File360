﻿

#pragma checksum "C:\Users\Home\Documents\Visual Studio 2013\Projects\Commercial\File360\File360\VaultPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "925D367140BB206C72383C1D572B1F8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace File360
{
    partial class VaultPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 51 "..\..\..\VaultPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.passwordBox_TextChanged;
                 #line default
                 #line hidden
                #line 51 "..\..\..\VaultPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).LostFocus += this.passwordBox_LostFocus;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 66 "..\..\..\VaultPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Grid_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

